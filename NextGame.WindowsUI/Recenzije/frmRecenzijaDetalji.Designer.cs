
namespace NextGame.WindowsUI.Recenzije
{
    partial class frmRecenzijaDetalji
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIgrica = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIzdavackaKuca
            // 
            this.lblIzdavackaKuca.AutoSize = true;
            this.lblIzdavackaKuca.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F);
            this.lblIzdavackaKuca.Location = new System.Drawing.Point(12, 11);
            this.lblIzdavackaKuca.Name = "lblIzdavackaKuca";
            this.lblIzdavackaKuca.Size = new System.Drawing.Size(98, 32);
            this.lblIzdavackaKuca.TabIndex = 5;
            this.lblIzdavackaKuca.Text = "OBJAVA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOcjena);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIgrica);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 469);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ocjena:";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(447, 24);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(177, 20);
            this.txtOcjena.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 20);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Izbriši";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sadrzaj:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(5, 98);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(619, 317);
            this.txtOpis.TabIndex = 16;
            this.txtOpis.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(229, 24);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(177, 20);
            this.txtAutor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Igrica:";
            // 
            // txtIgrica
            // 
            this.txtIgrica.Location = new System.Drawing.Point(6, 26);
            this.txtIgrica.Name = "txtIgrica";
            this.txtIgrica.Size = new System.Drawing.Size(177, 20);
            this.txtIgrica.TabIndex = 2;
            // 
            // frmRecenzijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 522);
            this.Controls.Add(this.lblIzdavackaKuca);
            this.Controls.Add(this.panel1);
            this.Name = "frmRecenzijaDetalji";
            this.Text = "frmRecenzijaDetalji";
            this.Load += new System.EventHandler(this.frmRecenzijaDetalji_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzdavackaKuca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIgrica;
    }
}