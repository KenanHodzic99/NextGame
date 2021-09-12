using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGame.WindowsUI
{
    public partial class frmPocetna : Form
    {
        private Form _activeFrom = null;
        public frmPocetna(Form childForm = null)
        {
            InitializeComponent();
            customizeDesign();
            openChildForm(childForm);
        }
        
        private void customizeDesign()
        {
            panelSubmenuIgrica.Visible = false;
            panelSubmenuIzdavackaKuca.Visible = false;
            panelSubMenuKorisnik.Visible = false;
            panelSubMenuObjava.Visible = false;
            panelSubMenuRecenzija.Visible = false;
            panelSubmenuIzvjestaj.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelSubmenuIgrica.Visible == true)
            {
                panelSubmenuIgrica.Visible = false;
            }
            if (panelSubmenuIzdavackaKuca.Visible == true)
            {
                panelSubmenuIzdavackaKuca.Visible = false;
            }
            if (panelSubMenuKorisnik.Visible == true)
            {
                panelSubMenuKorisnik.Visible = false;
            }
            if (panelSubMenuObjava.Visible == true)
            {
                panelSubMenuObjava.Visible = false;
            }
            if (panelSubMenuRecenzija.Visible == true)
            {
                panelSubMenuRecenzija.Visible = false;
            }

            if (panelSubmenuIzvjestaj.Visible == true)
            {
                panelSubmenuIzvjestaj.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void openChildForm(Form childForm = null)
        {
            if (childForm != null)
            {
                if (_activeFrom != null)
                {
                    _activeFrom.Close();
                }
                _activeFrom = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIzdavackaKuca_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuIzdavackaKuca);
        }

        private void btnIgrica_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuIgrica);
        }

        private void btnObjava_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuObjava);
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuKorisnik);
        }

        private void btnRecenzija_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRecenzija);
        }

        private void btnIzdavackaKucaPrikaz_Click(object sender, EventArgs e)
        {
            openChildForm(new IzdavackaKuca.frmIzdavackaKucaPrikaz());
            hideSubMenu();
        }

        private void btnIzdavackaKucaDodaj_Click(object sender, EventArgs e)
        {
            openChildForm(new IzdavackaKuca.frmIzdavackaKucaDodaj());
            hideSubMenu();
        }

        private void btnIgricaPrikaz_Click(object sender, EventArgs e)
        {
            openChildForm(new Igrica.frmIgricaPrikaz());
            hideSubMenu();
        }

        private void btnIgricaDodaj_Click(object sender, EventArgs e)
        {
            openChildForm(new Igrica.frmIgricaDodaj());
            hideSubMenu();
        }

        private void btnObjavaPrikaz_Click(object sender, EventArgs e)
        {
            openChildForm(new Objava.frmObjavaPrikaz());
            hideSubMenu();
        }

        private void btnObjavaDodaj_Click(object sender, EventArgs e)
        {
            openChildForm(new Objava.frmObjavaDodaj());
            hideSubMenu();
        }

        private void btnKorisnikPrikaz_Click(object sender, EventArgs e)
        {
            openChildForm(new Korisnik.frmKorisnikPrikaz());
            hideSubMenu();
        }

        private void btnKorisnikDodaj_Click(object sender, EventArgs e)
        {
            openChildForm(new Korisnik.frmKorisnikDodaj());
            hideSubMenu();
        }

        private void btnRecenzijaPrikaz_Click(object sender, EventArgs e)
        {
            openChildForm(new Recenzije.frmRecenzijaPrikaz());
            hideSubMenu();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuIzvjestaj);
        }

        private void btnIzvjestajPrikaz_Click(object sender, EventArgs e)
        {
            openChildForm(new Izvjestaj.frmReport());
            hideSubMenu();
        }
    }
}
