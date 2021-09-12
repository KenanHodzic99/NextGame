using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NextGame.WindowsUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _api = new APIService("Korisnik");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                var result = await _api.GetAll<List<Models.Korisnik>>(null);
                this.Hide();
                frmPocetna frm = new frmPocetna();
                frm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Netačan username ili password!");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
