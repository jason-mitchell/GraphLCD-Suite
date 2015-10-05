using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontIOInterface
{
    //------------------------------------------------------------------------------------------------------------------
    // Font file I/O class
    //------------------------------------------------------------------------------------------------------------------
    class FontFileIO
    {

        // Constants pertaining to the font file
        //--------------------------------------
        const UInt16 UniqueFileHeader = 0x198B;
        const UInt32 font_block_header = 0x03FEB964;
        const int FontDataLocation = 80;            // Offset 0x50 in the file
        const int HeaderSize = 17;                  // Fixed header, character code, mode byte, width field, height field, footer, footer padding

        public enum FileState
        {
            Loaded = 1,
            Closed = 2,
        };


        // Class variables
        //--------------------------------------------------
        byte[] FontFile = new byte[32768];          // 32k buffer for font character data...
        UInt16 Cell_X;
        UInt16 Cell_Y;
        UInt16 NumberOfCharacters;
        string identifier = "No Font File Loaded";
        byte FileStatus = (byte)FileState.Closed;

        //-----------------------------------------------------------------------------------------------------------------------
        // Methods
        //-----------------------------------------------------------------------------------------------------------------------

        // File State information Getter
        //--------------------------------------------------
        public byte getFileStatus()
        {
            return FileStatus;

        }

        // Font ID Getter
        //--------------------------------------------------
        public string getIdentifier(){
            return identifier;
        }

        // Font X size Getter
        //--------------------------------------------------
        public UInt16 GetFontXDim()
        {
            return Cell_X;
        }

        // Font Y size Getter
        //---------------------------------------------------
        public UInt16 GetFontYDim()
        {
            return Cell_Y;
        }

        // Font Data Getter
        //---------------------------------------------------------------------------------------------------------------
        public Boolean GetFontData(UInt16 charcode, ref byte[] glyphdata, ref byte width, ref byte height, ref byte mode)
        {

            Boolean Result = false;
            int offset = 0;
            UInt32 header = 0;
            UInt16 ccode = 0;

            // Iterative search for character in the array, if not found, return false...
            for (int x = 0; x < NumberOfCharacters; x++)
            {
                // Validate the header
                header = BitConverter.ToUInt32(FontFile, offset);
                if (header != font_block_header)
                {
                    return false;
                }

                // Header is good... see if the character field matches...
                ccode = BitConverter.ToUInt16(FontFile, (offset + 4));
                if (charcode == ccode)
                {
                    Result = true;
                    break;          // We have the desired character, break...
                }

                // Character field doesn't match, adjust the offset to the next potential character slot...
                offset += (Cell_X * Cell_Y) + HeaderSize;
            }

            // Check result.. if true, we have a character match and we can pull out what we need...
            if (Result == true)
            {
                // Retrieve the font info
                mode = FontFile[offset + 6];
                width = FontFile[offset + 7];
                height = FontFile[offset + 8];

                // Retrieve the font's pixel data....
                for (int y = 0; y < (Cell_X * Cell_Y); y++)
                {
                    glyphdata[y] = FontFile[offset + 9 + y];

                }
               

            }

            return Result;
        }


        // Font file close method
        // (Releases resources i.e. clear variables)
        //--------------------------------------------------
        public byte CloseFontFile()
        {
            FileStatus = (byte)FileState.Closed;
            identifier = "No Font File Loaded";

            return 1;
        }

        // Font file create method
        // Creates an empty file at the specified path. The mimimum of information is populated into the file
        // Parameters: Path, Identifier, X, Y, Num of Chars
        //-----------------------------------------------------------------------------------------------------
        public byte CreateFontFile(string FullFilePath, string identifier)
        {

            string Path = FullFilePath;

            return 1;
        }


        // Font file read/load method
        //--------------------------------------------------
        public byte ReadFontFile(string FullFilePath)
        {
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream(FullFilePath, FileMode.Open));
                if (br.ReadUInt16() == UniqueFileHeader)
                {
                    // File header is validated... begin pulling out the information
                    Cell_X = br.ReadUInt16();
                    Cell_Y = br.ReadUInt16();
                    NumberOfCharacters = br.ReadUInt16();
                    identifier = br.ReadString();
                    br.BaseStream.Seek(FontDataLocation, 0);                // Set position in stream to the start of the font data...

                    int LengthToRead = (Cell_X * Cell_Y) + HeaderSize;
                    LengthToRead = LengthToRead * NumberOfCharacters;
                    br.Read(FontFile, 0, LengthToRead);
                    br.Close();
                    FileStatus = (byte)FileState.Loaded;

                }
                else
                {
                    MessageBox.Show("Invalid File Format!", "File I/O error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Exception: " + e, "File I/O error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 1;
        }



    }
}
