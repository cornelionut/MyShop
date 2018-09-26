namespace Test
{
    partial class frmAdaugaPartener
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
            this.tbAddNumePartener = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddPrenumePartener = new System.Windows.Forms.TextBox();
            this.tbAddCodPartener = new System.Windows.Forms.TextBox();
            this.tbAddTelefonPartener = new System.Windows.Forms.TextBox();
            this.tbAddMailPartener = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAddNumePartener
            // 
            this.tbAddNumePartener.Location = new System.Drawing.Point(112, 44);
            this.tbAddNumePartener.Name = "tbAddNumePartener";
            this.tbAddNumePartener.Size = new System.Drawing.Size(140, 20);
            this.tbAddNumePartener.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume partener";
            // 
            // tbAddPrenumePartener
            // 
            this.tbAddPrenumePartener.Location = new System.Drawing.Point(112, 84);
            this.tbAddPrenumePartener.Name = "tbAddPrenumePartener";
            this.tbAddPrenumePartener.Size = new System.Drawing.Size(140, 20);
            this.tbAddPrenumePartener.TabIndex = 2;
            // 
            // tbAddCodPartener
            // 
            this.tbAddCodPartener.Location = new System.Drawing.Point(112, 126);
            this.tbAddCodPartener.Name = "tbAddCodPartener";
            this.tbAddCodPartener.Size = new System.Drawing.Size(140, 20);
            this.tbAddCodPartener.TabIndex = 3;
            // 
            // tbAddTelefonPartener
            // 
            this.tbAddTelefonPartener.Location = new System.Drawing.Point(112, 169);
            this.tbAddTelefonPartener.Name = "tbAddTelefonPartener";
            this.tbAddTelefonPartener.Size = new System.Drawing.Size(140, 20);
            this.tbAddTelefonPartener.TabIndex = 4;
            // 
            // tbAddMailPartener
            // 
            this.tbAddMailPartener.Location = new System.Drawing.Point(112, 213);
            this.tbAddMailPartener.Name = "tbAddMailPartener";
            this.tbAddMailPartener.Size = new System.Drawing.Size(140, 20);
            this.tbAddMailPartener.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prenume partener";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cod partener";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon";
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.Location = new System.Drawing.Point(112, 265);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(91, 33);
            this.btnAddPartner.TabIndex = 10;
            this.btnAddPartner.Text = "Salveaza";
            this.btnAddPartner.UseVisualStyleBackColor = true;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // frmAdaugaPartener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 320);
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddMailPartener);
            this.Controls.Add(this.tbAddTelefonPartener);
            this.Controls.Add(this.tbAddCodPartener);
            this.Controls.Add(this.tbAddPrenumePartener);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddNumePartener);
            this.Name = "frmAdaugaPartener";
            this.Text = "Adauga partener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddNumePartener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddPrenumePartener;
        private System.Windows.Forms.TextBox tbAddCodPartener;
        private System.Windows.Forms.TextBox tbAddTelefonPartener;
        private System.Windows.Forms.TextBox tbAddMailPartener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddPartner;
    }
}