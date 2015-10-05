//
//                          Filename: RenderLib
//                  Classes for rendering LCD typefaces to a bitmap
//
//
//
//
//
//
//---------------------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RenderLib
{

    //-----------------------------------------------------------------------------------------------------------------
    // Sample Font data class - Used primarily for UX
    //-----------------------------------------------------------------------------------------------------------------
    class SampleData
    {

        // Variables
        byte[] SampleSet;


        // Public methods
        //---------------

        public void GenerateSampleSet(ref byte[] fontdata, int x_size, int y_size)
        {

            SampleSet = new byte[x_size * y_size];      // Create new instance of parent array, sized to input parameters
            SampleSet.Initialize();                     // Ensure array is cleared before we begin

            // 5 x 7 case
            //--------------------------
            if (x_size == 6)
            {
                if (y_size == 8)
                {

                    SampleSet[0] = 0;
                    SampleSet[1] = 0;
                    SampleSet[2] = 255;
                    SampleSet[3] = 0;
                    SampleSet[4] = 0;
                    SampleSet[5] = 0;

                    SampleSet[6] = 0;
                    SampleSet[7] = 255;
                    SampleSet[8] = 0;
                    SampleSet[9] = 255;
                    SampleSet[10] = 0;
                    SampleSet[11] = 0;

                    SampleSet[12] = 0;
                    SampleSet[13] = 255;
                    SampleSet[14] = 0;
                    SampleSet[15] = 255;
                    SampleSet[16] = 0;
                    SampleSet[17] = 0;

                    SampleSet[18] = 255;
                    SampleSet[19] = 0;
                    SampleSet[20] = 0;
                    SampleSet[21] = 0;
                    SampleSet[22] = 255;
                    SampleSet[23] = 0;

                    SampleSet[24] = 255;
                    SampleSet[25] = 255;
                    SampleSet[26] = 255;
                    SampleSet[27] = 255;
                    SampleSet[28] = 255;
                    SampleSet[29] = 0;

                    SampleSet[30] = 255;
                    SampleSet[31] = 0;
                    SampleSet[32] = 0;
                    SampleSet[33] = 0;
                    SampleSet[34] = 255;
                    SampleSet[35] = 0;

                    SampleSet[36] = 255;
                    SampleSet[37] = 0;
                    SampleSet[38] = 0;
                    SampleSet[39] = 0;
                    SampleSet[40] = 255;
                    SampleSet[41] = 0;

                    SampleSet[42] = 0;
                    SampleSet[43] = 0;
                    SampleSet[44] = 0;
                    SampleSet[45] = 0;
                    SampleSet[46] = 0;
                    SampleSet[47] = 0;
                }
            }
            fontdata = SampleSet;

        }


    }

    //------------------------------------------------------------------------------------------------------------------
    // Typographic Rendering class
    //------------------------------------------------------------------------------------------------------------------
    class Renderer
    {
    
        // Variables
        //-------------

        int pixel_x = 0;
        int pixel_y = 0;
        int x_accum = 0;
        int y_accum = 0;
        int int_y_ref = 0;


        // Public Methods
        //--------------------------
        public void SetXSize(int x)
        {
            pixel_x = x;
        }

        public void SetYSize(int y)
        {
            pixel_y = y;
        }

        public int GetXSize()
        {
            return pixel_x;
        }

        public int GetYSize()
        {
            return pixel_y;
        }


        // Name: RenderCharacter
        // Function: Renders a complete LCD bitmapped character (complete with pixel grid)
        // Parameters: Target bitmap to render to, array holding pixel data (monochrome), position of vertical reference line, position of horizontal reference line
        // Returns: void
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        public void RenderCharacter(ref Bitmap bmp0, ref byte[] characterbitmap, int vertrefline, int horrefline)
        {
            byte[] pixel_row_data = new byte[32];          // Array for row rendering
            UInt32 byte_pointer = 0;                       // Pointer into source array 

            for (int b = 0; b < pixel_y; b++)
            {

                for (UInt32 r = 0; r < pixel_x; r++)
                {
                    pixel_row_data[r] = characterbitmap[byte_pointer];
                    byte_pointer++;
                }

                RenderRowPixels(ref bmp0, ref pixel_row_data, vertrefline, horrefline);

            }
            x_accum = 0;
            y_accum = 0;
            int_y_ref = 0;

        }

        // Name: RenderPreview
        // Function: Renders a preview bitmap of the character with no pixel grid, at the specified scale factor
        // Parameters: (reference) Target Bitmap, (reference) Source Data, Scale Factor)
        // Returns: void
        //---------------------------------------------------------------------------------------------------------
        public void RenderPreview(ref Bitmap bmp0, ref byte[] input_data, byte scalefactor)
        {
                byte [] pixel_row_data = new byte [32];
                int offset = 0;
                for (int r = 0; r < pixel_y; r++)
                {
                    // Copy a row of pixels to the line buffer
                    for (int y = 0; y < pixel_x; y++)
                    {
                        pixel_row_data[y] = input_data[y + offset];

                    }
                    offset += pixel_x;          // Add the X-dimension to the offset so we get the next row of pixels

                    // Render the row...
                    for (int s = 0; s < scalefactor + 1; s++)
                    {
                        RenderPreviewRow(ref bmp0, ref pixel_row_data, scalefactor);     // draw single row...
                        y_accum++;
                    }
                }

                x_accum = 0;
                y_accum = 0;

        }



        // Private methods
        //-----------------

        // Name: RenderPreviewRow
        // Function: Render a single row of pixels in preview mode i.e. sans the grid
        // Parameters: Bitmap to render to, pixel data array, scaling factor (1, 2)
        //------------------------------------------------------------------------------------------------------------------------------
        private void RenderPreviewRow(ref Bitmap bmp, ref byte[] pixel_data, byte sfactor)
        {
            int pixel_selector = 0;                         // Selector for array row_pixels

            for (int i = 0; i < pixel_x; i++)
            {
                for (int sf = 0; sf < sfactor + 1; sf++)
                {
                    if (pixel_data[pixel_selector] == 0x00)
                    {
                        bmp.SetPixel(x_accum, y_accum, Color.White);   // Pixel is white....
                    }
                    else
                    {
                        bmp.SetPixel(x_accum, y_accum, Color.Black);   // Pixel is black...
                    }
                    x_accum++;
                }
                pixel_selector++;

            }
            x_accum = 0;

        }

        //------------------------------------------------------------------------------------------------------------------------------
        // Name: RenderRowPixels
        // Function: Draws a single row of LCD style pixels, and fills those pixels as required.
        // Parameters: Bitmap to draw to, passed by reference, Array holding pixel values. Each element in the array corresponds to a
        //             single pixel in a single row. 
        // Returns: void
        //-------------------------------------------------------------------------------------------------------------------------------
        private void RenderRowPixels(ref Bitmap bmp, ref byte[] pixel_data, int x_reference, int y_reference)
        {
            int pixel_color = 0;                            // Pixel colour selector...
            int pixel_selector = 0;                         // Selector for array row_pixels
            
 

            // Render outermost horizontal border
            for (int i = 0; i < (pixel_x * 16) + pixel_x + 1; i++)
            {
                if (int_y_ref == y_reference)
                {
                    if (y_reference != 0)
                    {
                        bmp.SetPixel(i, y_accum, Color.LimeGreen);
                    }
                    else
                    {
                        bmp.SetPixel(i, y_accum, Color.LightGray);
                    }
                }
                else
                {
                    bmp.SetPixel(i, y_accum, Color.LightGray);
                }
            }
            y_accum++;
            int_y_ref++;

            for (int k = 0; k < 16; k++)
            {

                // Render horizontally

                // Border pixel
                bmp.SetPixel(x_accum, y_accum, Color.LightGray);    // leftmost outer border    
                x_accum++;

                // Inner block space
                for (int i = 0; i < pixel_x; i++)
                {
                    // Pixel read-out to be performed here.....
                    if (pixel_data[pixel_selector] == 0x00)
                    {
                        pixel_color = 0;
                    }
                    else
                    {
                        pixel_color = 1;
                    }
                    // Inner fill pixels
                    for (int j = 0; j < 16; j++)  // the inner block is 16 pixels wide...
                    {
                        if (pixel_color == 0)
                        {
                            bmp.SetPixel(x_accum, y_accum, Color.White);   // Inners of white
                        }
                        else
                        {
                            bmp.SetPixel(x_accum, y_accum, Color.Black);   // Inners of black
                        }
                        x_accum++;
                    }
                    // Border pixel (right hand side)
                    if (x_reference - 1 == pixel_selector)
                    {
                        bmp.SetPixel(x_accum, y_accum, Color.Red);        // rightmost outer border
                    }
                    else
                    {
                        bmp.SetPixel(x_accum, y_accum, Color.LightGray);        // rightmost outer border
                    }
                    x_accum++;
                    pixel_selector++;
                }
                pixel_selector = 0;
                x_accum = 0;
                y_accum++;

            }
            // Draw bottom-most horizontal line right across the graphics plane size
            for (int i = 0; i < (pixel_x * 16) + pixel_x + 1; i++)
            {
                    bmp.SetPixel(i, y_accum, Color.LightGray);
            }

        }

    }


}