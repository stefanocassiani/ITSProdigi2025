namespace CRM3
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
            TxtNome = new TextBox();
            TxtCognome = new TextBox();
            TxtEmail = new TextBox();
            LstBox = new ListBox();
            button2 = new Button();
            BtnAdd = new Button();
            BtnSalva = new Button();
            BtnElimina = new Button();
            BtnCarica = new Button();
            BtnModifica = new Button();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNome.Location = new Point(269, 12);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(322, 23);
            TxtNome.TabIndex = 0;
            // 
            // TxtCognome
            // 
            TxtCognome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtCognome.Location = new Point(269, 41);
            TxtCognome.Name = "TxtCognome";
            TxtCognome.Size = new Size(322, 23);
            TxtCognome.TabIndex = 1;
            // 
            // TxtEmail
            // 
            TxtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtEmail.Location = new Point(269, 70);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(322, 23);
            TxtEmail.TabIndex = 2;
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(3, 12);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(150, 214);
            LstBox.TabIndex = 3;
            LstBox.SelectedIndexChanged += LstBox_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(502, 431);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(339, 258);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnSalva
            // 
            BtnSalva.Location = new Point(420, 258);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(75, 23);
            BtnSalva.TabIndex = 7;
            BtnSalva.Text = "salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // BtnElimina
            // 
            BtnElimina.Location = new Point(12, 193);
            BtnElimina.Name = "BtnElimina";
            BtnElimina.Size = new Size(75, 23);
            BtnElimina.TabIndex = 8;
            BtnElimina.Text = "elimina";
            BtnElimina.UseVisualStyleBackColor = true;
            BtnElimina.Click += BtnElimina_Click;
            // 
            // BtnCarica
            // 
            BtnCarica.Location = new Point(269, 99);
            BtnCarica.Name = "BtnCarica";
            BtnCarica.Size = new Size(94, 23);
            BtnCarica.TabIndex = 9;
            BtnCarica.Text = "carica contatti";
            BtnCarica.UseVisualStyleBackColor = true;
            BtnCarica.Click += BtnCarica_Click;
            // 
            // BtnModifica
            // 
            BtnModifica.Location = new Point(473, 99);
            BtnModifica.Name = "BtnModifica";
            BtnModifica.Size = new Size(118, 23);
            BtnModifica.TabIndex = 10;
            BtnModifica.Text = "modifica contatto";
            BtnModifica.UseVisualStyleBackColor = true;
            BtnModifica.Click += BtnModifica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 293);
            Controls.Add(BtnModifica);
            Controls.Add(BtnCarica);
            Controls.Add(BtnElimina);
            Controls.Add(BtnSalva);
            Controls.Add(BtnAdd);
            Controls.Add(button2);
            Controls.Add(LstBox);
            Controls.Add(TxtEmail);
            Controls.Add(TxtCognome);
            Controls.Add(TxtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNome;
        private TextBox TxtCognome;
        private TextBox TxtEmail;
        private ListBox LstBox;
        private Button button2;
        private Button BtnAdd;
        private Button BtnSalva;
        private Button BtnElimina;
        private Button BtnCarica;
        private Button BtnModifica;
    }
}
