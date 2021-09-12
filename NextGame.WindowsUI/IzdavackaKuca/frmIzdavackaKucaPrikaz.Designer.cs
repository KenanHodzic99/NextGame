
namespace NextGame.WindowsUI.IzdavackaKuca
{
    partial class frmIzdavackaKucaPrikaz
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
            this.lblIzdavackaKuca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMjestoOsnivanja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvIzdavackaKuca = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdavackaKuca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIzdavackaKuca
            // 
            this.lblIzdavackaKuca.AutoSize = true;
            this.lblIzdavackaKuca.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIzdavackaKuca.Location = new System.Drawing.Point(12, 9);
            this.lblIzdavackaKuca.Name = "lblIzdavackaKuca";
            this.lblIzdavackaKuca.Size = new System.Drawing.Size(205, 32);
            this.lblIzdavackaKuca.TabIndex = 2;
            this.lblIzdavackaKuca.Text = "IZDAVAČKA KUĆA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPretrazi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMjestoOsnivanja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 525);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pretraga";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(594, 67);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(147, 23);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mjesto osnivanja:";
            // 
            // txtMjestoOsnivanja
            // 
            this.txtMjestoOsnivanja.Location = new System.Drawing.Point(315, 67);
            this.txtMjestoOsnivanja.Name = "txtMjestoOsnivanja";
            this.txtMjestoOsnivanja.Size = new System.Drawing.Size(232, 23);
            this.txtMjestoOsnivanja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(3, 67);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(232, 23);
            this.txtNaziv.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvIzdavackaKuca);
            this.panel2.Location = new System.Drawing.Point(12, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 429);
            this.panel2.TabIndex = 0;
            // 
            // dgvIzdavackaKuca
            // 
            this.dgvIzdavackaKuca.AllowUserToAddRows = false;
            this.dgvIzdavackaKuca.AllowUserToDeleteRows = false;
            this.dgvIzdavackaKuca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdavackaKuca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzdavackaKuca.Location = new System.Drawing.Point(0, 0);
            this.dgvIzdavackaKuca.Name = "dgvIzdavackaKuca";
            this.dgvIzdavackaKuca.ReadOnly = true;
            this.dgvIzdavackaKuca.RowTemplate.Height = 25;
            this.dgvIzdavackaKuca.Size = new System.Drawing.Size(744, 429);
            this.dgvIzdavackaKuca.TabIndex = 0;
            this.dgvIzdavackaKuca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIzdavackaKuca_CellDoubleClick);
            // 
            // frmIzdavackaKucaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIzdavackaKuca);
            this.Name = "frmIzdavackaKucaPrikaz";
            this.Text = "frmIzdavackaKucaPrikaz";
            this.Load += new System.EventHandler(this.frmIzdavackaKucaPrikaz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdavackaKuca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzdavackaKuca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIzdavackaKuca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMjestoOsnivanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}