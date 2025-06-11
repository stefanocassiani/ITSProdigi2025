namespace ComputerVision1
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
            PctPreview = new PictureBox();
            BtnCalcola = new Button();
            TrkSoglia = new TrackBar();
            openFileDialog1 = new OpenFileDialog();
            TxtRisultato = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PctPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkSoglia).BeginInit();
            SuspendLayout();
            // 
            // PctPreview
            // 
            PctPreview.Location = new Point(44, 12);
            PctPreview.Name = "PctPreview";
            PctPreview.Size = new Size(743, 194);
            PctPreview.TabIndex = 0;
            PctPreview.TabStop = false;
            // 
            // BtnCalcola
            // 
            BtnCalcola.Location = new Point(12, 477);
            BtnCalcola.Name = "BtnCalcola";
            BtnCalcola.Size = new Size(488, 23);
            BtnCalcola.TabIndex = 1;
            BtnCalcola.Text = "calcola";
            BtnCalcola.UseVisualStyleBackColor = true;
            BtnCalcola.Click += BtnCalcola_Click;
            // 
            // TrkSoglia
            // 
            TrkSoglia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TrkSoglia.Location = new Point(12, 338);
            TrkSoglia.Name = "TrkSoglia";
            TrkSoglia.Size = new Size(789, 45);
            TrkSoglia.TabIndex = 3;
            TrkSoglia.Scroll += TrkSoglia_Scroll;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // TxtRisultato
            // 
            TxtRisultato.Location = new Point(44, 365);
            TxtRisultato.Multiline = true;
            TxtRisultato.Name = "TxtRisultato";
            TxtRisultato.Size = new Size(743, 70);
            TxtRisultato.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(44, 212);
            button1.Name = "button1";
            button1.Size = new Size(488, 23);
            button1.TabIndex = 4;
            button1.Text = "calcola";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 512);
            Controls.Add(button1);
            Controls.Add(TrkSoglia);
            Controls.Add(TxtRisultato);
            Controls.Add(BtnCalcola);
            Controls.Add(PctPreview);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PctPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkSoglia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PctPreview;
        private Button BtnCalcola;
        private TrackBar TrkSoglia;
        private OpenFileDialog openFileDialog1;
        private TextBox TxtRisultato;
        private Button button1;
    }
}