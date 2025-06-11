namespace ComputerVision1
{
    partial class BloccoNote
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
            BtnNuovo = new Button();
            BtnApri = new Button();
            BtnSalva = new Button();
            DlgApri = new OpenFileDialog();
            TxtRisultato = new TextBox();
            SuspendLayout();
            // 
            // BtnNuovo
            // 
            BtnNuovo.Location = new Point(4, 2);
            BtnNuovo.Name = "BtnNuovo";
            BtnNuovo.Size = new Size(75, 23);
            BtnNuovo.TabIndex = 0;
            BtnNuovo.Text = "Nuovo";
            BtnNuovo.UseVisualStyleBackColor = true;
            BtnNuovo.Click += Nuovo_Click;
            // 
            // BtnApri
            // 
            BtnApri.Location = new Point(85, 2);
            BtnApri.Name = "BtnApri";
            BtnApri.Size = new Size(75, 23);
            BtnApri.TabIndex = 1;
            BtnApri.Text = "Apri";
            BtnApri.UseVisualStyleBackColor = true;
            BtnApri.Click += BtnApri_Click;
            // 
            // BtnSalva
            // 
            BtnSalva.Location = new Point(166, 2);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 2;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // DlgApri
            // 
            DlgApri.FileName = "openFileDialog1";
            DlgApri.FileOk += DlgApri_FileOk;
            // 
            // TxtRisultato
            // 
            TxtRisultato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtRisultato.Location = new Point(4, 31);
            TxtRisultato.Multiline = true;
            TxtRisultato.Name = "TxtRisultato";
            TxtRisultato.ScrollBars = ScrollBars.Vertical;
            TxtRisultato.Size = new Size(797, 422);
            TxtRisultato.TabIndex = 3;
            // 
            // BloccoNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtRisultato);
            Controls.Add(BtnSalva);
            Controls.Add(BtnApri);
            Controls.Add(BtnNuovo);
            Name = "BloccoNote";
            Text = "BloccoNote";
            FormClosing += BloccoNote_FormClosing;
            Load += BloccoNote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNuovo;
        private Button BtnApri;
        private Button BtnSalva;
        private OpenFileDialog DlgApri;
        private TextBox TxtRisultato;
    }
}