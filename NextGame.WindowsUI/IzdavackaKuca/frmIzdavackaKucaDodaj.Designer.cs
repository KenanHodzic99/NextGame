
namespace NextGame.WindowsUI.IzdavackaKuca
{
    partial class frmIzdavackaKucaDodaj
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.dtpOsnivanja = new System.Windows.Forms.DateTimePicker();
            this.nudBrojZaposlenika = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSjediste = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOsnivaci = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMjestoOsnivanja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.pbIzdavackaKuca = new System.Windows.Forms.PictureBox();
            this.lblIzdavackaKuca = new System.Windows.Forms.Label();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.epNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBrojZaposlenika = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOsnivaci = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMjestoOsnivanja = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSjediste = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOpis = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzdavackaKuca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojZaposlenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOsnivaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMjestoOsnivanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSjediste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.dtpOsnivanja);
            this.panel1.Controls.Add(this.nudBrojZaposlenika);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSjediste);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOsnivaci);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMjestoOsnivanja);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.btnSlika);
            this.panel1.Controls.Add(this.pbIzdavackaKuca);
            this.panel1.Location = new System.Drawing.Point(13, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 526);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(607, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(6, 270);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(722, 208);
            this.txtOpis.TabIndex = 16;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // dtpOsnivanja
            // 
            this.dtpOsnivanja.Location = new System.Drawing.Point(252, 100);
            this.dtpOsnivanja.Name = "dtpOsnivanja";
            this.dtpOsnivanja.Size = new System.Drawing.Size(200, 23);
            this.dtpOsnivanja.TabIndex = 15;
            // 
            // nudBrojZaposlenika
            // 
            this.nudBrojZaposlenika.Location = new System.Drawing.Point(505, 30);
            this.nudBrojZaposlenika.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBrojZaposlenika.Name = "nudBrojZaposlenika";
            this.nudBrojZaposlenika.Size = new System.Drawing.Size(206, 23);
            this.nudBrojZaposlenika.TabIndex = 14;
            this.nudBrojZaposlenika.Validating += new System.ComponentModel.CancelEventHandler(this.nudBrojZaposlenika_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sjedište:";
            // 
            // txtSjediste
            // 
            this.txtSjediste.Location = new System.Drawing.Point(505, 182);
            this.txtSjediste.Name = "txtSjediste";
            this.txtSjediste.Size = new System.Drawing.Size(206, 23);
            this.txtSjediste.TabIndex = 12;
            this.txtSjediste.Validating += new System.ComponentModel.CancelEventHandler(this.txtSjediste_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Osnivači:";
            // 
            // txtOsnivaci
            // 
            this.txtOsnivaci.Location = new System.Drawing.Point(505, 100);
            this.txtOsnivaci.Name = "txtOsnivaci";
            this.txtOsnivaci.Size = new System.Drawing.Size(206, 23);
            this.txtOsnivaci.TabIndex = 10;
            this.txtOsnivaci.Validating += new System.ComponentModel.CancelEventHandler(this.txtOsnivaci_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Broj zaposlenika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mjesto osnivanja:";
            // 
            // txtMjestoOsnivanja
            // 
            this.txtMjestoOsnivanja.Location = new System.Drawing.Point(252, 182);
            this.txtMjestoOsnivanja.Name = "txtMjestoOsnivanja";
            this.txtMjestoOsnivanja.Size = new System.Drawing.Size(206, 23);
            this.txtMjestoOsnivanja.TabIndex = 6;
            this.txtMjestoOsnivanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtMjestoOsnivanja_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum osnivanja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(252, 29);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(206, 23);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(4, 212);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(213, 23);
            this.btnSlika.TabIndex = 1;
            this.btnSlika.Text = "Učitaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // pbIzdavackaKuca
            // 
            this.pbIzdavackaKuca.Location = new System.Drawing.Point(4, 4);
            this.pbIzdavackaKuca.Name = "pbIzdavackaKuca";
            this.pbIzdavackaKuca.Size = new System.Drawing.Size(213, 201);
            this.pbIzdavackaKuca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIzdavackaKuca.TabIndex = 0;
            this.pbIzdavackaKuca.TabStop = false;
            // 
            // lblIzdavackaKuca
            // 
            this.lblIzdavackaKuca.AutoSize = true;
            this.lblIzdavackaKuca.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIzdavackaKuca.Location = new System.Drawing.Point(13, 9);
            this.lblIzdavackaKuca.Name = "lblIzdavackaKuca";
            this.lblIzdavackaKuca.Size = new System.Drawing.Size(205, 32);
            this.lblIzdavackaKuca.TabIndex = 1;
            this.lblIzdavackaKuca.Text = "IZDAVAČKA KUĆA";
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // epNaziv
            // 
            this.epNaziv.ContainerControl = this;
            // 
            // epBrojZaposlenika
            // 
            this.epBrojZaposlenika.ContainerControl = this;
            // 
            // epOsnivaci
            // 
            this.epOsnivaci.ContainerControl = this;
            // 
            // epMjestoOsnivanja
            // 
            this.epMjestoOsnivanja.ContainerControl = this;
            // 
            // epSjediste
            // 
            this.epSjediste.ContainerControl = this;
            // 
            // epOpis
            // 
            this.epOpis.ContainerControl = this;
            // 
            // frmIzdavackaKucaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 582);
            this.Controls.Add(this.lblIzdavackaKuca);
            this.Controls.Add(this.panel1);
            this.Name = "frmIzdavackaKucaDodaj";
            this.Text = "frmIzdavackaKucaDodaj";
            this.Load += new System.EventHandler(this.frmIzdavackaKucaDodaj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzdavackaKuca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojZaposlenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOsnivaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMjestoOsnivanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSjediste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.PictureBox pbIzdavackaKuca;
        private System.Windows.Forms.Label lblIzdavackaKuca;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dtpOsnivanja;
        private System.Windows.Forms.NumericUpDown nudBrojZaposlenika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSjediste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOsnivaci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMjestoOsnivanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.ErrorProvider epNaziv;
        private System.Windows.Forms.ErrorProvider epBrojZaposlenika;
        private System.Windows.Forms.ErrorProvider epOsnivaci;
        private System.Windows.Forms.ErrorProvider epMjestoOsnivanja;
        private System.Windows.Forms.ErrorProvider epSjediste;
        private System.Windows.Forms.ErrorProvider epOpis;
    }
}