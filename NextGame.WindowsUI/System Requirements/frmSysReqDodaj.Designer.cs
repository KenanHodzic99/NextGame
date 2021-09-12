
namespace NextGame.WindowsUI.System_Requirements
{
    partial class frmSysReqDodaj
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGPU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemorija = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.epOS = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCPU = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRAM = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGPU = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMemorija = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMemorija)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operativni sistem:";
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(13, 32);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(256, 23);
            this.txtOS.TabIndex = 2;
            this.txtOS.Validating += new System.ComponentModel.CancelEventHandler(this.txtOS_Validating);
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(13, 85);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(256, 23);
            this.txtCPU.TabIndex = 4;
            this.txtCPU.Validating += new System.ComponentModel.CancelEventHandler(this.txtCPU_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Procesor:";
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(12, 138);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(256, 23);
            this.txtRAM.TabIndex = 6;
            this.txtRAM.Validating += new System.ComponentModel.CancelEventHandler(this.txtRAM_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "RAM:";
            // 
            // txtGPU
            // 
            this.txtGPU.Location = new System.Drawing.Point(12, 189);
            this.txtGPU.Name = "txtGPU";
            this.txtGPU.Size = new System.Drawing.Size(256, 23);
            this.txtGPU.TabIndex = 8;
            this.txtGPU.Validating += new System.ComponentModel.CancelEventHandler(this.txtGPU_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grafička kartica:";
            // 
            // txtMemorija
            // 
            this.txtMemorija.Location = new System.Drawing.Point(12, 238);
            this.txtMemorija.Name = "txtMemorija";
            this.txtMemorija.Size = new System.Drawing.Size(256, 23);
            this.txtMemorija.TabIndex = 10;
            this.txtMemorija.Validating += new System.ComponentModel.CancelEventHandler(this.txtMemorija_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Memorija";
            // 
            // epOS
            // 
            this.epOS.ContainerControl = this;
            // 
            // epCPU
            // 
            this.epCPU.ContainerControl = this;
            // 
            // epRAM
            // 
            this.epRAM.ContainerControl = this;
            // 
            // epGPU
            // 
            this.epGPU.ContainerControl = this;
            // 
            // epMemorija
            // 
            this.epMemorija.ContainerControl = this;
            // 
            // frmSysReqDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 338);
            this.Controls.Add(this.txtMemorija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGPU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmSysReqDodaj";
            this.Text = "Hardverski i softverski zahtjevi";
            this.Load += new System.EventHandler(this.frmSysReqDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMemorija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemorija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider epOS;
        private System.Windows.Forms.ErrorProvider epCPU;
        private System.Windows.Forms.ErrorProvider epRAM;
        private System.Windows.Forms.ErrorProvider epGPU;
        private System.Windows.Forms.ErrorProvider epMemorija;
    }
}