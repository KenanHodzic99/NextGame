
namespace NextGame.WindowsUI.Objava
{
    partial class frmObjavaDodaj
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
            this.cbIgrica = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.epNaslov = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAutor = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSadrzaj = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNaslov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSadrzaj)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIzdavackaKuca
            // 
            this.lblIzdavackaKuca.AutoSize = true;
            this.lblIzdavackaKuca.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIzdavackaKuca.Location = new System.Drawing.Point(12, 9);
            this.lblIzdavackaKuca.Name = "lblIzdavackaKuca";
            this.lblIzdavackaKuca.Size = new System.Drawing.Size(97, 32);
            this.lblIzdavackaKuca.TabIndex = 3;
            this.lblIzdavackaKuca.Text = "OBJAVA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbIgrica);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNaslov);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 540);
            this.panel1.TabIndex = 2;
            // 
            // cbIgrica
            // 
            this.cbIgrica.FormattingEnabled = true;
            this.cbIgrica.Location = new System.Drawing.Point(534, 29);
            this.cbIgrica.Name = "cbIgrica";
            this.cbIgrica.Size = new System.Drawing.Size(200, 23);
            this.cbIgrica.TabIndex = 20;
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
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sadrzaj:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(6, 113);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(722, 365);
            this.txtOpis.TabIndex = 16;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(267, 28);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(206, 23);
            this.txtAutor.TabIndex = 10;
            this.txtAutor.Validating += new System.ComponentModel.CancelEventHandler(this.txtAutor_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Igrica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(6, 29);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(206, 23);
            this.txtNaslov.TabIndex = 2;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // epNaslov
            // 
            this.epNaslov.ContainerControl = this;
            // 
            // epAutor
            // 
            this.epAutor.ContainerControl = this;
            // 
            // epSadrzaj
            // 
            this.epSadrzaj.ContainerControl = this;
            // 
            // frmObjavaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 596);
            this.Controls.Add(this.lblIzdavackaKuca);
            this.Controls.Add(this.panel1);
            this.Name = "frmObjavaDodaj";
            this.Text = "frmObjavaDodaj";
            this.Load += new System.EventHandler(this.frmObjavaDodaj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNaslov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSadrzaj)).EndInit();
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
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.ComboBox cbIgrica;
        private System.Windows.Forms.ErrorProvider epNaslov;
        private System.Windows.Forms.ErrorProvider epAutor;
        private System.Windows.Forms.ErrorProvider epSadrzaj;
    }
}