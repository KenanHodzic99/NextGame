using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NextGame.WindowsUI.Igrica;
using NextGame.WindowsUI.Properties;

namespace NextGame.WindowsUI.System_Requirements
{
    public partial class frmSysReqDodaj : Form
    {
        
        public frmSysReqDodaj()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmIgricaDodaj.SysReq = new Models.SystemRequirements()
            {
                OperativniSistem = txtOS.Text,
                GrafickaKartica = txtGPU.Text,
                Memorija = txtMemorija.Text,
                Procesor = txtCPU.Text,
                RAM = txtRAM.Text
            };

            
            this.Close();
        }

        private void frmSysReqDodaj_Load(object sender, EventArgs e)
        {
            txtOS.Text = frmIgricaDodaj.SysReq.OperativniSistem;
            txtGPU.Text = frmIgricaDodaj.SysReq.GrafickaKartica;
            txtMemorija.Text = frmIgricaDodaj.SysReq.Memorija;
            txtCPU.Text = frmIgricaDodaj.SysReq.Procesor;
            txtRAM.Text = frmIgricaDodaj.SysReq.RAM;
        }

        private void txtOS_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOS.Text))
                epOS.SetError(txtOS,Resources.ObavezanUnosPolja);
            else
                epOS.Clear();
        }

        private void txtCPU_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCPU.Text))
                epCPU.SetError(txtCPU, Resources.ObavezanUnosPolja);
            else
                epCPU.Clear();
        }

        private void txtRAM_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRAM.Text))
                epRAM.SetError(txtRAM, Resources.ObavezanUnosPolja);
            else
                epRAM.Clear();
        }

        private void txtGPU_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGPU.Text))
                epGPU.SetError(txtGPU, Resources.ObavezanUnosPolja);
            else
                epGPU.Clear();
        }

        private void txtMemorija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemorija.Text))
                epMemorija.SetError(txtMemorija, Resources.ObavezanUnosPolja);
            else
                epMemorija.Clear();
        }
    }
}
