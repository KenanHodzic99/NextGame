
namespace NextGame.WindowsUI.Igrica
{
    partial class frmIgricaPrikaz
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvIgra = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIzdavackaKuca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblIzdavackaKuca = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgra)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvIgra);
            this.panel2.Location = new System.Drawing.Point(10, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 372);
            this.panel2.TabIndex = 4;
            // 
            // dgvIgra
            // 
            this.dgvIgra.AllowUserToAddRows = false;
            this.dgvIgra.AllowUserToDeleteRows = false;
            this.dgvIgra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIgra.Location = new System.Drawing.Point(0, 0);
            this.dgvIgra.Name = "dgvIgra";
            this.dgvIgra.ReadOnly = true;
            this.dgvIgra.RowTemplate.Height = 25;
            this.dgvIgra.Size = new System.Drawing.Size(638, 372);
            this.dgvIgra.TabIndex = 0;
            this.dgvIgra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIgra_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPretrazi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIzdavackaKuca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Location = new System.Drawing.Point(10, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 455);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pretraga";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(512, 58);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(126, 20);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izdavacka kuća:";
            // 
            // txtIzdavackaKuca
            // 
            this.txtIzdavackaKuca.Location = new System.Drawing.Point(270, 58);
            this.txtIzdavackaKuca.Name = "txtIzdavackaKuca";
            this.txtIzdavackaKuca.Size = new System.Drawing.Size(199, 20);
            this.txtIzdavackaKuca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(0, 58);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(199, 20);
            this.txtNaziv.TabIndex = 0;
            // 
            // lblIzdavackaKuca
            // 
            this.lblIzdavackaKuca.AutoSize = true;
            this.lblIzdavackaKuca.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F);
            this.lblIzdavackaKuca.Location = new System.Drawing.Point(10, 5);
            this.lblIzdavackaKuca.Name = "lblIzdavackaKuca";
            this.lblIzdavackaKuca.Size = new System.Drawing.Size(89, 32);
            this.lblIzdavackaKuca.TabIndex = 5;
            this.lblIzdavackaKuca.Text = "IGRICA";
            // 
            // frmIgricaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIzdavackaKuca);
            this.Name = "frmIgricaPrikaz";
            this.Text = "frmIgricaPrikaz";
            this.Load += new System.EventHandler(this.frmIgricaPrikaz_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIgra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIzdavackaKuca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblIzdavackaKuca;
    }
}