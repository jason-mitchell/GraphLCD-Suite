namespace GraphLCD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusIndication = new System.Windows.Forms.StatusStrip();
            this.SystemState = new System.Windows.Forms.ToolStripStatusLabel();
            this.FontID = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoCharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iBISEasyGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CharPreview = new System.Windows.Forms.PictureBox();
            this.NextCharButton = new System.Windows.Forms.Button();
            this.PrevCharButton = new System.Windows.Forms.Button();
            this.CharCodeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CharacterEdit = new System.Windows.Forms.PictureBox();
            this.PreviewMagnification = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StatusIndication.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewMagnification)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusIndication
            // 
            this.StatusIndication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemState,
            this.FontID});
            this.StatusIndication.Location = new System.Drawing.Point(0, 613);
            this.StatusIndication.Name = "StatusIndication";
            this.StatusIndication.Size = new System.Drawing.Size(933, 22);
            this.StatusIndication.TabIndex = 0;
            // 
            // SystemState
            // 
            this.SystemState.Name = "SystemState";
            this.SystemState.Size = new System.Drawing.Size(0, 17);
            // 
            // FontID
            // 
            this.FontID.Margin = new System.Windows.Forms.Padding(6, 3, 0, 2);
            this.FontID.Name = "FontID";
            this.FontID.Size = new System.Drawing.Size(0, 17);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(933, 28);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFontToolStripMenuItem,
            this.openFontToolStripMenuItem,
            this.saveFontToolStripMenuItem,
            this.closeFontToolStripMenuItem,
            this.quitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFontToolStripMenuItem
            // 
            this.newFontToolStripMenuItem.Name = "newFontToolStripMenuItem";
            this.newFontToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.newFontToolStripMenuItem.Text = "New Font";
            this.newFontToolStripMenuItem.Click += new System.EventHandler(this.newFontToolStripMenuItem_Click);
            // 
            // openFontToolStripMenuItem
            // 
            this.openFontToolStripMenuItem.Name = "openFontToolStripMenuItem";
            this.openFontToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.openFontToolStripMenuItem.Text = "Open Font";
            this.openFontToolStripMenuItem.Click += new System.EventHandler(this.openFontToolStripMenuItem_Click);
            // 
            // saveFontToolStripMenuItem
            // 
            this.saveFontToolStripMenuItem.Name = "saveFontToolStripMenuItem";
            this.saveFontToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.saveFontToolStripMenuItem.Text = "Save Font";
            // 
            // closeFontToolStripMenuItem
            // 
            this.closeFontToolStripMenuItem.Name = "closeFontToolStripMenuItem";
            this.closeFontToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.closeFontToolStripMenuItem.Text = "Close Font";
            // 
            // quitApplicationToolStripMenuItem
            // 
            this.quitApplicationToolStripMenuItem.Name = "quitApplicationToolStripMenuItem";
            this.quitApplicationToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.quitApplicationToolStripMenuItem.Text = "Quit Application";
            this.quitApplicationToolStripMenuItem.Click += new System.EventHandler(this.quitApplicationToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.gotoCharToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.importToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // gotoCharToolStripMenuItem
            // 
            this.gotoCharToolStripMenuItem.Name = "gotoCharToolStripMenuItem";
            this.gotoCharToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.gotoCharToolStripMenuItem.Text = "Goto Char";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iBISEasyGUIToolStripMenuItem,
            this.legacyToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // iBISEasyGUIToolStripMenuItem
            // 
            this.iBISEasyGUIToolStripMenuItem.Name = "iBISEasyGUIToolStripMenuItem";
            this.iBISEasyGUIToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.iBISEasyGUIToolStripMenuItem.Text = "IBIS EasyGUI...";
            // 
            // legacyToolStripMenuItem
            // 
            this.legacyToolStripMenuItem.Name = "legacyToolStripMenuItem";
            this.legacyToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.legacyToolStripMenuItem.Text = "Legacy...";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpTopicsToolStripMenuItem
            // 
            this.helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
            this.helpTopicsToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.helpTopicsToolStripMenuItem.Text = "Help Topics";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.NextCharButton);
            this.groupBox1.Controls.Add(this.PrevCharButton);
            this.groupBox1.Controls.Add(this.CharCodeLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CharacterEdit);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 531);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Editor";
            // 
            // CharPreview
            // 
            this.CharPreview.Location = new System.Drawing.Point(6, 21);
            this.CharPreview.Name = "CharPreview";
            this.CharPreview.Size = new System.Drawing.Size(64, 64);
            this.CharPreview.TabIndex = 5;
            this.CharPreview.TabStop = false;
            // 
            // NextCharButton
            // 
            this.NextCharButton.Enabled = false;
            this.NextCharButton.Location = new System.Drawing.Point(410, 492);
            this.NextCharButton.Name = "NextCharButton";
            this.NextCharButton.Size = new System.Drawing.Size(75, 33);
            this.NextCharButton.TabIndex = 4;
            this.NextCharButton.Text = "NEXT >";
            this.NextCharButton.UseVisualStyleBackColor = true;
            // 
            // PrevCharButton
            // 
            this.PrevCharButton.Enabled = false;
            this.PrevCharButton.Location = new System.Drawing.Point(6, 492);
            this.PrevCharButton.Name = "PrevCharButton";
            this.PrevCharButton.Size = new System.Drawing.Size(75, 33);
            this.PrevCharButton.TabIndex = 3;
            this.PrevCharButton.Text = "< PREV";
            this.PrevCharButton.UseVisualStyleBackColor = true;
            // 
            // CharCodeLabel
            // 
            this.CharCodeLabel.AutoSize = true;
            this.CharCodeLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharCodeLabel.Location = new System.Drawing.Point(472, 18);
            this.CharCodeLabel.Name = "CharCodeLabel";
            this.CharCodeLabel.Size = new System.Drawing.Size(0, 33);
            this.CharCodeLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHARACTER CODE";
            // 
            // CharacterEdit
            // 
            this.CharacterEdit.Location = new System.Drawing.Point(44, 50);
            this.CharacterEdit.Name = "CharacterEdit";
            this.CharacterEdit.Size = new System.Drawing.Size(400, 400);
            this.CharacterEdit.TabIndex = 0;
            this.CharacterEdit.TabStop = false;
            // 
            // PreviewMagnification
            // 
            this.PreviewMagnification.Location = new System.Drawing.Point(6, 91);
            this.PreviewMagnification.Maximum = 5;
            this.PreviewMagnification.Name = "PreviewMagnification";
            this.PreviewMagnification.Size = new System.Drawing.Size(64, 56);
            this.PreviewMagnification.TabIndex = 6;
            this.PreviewMagnification.ValueChanged += new System.EventHandler(this.PreviewMagnification_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CharPreview);
            this.groupBox2.Controls.Add(this.PreviewMagnification);
            this.groupBox2.Location = new System.Drawing.Point(450, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 157);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StatusIndication);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.StatusIndication.ResumeLayout(false);
            this.StatusIndication.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewMagnification)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusIndication;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel SystemState;
        private System.Windows.Forms.ToolStripStatusLabel FontID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CharacterEdit;
        private System.Windows.Forms.Label CharCodeLabel;
        private System.Windows.Forms.Button PrevCharButton;
        private System.Windows.Forms.Button NextCharButton;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoCharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iBISEasyGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox CharPreview;
        private System.Windows.Forms.TrackBar PreviewMagnification;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

