namespace BloccoNoteTest
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
            menuStrip1 = new MenuStrip();
            nuovoToolStripMenuItem = new ToolStripMenuItem();
            creaNuovoDocumenToolStripMenuItem = new ToolStripMenuItem();
            salvaToolStripMenuItem = new ToolStripMenuItem();
            cancellaDBToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuovoToolStripMenuItem, salvaToolStripMenuItem, cancellaDBToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuovoToolStripMenuItem
            // 
            nuovoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { creaNuovoDocumenToolStripMenuItem });
            nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            nuovoToolStripMenuItem.Size = new Size(53, 20);
            nuovoToolStripMenuItem.Text = "nuovo";
            nuovoToolStripMenuItem.Click += nuovoToolStripMenuItem_Click;
            // 
            // creaNuovoDocumenToolStripMenuItem
            // 
            creaNuovoDocumenToolStripMenuItem.Name = "creaNuovoDocumenToolStripMenuItem";
            creaNuovoDocumenToolStripMenuItem.Size = new Size(189, 22);
            creaNuovoDocumenToolStripMenuItem.Text = "Crea nuovo documen";
            // 
            // salvaToolStripMenuItem
            // 
            salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            salvaToolStripMenuItem.Size = new Size(45, 20);
            salvaToolStripMenuItem.Text = "salva";
            // 
            // cancellaDBToolStripMenuItem
            // 
            cancellaDBToolStripMenuItem.Name = "cancellaDBToolStripMenuItem";
            cancellaDBToolStripMenuItem.Size = new Size(80, 20);
            cancellaDBToolStripMenuItem.Text = "cancella DB";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(122, 20);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Blocco note";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuovoToolStripMenuItem;
        private ToolStripMenuItem creaNuovoDocumenToolStripMenuItem;
        private ToolStripMenuItem salvaToolStripMenuItem;
        private ToolStripMenuItem cancellaDBToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
