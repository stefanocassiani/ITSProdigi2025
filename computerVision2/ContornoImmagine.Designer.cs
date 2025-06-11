namespace computerVision2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PctPreview = new PictureBox();
            BtnApriFile = new Button();
            TrkLight = new TrackBar();
            TrkMinimo = new TrackBar();
            TrkMassimo = new TrackBar();
            DlgApriFile = new OpenFileDialog();
            BtnAnalizza = new Button();
            label1 = new Label();
            label3 = new Label();
            BtnContorni = new Button();
            ((System.ComponentModel.ISupportInitialize)PctPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkMassimo).BeginInit();
            SuspendLayout();
            // 
            // PctPreview
            // 
            PctPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PctPreview.Location = new Point(12, 22);
            PctPreview.Name = "PctPreview";
            PctPreview.Size = new Size(634, 187);
            PctPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            PctPreview.TabIndex = 0;
            PctPreview.TabStop = false;
            PctPreview.Click += PctPreview_Click;
            // 
            // BtnApriFile
            // 
            BtnApriFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnApriFile.Location = new Point(25, 215);
            BtnApriFile.Name = "BtnApriFile";
            BtnApriFile.Size = new Size(621, 23);
            BtnApriFile.TabIndex = 1;
            BtnApriFile.Text = "apri";
            BtnApriFile.UseVisualStyleBackColor = true;
            BtnApriFile.Click += BtnApri_Click;
            // 
            // TrkLight
            // 
            TrkLight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TrkLight.Location = new Point(86, 275);
            TrkLight.Maximum = 100;
            TrkLight.Name = "TrkLight";
            TrkLight.Size = new Size(568, 45);
            TrkLight.SmallChange = 10;
            TrkLight.TabIndex = 2;
            // 
            // TrkMinimo
            // 
            TrkMinimo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TrkMinimo.Location = new Point(86, 326);
            TrkMinimo.Maximum = 360;
            TrkMinimo.Name = "TrkMinimo";
            TrkMinimo.Size = new Size(568, 45);
            TrkMinimo.TabIndex = 3;
            // 
            // TrkMassimo
            // 
            TrkMassimo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TrkMassimo.Location = new Point(86, 378);
            TrkMassimo.Maximum = 360;
            TrkMassimo.Name = "TrkMassimo";
            TrkMassimo.Size = new Size(568, 45);
            TrkMassimo.TabIndex = 4;
            // 
            // DlgApriFile
            // 
            DlgApriFile.FileName = "DlgApriFile";
            // 
            // BtnAnalizza
            // 
            BtnAnalizza.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnAnalizza.Location = new Point(25, 413);
            BtnAnalizza.Name = "BtnAnalizza";
            BtnAnalizza.Size = new Size(621, 23);
            BtnAnalizza.TabIndex = 5;
            BtnAnalizza.Text = "analizza";
            BtnAnalizza.UseVisualStyleBackColor = true;
            BtnAnalizza.Click += BtnAnalizza_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 275);
            label1.Name = "label1";
            label1.Size = new Size(66, 75);
            label1.TabIndex = 6;
            label1.Text = "Luminosita\r\n\r\nHue Min\r\n\r\nHue Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 261);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // BtnContorni
            // 
            BtnContorni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnContorni.Location = new Point(25, 473);
            BtnContorni.Name = "BtnContorni";
            BtnContorni.Size = new Size(621, 23);
            BtnContorni.TabIndex = 9;
            BtnContorni.Text = "trova contorni";
            BtnContorni.UseVisualStyleBackColor = true;
            BtnContorni.Click += BtnContorni_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 521);
            Controls.Add(BtnContorni);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(BtnAnalizza);
            Controls.Add(TrkMassimo);
            Controls.Add(TrkMinimo);
            Controls.Add(TrkLight);
            Controls.Add(BtnApriFile);
            Controls.Add(PctPreview);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PctPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkMassimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PctPreview;
        private Button BtnApriFile;
        private TrackBar TrkLight;
        private TrackBar TrkMinimo;
        private TrackBar TrkMassimo;
        private OpenFileDialog DlgApriFile;
        private Button BtnAnalizza;
        private Label label1;
        private Label label3;
        private Button BtnContorni;
    }
}
