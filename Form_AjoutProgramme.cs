using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinalJonathan
{
    public partial class Form_AjoutProgramme : Form
    {
        form_Menu menuPrincipale;
        public Form_AjoutProgramme()
        {
            InitializeComponent();
        }

        private void txt_heure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar))) { e.Handled = true; }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            menuPrincipale = new form_Menu();
            menuPrincipale.Show();
            this.Close();

        }

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar))) { e.Handled = true; }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (-1 == Program.SearchProgramme(int.Parse(txt_code.Text)))
            {
                ProgrammeEtude etude = new ProgrammeEtude(int.Parse(txt_code.Text), txt_domaine.Text, txt_programme.Text, int.Parse(txt_heure.Text));
                Program.listeProgramme.Add(etude);
                MessageBox.Show("Le programme a été ajouté avec succès");
                txt_code.Text = "";
                txt_domaine.Text = "";
                txt_heure.Text = "";
                txt_programme.Text = "";


            }
            else
            {
                MessageBox.Show("Le programme existe déjà");
                txt_code.Text = "";
            }

        }
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            txt_code.Text = "";
            txt_domaine.Text = "";
            txt_heure.Text = "";
            txt_programme.Text = "";
        }
        private void checkButtonEnable()
        {
            bool textBoxRempli = true;
            foreach (TextBox textbox in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    textBoxRempli = false;
                    break;
                }
            }
            btn_ajouter.Enabled = textBoxRempli;
        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_domaine_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_programme_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_heure_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }
        //private void form_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        DialogResult resulat = MessageBox.Show("Voulez-vous vraiment quitter?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (resulat == DialogResult.Yes)
        //        {
        //            Application.Exit();
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //        }


        //    }

        //}

        //private void form_Load(object sender, EventArgs e) => this.FormClosing += form_FormClosing;

    }
}
