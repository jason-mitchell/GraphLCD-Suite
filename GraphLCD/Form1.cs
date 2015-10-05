using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FontIOInterface;      // Font file I/O Class
using RenderLib;            // Font Rendering Class

namespace GraphLCD
{
    public partial class Form1 : Form
    {
        //----------------------------------------------------------------
        // Global/static vars
        //----------------------------------------------------------------
            
        // Classes
            FontFileIO CurrentFont;
            Renderer FontRenderer;

        // Local vars
            
            byte x;
            byte y;
            byte z;
            byte[] newarray = new byte[64];
            byte[] testdata = new byte[160];
            UInt16 CharacterSelection = 0x41;
            Boolean FileLoaded = false;
            byte PreviewMagValue = 0;    

        public Form1()
        {            
            InitializeComponent();
            SystemState.Text = "Ready";
            CharCodeLabel.Text = CharacterSelection.ToString("X4"); 
            CharCodeLabel.Enabled = false;
            CurrentFont = new FontFileIO();         // Class is instantiated... and ready for use...
            // Test our class...
            FontRenderer = new Renderer();          // Instantiation of class...
            
            testdata[0] = 1;
            testdata[1] = 0;
            testdata[2] = 0;
            testdata[3] = 0;
            testdata[4] = 0;
            testdata[5] = 0;
            testdata[6] = 0;
            testdata[7] = 0;

            testdata[8] = 0;
            testdata[9] = 1;
            testdata[10] = 0;
            testdata[11] = 0;
            testdata[12] = 0;
            testdata[13] = 0;
            testdata[14] = 0;
            testdata[15] = 0;

            testdata[16] = 0;
            testdata[17] = 0;
            testdata[18] = 1;
            testdata[19] = 0;
            testdata[20] = 0;
            testdata[21] = 0;
            testdata[22] = 0;
            testdata[23] = 0;

            testdata[24] = 0;
            testdata[25] = 0;
            testdata[26] = 0;
            testdata[27] = 1;
            testdata[28] = 0;
            testdata[29] = 0;
            testdata[30] = 0;
            testdata[31] = 0;


            FontRenderer.SetXSize(8);
            FontRenderer.SetYSize(8);
            Bitmap PreviewCanvas = new Bitmap(128, 128);
            Bitmap CharCanvas = new Bitmap((FontRenderer.GetXSize() * 16) + FontRenderer.GetXSize() + 1, (FontRenderer.GetYSize() * 16) + FontRenderer.GetYSize() + 1); // Here we need to compute the size of the bitmap required to hold all our info...
            FontRenderer.RenderCharacter(ref CharCanvas, ref testdata, 0, 0);
            FontRenderer.RenderPreview(ref PreviewCanvas, ref testdata, PreviewMagValue);
            CharacterEdit.Image = null;
            CharacterEdit.Image = CharCanvas;
            CharPreview.Image = null;
            CharPreview.Image = PreviewCanvas;
           


        }


        //------------------------------------------------------------------------
        // Private methods
        //------------------------------------------------------------------------
        void EnableCharacterEditControls()
        {
            CharCodeLabel.Enabled = true;
            PrevCharButton.Enabled = true;
            NextCharButton.Enabled = true;

        }

        //-------------------------------------------------------------------------
        // Event handlers on the form
        //-------------------------------------------------------------------------

        // File -> Open
        //----------------
        private void openFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFontFileDialog = new OpenFileDialog();       // Instantiate the .net class
            OpenFontFileDialog.InitialDirectory = "c:\\";
            OpenFontFileDialog.Filter = "GraphLCD Font files (*.fon)|*.fon";  
            OpenFontFileDialog.FilterIndex = 1;
            OpenFontFileDialog.RestoreDirectory = true;
            if (OpenFontFileDialog.ShowDialog() == DialogResult.OK)
            {
                // A file has been selected, open the file and load to memory..
                CurrentFont.ReadFontFile(OpenFontFileDialog.FileName);              // Read the font file
                if (CurrentFont.getFileStatus() == (byte)FontFileIO.FileState.Loaded)
                {
                    FileLoaded = true;
                    SystemState.Text = "Font Loaded: ";

                }

                // If the file is loaded, display the default character (0x0041) and enable all the form stuff...
                if (FileLoaded == true)
                {
                    EnableCharacterEditControls();
                    FontID.Text = CurrentFont.getIdentifier();                                          // Get the identification string...
                    CurrentFont.GetFontData(CharacterSelection, ref newarray, ref x, ref y, ref z);     // Get a character's data...
                }


            }

        }

        // File -> New Font
        //-----------------
        private void newFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 CreateOptions = new Form2();
            CreateOptions.Show();
        }

        // File -> Quit Application
        //--------------------------
        private void quitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Slider is changed... when it is changed, alter the magnification of the preview...
        private void PreviewMagnification_ValueChanged(object sender, EventArgs e)
        {
            PreviewMagValue = Convert.ToByte(PreviewMagnification.Value);
            Bitmap Pvc = new Bitmap(128, 128);
            FontRenderer.RenderPreview(ref Pvc, ref testdata, PreviewMagValue);
            CharPreview.Image = Pvc;
        }
    }
}
