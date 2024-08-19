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
    public partial class FormSuppresionProgramme : Form
    {
        form_Menu menuPrincipale;
        public FormSuppresionProgramme()
        {
            InitializeComponent();
        }

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar))) { e.Handled = true; }
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            int codeAChercher = int.Parse(txt_code.Text);
            int index = Program.SearchProgramme(codeAChercher);
            if (index == -1)
            {
                MessageBox.Show("Le programme n'existe pas");
                txt_code.Text = "";
                txt_domaine.Text = "";
                txt_heure.Text = "";
                txt_programme.Text = "";
            }
            else
            {
                txt_domaine.Text = Program.listeProgramme[index].Domaine;
                txt_programme.Text = Program.listeProgramme[index].Nom_Programme;
                txt_heure.Text = Program.listeProgramme[index].Nb_Heure.ToString();

            }

        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_code.Text))
            {
                btn_recherche.Enabled = true;
            }
            else
                btn_recherche.Enabled = false;
            checkButtonEnable();
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
            btn_Supprime.Enabled = textBoxRempli;
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

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            txt_code.Text = "";
            txt_domaine.Text = "";
            txt_heure.Text = "";
            txt_programme.Text = "";
        }

        private void btn_Supprime_Click(object sender, EventArgs e)
        {
            int index = Program.SearchProgramme(int.Parse(txt_code.Text));
            Program.listeProgramme.RemoveAt(index);
            txt_code.Text = "";
            txt_domaine.Text = "";
            txt_heure.Text = "";
            txt_programme.Text = "";
            MessageBox.Show("Le programe a été effacé avec succès");
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            menuPrincipale = new form_Menu();
            menuPrincipale.Show();
            this.Close();
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
