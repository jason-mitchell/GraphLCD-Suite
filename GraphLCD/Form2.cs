//-------------------------------------------------------------------------------------------------------------------------------------
//
//                              Filename: Form2.cs
//                              Code for the Font File creation options form
//
//
//
//-------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RenderLib;
using FontIOInterface;                      // Font file I/O Class
using Microsoft.VisualBasic.PowerPacks;     // Needed to access some extended property of the rectangle objects on my form

namespace GraphLCD
{
    public partial class Form2 : Form
    {
        // Classes we wish to use here...
        Renderer FontPreviewRenderer;
        Boolean CanUpdate = false;
        Boolean UnicodeMode = false;

        public Form2()
        {
            InitializeComponent();
            AnsiRb.Checked = true;                  // Initial state on the form of this radio button...
            LCDHorizontal.Checked = true;           // Initial state on the form of this radio button...
            FontPreviewRenderer = new Renderer();   // Instantiate the rendering class we use to draw stuff...
            Byte1.ForeColor = Color.Red;
            Byte2.ForeColor = Color.Red;
            Byte3.ForeColor = Color.Red;
            Byte4.ForeColor = Color.Red;
            ByteA.ForeColor = Color.Green;
            ByteB.ForeColor = Color.Green;
            ByteC.ForeColor = Color.Green;
            ByteD.ForeColor = Color.Green;
            ByteA.Visible = false;
            ByteB.Visible = false;
            ByteC.Visible = false;
            ByteD.Visible = false;
            Byte1.Visible = false;
            Byte2.Visible = false;
            Byte3.Visible = false;
            Byte4.Visible = false;
            HorByteMarker2.Visible = false;
            HorByteMarker3.Visible = false;
            HorByteMarker4.Visible = false;
            XDimension.SelectedIndex = 1;
            YDimension.SelectedIndex = 0;
            KerningEdge.SelectedIndex = 0;
            Baseline.SelectedIndex = 0;
            CanUpdate = true;                       // Combo boxes have been initialised, so enable the event handler internals
            XDimension.SelectedIndex = 0;           // Trigger an update...
            WarningLabel.Text = "";
            StatusLabel1.Text = "";
            SynchCheckBox.Checked = true;
            KerningEdge.Enabled = false;
            Baseline.Enabled = false;
            

        }

        // Private Methods
        //-----------------
        void GeneratePreview()
        {

            // Initial state prior to update
            HorByteMarker2.Visible = false;
            HorByteMarker3.Visible = false;
            HorByteMarker4.Visible = false;
            VerticalByteMarker2.Visible = false;
            VerticalByteMarker3.Visible = false;
            VerticalByteMarker4.Visible = false;
            ByteA.Visible = false;
            ByteB.Visible = false;
            ByteC.Visible = false;
            ByteD.Visible = false;
            Byte1.Visible = false;
            Byte2.Visible = false;
            Byte3.Visible = false;
            Byte4.Visible = false;

            // Manage the markers on the the display
            if (LCDHorizontal.Checked == true)
            {
                HorByteMarker1.Visible = true;
                HorByteMarker1.FillStyle = FillStyle.Solid;
                VerticalByteMarker1.Visible = false;
                VerticalByteMarker1.FillStyle = FillStyle.Transparent;
                Byte1.Visible = false;
                ByteA.Visible = true;
                OriginX.Visible = false;
                OriginX.Visible = true;
                label3.Visible = false;
                label3.Visible = true;  // label 3 is one of the origin markers... accidentally not renamed

                if (Convert.ToInt16(XDimension.Text) > 8)
                {
                    HorByteMarker2.Visible = true;
                    ByteB.Visible = true;

                }

                if (Convert.ToInt16(XDimension.Text) > 16)
                {
                    HorByteMarker3.Visible = true;
                    ByteC.Visible = true;

                }

                if (Convert.ToInt16(XDimension.Text) > 24)
                {
                    HorByteMarker4.Visible = true;
                    ByteD.Visible = true;

                }

            }
            else
            {
                HorByteMarker1.Visible = false;
                HorByteMarker1.FillStyle = FillStyle.Transparent;
                VerticalByteMarker1.Visible = true;
                VerticalByteMarker1.FillStyle = FillStyle.Solid;
                Byte1.Visible = true;
                ByteA.Visible = false;
                OriginX.Visible = false;
                OriginX.Visible = true;
                label3.Visible = false;
                label3.Visible = true;

                if (Convert.ToInt16(YDimension.Text) > 8)
                {
                    VerticalByteMarker2.Visible = true;
                    Byte2.Visible = true;

                }

                if (Convert.ToInt16(YDimension.Text) > 16)
                {
                    VerticalByteMarker3.Visible = true;
                    Byte3.Visible = true;

                }

                if (Convert.ToInt16(YDimension.Text) > 24)
                {
                    VerticalByteMarker4.Visible = true;
                    Byte4.Visible = true;

                }



            }

            // Adjust kerning and baseline according to changes made
            //---------------------------------------------------------------

            if (SynchCheckBox.Checked == true)
            {
                int kern = Convert.ToInt16(XDimension.Text);
                kern = kern - 3;
                KerningEdge.SelectedIndex = kern;

                int baseline = Convert.ToInt16(YDimension.Text);
                baseline = baseline - 3;
                Baseline.SelectedIndex = baseline;
            }


            // Render the preview of the grid
            //-------------------------------------------------------------

            int fontx = Convert.ToInt16(XDimension.Text);
            int fonty = Convert.ToInt16(YDimension.Text);
            fontx -= 1;
            fonty -= 1;
            FontSizeLabel.Text = "Font Size: " + fontx + " x " + fonty + " pixels";
            


            FontPreviewRenderer.SetXSize(Convert.ToInt16(XDimension.Text));
            FontPreviewRenderer.SetYSize(Convert.ToInt16(YDimension.Text));
            Bitmap previewcanvas = new Bitmap((FontPreviewRenderer.GetXSize() * 16) + FontPreviewRenderer.GetXSize() + 1, (FontPreviewRenderer.GetYSize() * 16) + FontPreviewRenderer.GetYSize() + 1);
            byte[] nullarray = new byte[FontPreviewRenderer.GetXSize() * FontPreviewRenderer.GetYSize()];


            // Copy a test character into the array for user experience when he selects a standard font size...
            SampleData UXData = new SampleData();
            UXData.GenerateSampleSet(ref nullarray, Convert.ToInt16(XDimension.Text), Convert.ToInt16(YDimension.Text));
            
            FontPreviewRenderer.RenderCharacter(ref previewcanvas, ref nullarray, Convert.ToInt16(KerningEdge.Text), Convert.ToInt16(Baseline.Text));
            FontSizePreview.Image = previewcanvas;

            // Updates to icons on the form
            // Standard font sizes
            //------------------------------------------------------------------------------------------
            // 5 x 7 font
            if ((XDimension.Text == "5" && YDimension.Text == "7") || (XDimension.Text == "8" && YDimension.Text == "8"))
            {
                    StatusIcon1.Image = SystemIcons.Information.ToBitmap();
                    StatusLabel1.Text = "Standard Font Size";
                
            }
            else
            {
                StatusIcon1.Image = null;
                StatusLabel1.Text = "";
            }

            // Kerning out-of-range error handling and Baseline out-of-range error handling
            //------------------------------------------------------------------------------
            int KE = Convert.ToInt16(KerningEdge.Text);
            int XE = Convert.ToInt16(XDimension.Text);
            int BE = Convert.ToInt16(Baseline.Text);
            int YE = Convert.ToInt16(YDimension.Text);
            string errormsg = "";
            if ((KE > XE) || (BE > YE))
            {

                StatusIcon2.Image = SystemIcons.Warning.ToBitmap();
                if (KE > XE)
                {
                    KerningWarningIcon.Image = SystemIcons.Warning.ToBitmap();
                    errormsg += "Kerning, ";
                }
                else
                {
                    KerningWarningIcon.Image = null;
                }
                if (BE > YE)
                {
                    BaselineWarningIcon.Image = SystemIcons.Warning.ToBitmap();
                    errormsg += "Baseline, ";
                }
                else
                {
                    BaselineWarningIcon.Image = null;
                }

                StatusLabel2.Text =  errormsg + "out of range!";


            }
            else
            {
                StatusIcon2.Image = null;
                StatusLabel2.Text = null;
                KerningWarningIcon.Image = null;
                BaselineWarningIcon.Image = null;
            }

        }


        //----------------------------------------------------------
        // Form's event handlers
        //----------------------------------------------------------

        // Accept button's event handler
        //----------------------------------------------------------
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFontFileDialog = new SaveFileDialog();       // Instantiate the .net class
            SaveFontFileDialog.Filter = "Font files (*.fon)|*.fon";
            SaveFontFileDialog.FilterIndex = 1;
            SaveFontFileDialog.RestoreDirectory = true;
            if (SaveFontFileDialog.ShowDialog() == DialogResult.OK)         // The dialog automatically handles the case of overwriting existing files, and issues warnings...
            {
                   // Information is in the form... create the file... (empty file with bare minimum of information)
                FontFileIO FileIO = new FontFileIO();
                FileIO.CreateFontFile(SaveFontFileDialog.FileName, FileIdent.Text);
                   
            }


            this.Close();
        }

        // Cancel button's event handler
        //-----------------------------------------------------------
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // X-Dimension setting changed Event handler
        //-------------------------------------------
        private void XDimension_TextChanged(object sender, EventArgs e)
        {
            if (CanUpdate)
            {
                GeneratePreview();
            }
        }

        // Y-Dimension setting changed Event handler
        //------------------------------------------
        private void YDimension_TextChanged(object sender, EventArgs e)
        {
            if (CanUpdate)
            {
                GeneratePreview();
            }

        }

        // When the Radio button is changed, force update
        //------------------------------------------------
        private void LCDHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            if (CanUpdate)
            {
                GeneratePreview();
            }
        }

        // Kerning value changed event
        private void KerningEdge_TextChanged(object sender, EventArgs e)
        {
            if (CanUpdate)
            {

                    GeneratePreview();
            }

        }

        // Unicode radio button changed event
        private void UnicodeRb_CheckedChanged(object sender, EventArgs e)
        {
            if (UnicodeRb.Checked == true)
            {
                NumOfCharacters.Enabled = true;
                UnicodeMode = true;
                WarningIconImage.Image = SystemIcons.Warning.ToBitmap();
                WarningLabel.Text = "Warning: Unicode fonts can consume large amounts of system resources on embedded systems!";
            }
            else
            {
                NumOfCharacters.Enabled = false;
                UnicodeMode = false;
                WarningIconImage.Image = null;
                WarningLabel.Text = "";

            }
        }

        // Baseline value changed event...
        private void Baseline_TextChanged(object sender, EventArgs e)
        {
            if (CanUpdate)
            {
                    GeneratePreview();
            }

        }

        // Synch check box has changed
        private void SynchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SynchCheckBox.Checked == false)
            {

                KerningEdge.Enabled = true;
                Baseline.Enabled = true;
            }
            else
            {

                KerningEdge.Enabled = false;
                Baseline.Enabled = false;


            }

        }


    }
}
