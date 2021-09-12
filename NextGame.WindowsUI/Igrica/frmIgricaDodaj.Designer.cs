
namespace NextGame.WindowsUI.Igrica
{
    partial class frmIgricaDodaj
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
            this.lblIzdavackaKuca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIzdavackaKuca = new System.Windows.Forms.ComboBox();
            this.nudCijena = new System.Windows.Forms.NumericUpDown();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.btnSysReq = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.pbIgra = new System.Windows.Forms.PictureBox();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.epNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTip = new System.Windows.Forms.ErrorProvider(this.components);
            this.epZanr = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIzdavackaKuca = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCijena = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSlika = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOpis = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epZanr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIzdavackaKuca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIzdavackaKuca
            // 
            this.lblIzdavackaKuca.AutoSize = true;
            this.lblIzdavackaKuca.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F);
            this.lblIzdavackaKuca.Location = new System.Drawing.Point(10, 7);
            this.lblIzdavackaKuca.Name = "lblIzdavackaKuca";
            this.lblIzdavackaKuca.Size = new System.Drawing.Size(89, 32);
            this.lblIzdavackaKuca.TabIndex = 3;
            this.lblIzdavackaKuca.Text = "IGRICA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbIzdavackaKuca);
            this.panel1.Controls.Add(this.nudCijena);
            this.panel1.Controls.Add(this.txtZanr);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpDatumIzdavanja);
            this.panel1.Controls.Add(this.btnSysReq);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTip);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.btnSlika);
            this.panel1.Controls.Add(this.pbIgra);
            this.panel1.Location = new System.Drawing.Point(10, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 466);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "IzdavackaKuca:";
            // 
            // cbIzdavackaKuca
            // 
            this.cbIzdavackaKuca.FormattingEnabled = true;
            this.cbIzdavackaKuca.Location = new System.Drawing.Point(216, 131);
            this.cbIzdavackaKuca.Name = "cbIzdavackaKuca";
            this.cbIzdavackaKuca.Size = new System.Drawing.Size(177, 21);
            this.cbIzdavackaKuca.TabIndex = 27;
            // 
            // nudCijena
            // 
            this.nudCijena.Location = new System.Drawing.Point(433, 132);
            this.nudCijena.Name = "nudCijena";
            this.nudCijena.Size = new System.Drawing.Size(177, 20);
            this.nudCijena.TabIndex = 26;
            this.nudCijena.Validating += new System.ComponentModel.CancelEventHandler(this.nudCijena_Validating);
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(433, 74);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(177, 20);
            this.txtZanr.TabIndex = 24;
            this.txtZanr.Validating += new System.ComponentModel.CancelEventHandler(this.txtZanr_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Zanrovi:";
            // 
            // dtpDatumIzdavanja
            // 
            this.dtpDatumIzdavanja.Location = new System.Drawing.Point(216, 74);
            this.dtpDatumIzdavanja.Name = "dtpDatumIzdavanja";
            this.dtpDatumIzdavanja.Size = new System.Drawing.Size(177, 20);
            this.dtpDatumIzdavanja.TabIndex = 22;
            this.dtpDatumIzdavanja.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumIzdavanja_Validating);
            // 
            // btnSysReq
            // 
            this.btnSysReq.Location = new System.Drawing.Point(433, 165);
            this.btnSysReq.Name = "btnSysReq";
            this.btnSysReq.Size = new System.Drawing.Size(177, 20);
            this.btnSysReq.TabIndex = 21;
            this.btnSysReq.Text = "Dodaj hardverske zahtjeve";
            this.btnSysReq.UseVisualStyleBackColor = true;
            this.btnSysReq.Click += new System.EventHandler(this.btnSysReq_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 20);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(5, 234);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(619, 181);
            this.txtOpis.TabIndex = 16;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cijena:";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(433, 25);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(177, 20);
            this.txtTip.TabIndex = 10;
            this.txtTip.Validating += new System.ComponentModel.CancelEventHandler(this.txtTip_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tip igre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum Izdavanja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(216, 25);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(177, 20);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(3, 184);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(183, 20);
            this.btnSlika.TabIndex = 1;
            this.btnSlika.Text = "Učitaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // pbIgra
            // 
            this.pbIgra.Location = new System.Drawing.Point(3, 3);
            this.pbIgra.Name = "pbIgra";
            this.pbIgra.Size = new System.Drawing.Size(183, 174);
            this.pbIgra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIgra.TabIndex = 0;
            this.pbIgra.TabStop = false;
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // epNaziv
            // 
            this.epNaziv.ContainerControl = this;
            // 
            // epTip
            // 
            this.epTip.ContainerControl = this;
            // 
            // epZanr
            // 
            this.epZanr.ContainerControl = this;
            // 
            // epIzdavackaKuca
            // 
            this.epIzdavackaKuca.ContainerControl = this;
            // 
            // epCijena
            // 
            this.epCijena.ContainerControl = this;
            // 
            // epSlika
            // 
            this.epSlika.ContainerControl = this;
            // 
            // epOpis
            // 
            this.epOpis.ContainerControl = this;
            // 
            // frmIgricaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 504);
            this.Controls.Add(this.lblIzdavackaKuca);
            this.Controls.Add(this.panel1);
            this.Name = "frmIgricaDodaj";
            this.Text = "frmIgricaDodaj";
            this.Load += new System.EventHandler(this.frmIgricaDodaj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epZanr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIzdavackaKuca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOpis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzdavackaKuca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.PictureBox pbIgra;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanja;
        private System.Windows.Forms.Button btnSysReq;
        private System.Windows.Forms.NumericUpDown nudCijena;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIzdavackaKuca;
        private System.Windows.Forms.ErrorProvider epNaziv;
        private System.Windows.Forms.ErrorProvider epTip;
        private System.Windows.Forms.ErrorProvider epZanr;
        private System.Windows.Forms.ErrorProvider epIzdavackaKuca;
        private System.Windows.Forms.ErrorProvider epCijena;
        private System.Windows.Forms.ErrorProvider epSlika;
        private System.Windows.Forms.ErrorProvider epOpis;
    }
}