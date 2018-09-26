namespace Test
{
    partial class frmClienti
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
            this.cmbFilterPartnerName = new System.Windows.Forms.ComboBox();
            this.tbFilterPartnerCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCautaPartener = new System.Windows.Forms.Button();
            this.dgClienti = new ADGV.AdvancedDataGridView();
            this.lblTotalRanduri = new System.Windows.Forms.Label();
            this.btnAdaugaPartener = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilterPartnerName
            // 
            this.cmbFilterPartnerName.DisplayMember = "PartnerId";
            this.cmbFilterPartnerName.FormattingEnabled = true;
            this.cmbFilterPartnerName.Location = new System.Drawing.Point(467, 16);
            this.cmbFilterPartnerName.Name = "cmbFilterPartnerName";
            this.cmbFilterPartnerName.Size = new System.Drawing.Size(121, 21);
            this.cmbFilterPartnerName.TabIndex = 1;
            this.cmbFilterPartnerName.ValueMember = "PartnerId";
            // 
            // tbFilterPartnerCode
            // 
            this.tbFilterPartnerCode.Location = new System.Drawing.Point(720, 19);
            this.tbFilterPartnerCode.Name = "tbFilterPartnerCode";
            this.tbFilterPartnerCode.Size = new System.Drawing.Size(100, 20);
            this.tbFilterPartnerCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume Partener";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod Partener";
            // 
            // btnCautaPartener
            // 
            this.btnCautaPartener.Location = new System.Drawing.Point(33, 13);
            this.btnCautaPartener.Name = "btnCautaPartener";
            this.btnCautaPartener.Size = new System.Drawing.Size(75, 23);
            this.btnCautaPartener.TabIndex = 5;
            this.btnCautaPartener.Text = "Cauta";
            this.btnCautaPartener.UseVisualStyleBackColor = true;
            this.btnCautaPartener.Click += new System.EventHandler(this.btnCautaPartener_Click);
            // 
            // dgClienti
            // 
            this.dgClienti.AllowUserToAddRows = false;
            this.dgClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClienti.AutoGenerateContextFilters = true;
            this.dgClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClienti.DateWithTime = false;
            this.dgClienti.Location = new System.Drawing.Point(13, 49);
            this.dgClienti.Name = "dgClienti";
            this.dgClienti.Size = new System.Drawing.Size(853, 290);
            this.dgClienti.TabIndex = 6;
            this.dgClienti.TimeFilter = false;
            // 
            // lblTotalRanduri
            // 
            this.lblTotalRanduri.AutoSize = true;
            this.lblTotalRanduri.Location = new System.Drawing.Point(777, 379);
            this.lblTotalRanduri.Name = "lblTotalRanduri";
            this.lblTotalRanduri.Size = new System.Drawing.Size(78, 13);
            this.lblTotalRanduri.TabIndex = 7;
            this.lblTotalRanduri.Text = "Total randuri: 0";
            // 
            // btnAdaugaPartener
            // 
            this.btnAdaugaPartener.Location = new System.Drawing.Point(128, 13);
            this.btnAdaugaPartener.Name = "btnAdaugaPartener";
            this.btnAdaugaPartener.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaPartener.TabIndex = 8;
            this.btnAdaugaPartener.Text = "Adauga";
            this.btnAdaugaPartener.UseVisualStyleBackColor = true;
            this.btnAdaugaPartener.Click += new System.EventHandler(this.btnAdaugaPartener_Click);
            // 
            // frmClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 414);
            this.Controls.Add(this.btnAdaugaPartener);
            this.Controls.Add(this.lblTotalRanduri);
            this.Controls.Add(this.dgClienti);
            this.Controls.Add(this.btnCautaPartener);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilterPartnerCode);
            this.Controls.Add(this.cmbFilterPartnerName);
            this.Name = "frmClienti";
            this.Text = "Clienti";
            ((System.ComponentModel.ISupportInitialize)(this.dgClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFilterPartnerName;
        private System.Windows.Forms.TextBox tbFilterPartnerCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCautaPartener;
        private ADGV.AdvancedDataGridView dgClienti;
        private System.Windows.Forms.Label lblTotalRanduri;
        private System.Windows.Forms.Button btnAdaugaPartener;
    }
}