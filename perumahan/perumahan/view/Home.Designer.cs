namespace perumahan.view
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            daftarRumahToolStripMenuItem = new ToolStripMenuItem();
            favoritToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, listToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(745, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 20);
            fileToolStripMenuItem.Text = "Menu";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daftarRumahToolStripMenuItem, favoritToolStripMenuItem });
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(37, 20);
            listToolStripMenuItem.Text = "List";
            // 
            // daftarRumahToolStripMenuItem
            // 
            daftarRumahToolStripMenuItem.Name = "daftarRumahToolStripMenuItem";
            daftarRumahToolStripMenuItem.Size = new Size(180, 22);
            daftarRumahToolStripMenuItem.Text = "Daftar Rumah";
            // 
            // favoritToolStripMenuItem
            // 
            favoritToolStripMenuItem.Name = "favoritToolStripMenuItem";
            favoritToolStripMenuItem.Size = new Size(180, 22);
            favoritToolStripMenuItem.Text = "Favorit";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 405);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem daftarRumahToolStripMenuItem;
        private ToolStripMenuItem favoritToolStripMenuItem;
    }
}