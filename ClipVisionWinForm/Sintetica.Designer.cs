namespace CRM
{
    partial class Sintetica
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
            PctBox = new PictureBox();
            BtnScegliPercorso = new Button();
            BtnAnteprima = new Button();
            BtnCreaSintetiche = new Button();
            TrkFiltro = new TrackBar();
            DlgApri = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)PctBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkFiltro).BeginInit();
            SuspendLayout();
            // 
            // PctBox
            // 
            PctBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PctBox.Location = new Point(12, 12);
            PctBox.Name = "PctBox";
            PctBox.Size = new Size(395, 205);
            PctBox.TabIndex = 0;
            PctBox.TabStop = false;
            PctBox.Click += PctBox_Click;
            // 
            // BtnScegliPercorso
            // 
            BtnScegliPercorso.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnScegliPercorso.Location = new Point(12, 315);
            BtnScegliPercorso.Name = "BtnScegliPercorso";
            BtnScegliPercorso.Size = new Size(193, 27);
            BtnScegliPercorso.TabIndex = 1;
            BtnScegliPercorso.Text = "scegli percorso";
            BtnScegliPercorso.UseVisualStyleBackColor = true;
            BtnScegliPercorso.Click += BtnScegliPercorso_Click;
            // 
            // BtnAnteprima
            // 
            BtnAnteprima.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnAnteprima.Location = new Point(12, 286);
            BtnAnteprima.Name = "BtnAnteprima";
            BtnAnteprima.Size = new Size(395, 23);
            BtnAnteprima.TabIndex = 2;
            BtnAnteprima.Text = "anteprima";
            BtnAnteprima.UseVisualStyleBackColor = true;
            BtnAnteprima.Click += BtnAnteprima_Click;
            // 
            // BtnCreaSintetiche
            // 
            BtnCreaSintetiche.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCreaSintetiche.Location = new Point(211, 315);
            BtnCreaSintetiche.Name = "BtnCreaSintetiche";
            BtnCreaSintetiche.Size = new Size(196, 27);
            BtnCreaSintetiche.TabIndex = 3;
            BtnCreaSintetiche.Text = "crea sintetiche";
            BtnCreaSintetiche.UseVisualStyleBackColor = true;
            BtnCreaSintetiche.Click += BtnCreaSintetiche_Click;
            // 
            // TrkFiltro
            // 
            TrkFiltro.Location = new Point(12, 235);
            TrkFiltro.Maximum = 255;
            TrkFiltro.Minimum = 50;
            TrkFiltro.Name = "TrkFiltro";
            TrkFiltro.Size = new Size(395, 45);
            TrkFiltro.TabIndex = 4;
            TrkFiltro.Value = 50;
            TrkFiltro.Scroll += trackBar1_Scroll;
            // 
            // DlgApri
            // 
            DlgApri.FileName = "openFileDialog1";
            // 
            // Sintetica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 354);
            Controls.Add(TrkFiltro);
            Controls.Add(BtnCreaSintetiche);
            Controls.Add(BtnAnteprima);
            Controls.Add(BtnScegliPercorso);
            Controls.Add(PctBox);
            Name = "Sintetica";
            Text = "Sintetica";
            ((System.ComponentModel.ISupportInitialize)PctBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkFiltro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox PctBox;
        private Button BtnScegliPercorso;
        private Button BtnAnteprima;
        private Button BtnCreaSintetiche;
        private TrackBar TrkFiltro;
        private OpenFileDialog DlgApri;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}