namespace CRM
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
            LstContatti = new ListBox();
            BtnAggiungi = new Button();
            BtnSalva = new Button();
            BtnElimina = new Button();
            TxtNome = new TextBox();
            TxtCognome = new TextBox();
            TxtEmail = new TextBox();
            SuspendLayout();
            // 
            // LstContatti
            // 
            LstContatti.FormattingEnabled = true;
            LstContatti.ItemHeight = 15;
            LstContatti.Location = new Point(12, 12);
            LstContatti.Name = "LstContatti";
            LstContatti.Size = new Size(156, 409);
            LstContatti.TabIndex = 0;
            LstContatti.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BtnAggiungi
            // 
            BtnAggiungi.Location = new Point(551, 403);
            BtnAggiungi.Name = "BtnAggiungi";
            BtnAggiungi.Size = new Size(75, 23);
            BtnAggiungi.TabIndex = 1;
            BtnAggiungi.Text = "aggiungi";
            BtnAggiungi.UseVisualStyleBackColor = true;
            BtnAggiungi.Click += BtnAggiungi_Click;
            // 
            // BtnSalva
            // 
            BtnSalva.Location = new Point(632, 403);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 2;
            BtnSalva.Text = "salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // BtnElimina
            // 
            BtnElimina.Location = new Point(28, 356);
            BtnElimina.Name = "BtnElimina";
            BtnElimina.Size = new Size(75, 23);
            BtnElimina.TabIndex = 3;
            BtnElimina.Text = "elimina";
            BtnElimina.UseVisualStyleBackColor = true;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(196, 12);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(267, 23);
            TxtNome.TabIndex = 4;
            TxtNome.Text = "Nome";
            // 
            // TxtCognome
            // 
            TxtCognome.Location = new Point(196, 41);
            TxtCognome.Name = "TxtCognome";
            TxtCognome.Size = new Size(267, 23);
            TxtCognome.TabIndex = 5;
            TxtCognome.Text = "Cognome";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(196, 70);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(267, 23);
            TxtEmail.TabIndex = 6;
            TxtEmail.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtEmail);
            Controls.Add(TxtCognome);
            Controls.Add(TxtNome);
            Controls.Add(BtnElimina);
            Controls.Add(BtnSalva);
            Controls.Add(BtnAggiungi);
            Controls.Add(LstContatti);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstContatti;
        private Button BtnAggiungi;
        private Button BtnSalva;
        private Button BtnElimina;
        private TextBox TxtNome;
        private TextBox TxtCognome;
        private TextBox TxtEmail;
    }
}
