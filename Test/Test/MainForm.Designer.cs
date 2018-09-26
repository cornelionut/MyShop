namespace Test
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnArticole = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnArticole);
            this.panel1.Controls.Add(this.btnComenzi);
            this.panel1.Controls.Add(this.btnClienti);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 215);
            this.panel1.TabIndex = 0;
            // 
            // btnArticole
            // 
            this.btnArticole.Location = new System.Drawing.Point(255, 19);
            this.btnArticole.Name = "btnArticole";
            this.btnArticole.Size = new System.Drawing.Size(93, 59);
            this.btnArticole.TabIndex = 2;
            this.btnArticole.Text = "ARTICOLE";
            this.btnArticole.UseVisualStyleBackColor = true;
            // 
            // btnComenzi
            // 
            this.btnComenzi.Location = new System.Drawing.Point(147, 19);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(75, 59);
            this.btnComenzi.TabIndex = 1;
            this.btnComenzi.Text = "COMENZI";
            this.btnComenzi.UseVisualStyleBackColor = true;
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(41, 19);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(75, 59);
            this.btnClienti.TabIndex = 0;
            this.btnClienti.Text = "CLIENTI";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Meniu";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnArticole;
        private System.Windows.Forms.Button btnComenzi;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}