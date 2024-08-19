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
    public partial class Form_Supp_Etu : Form
    {

        public Form_Supp_Etu()
        {
            InitializeComponent();
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            int index = Program.SearchEtudiant(txt_code.Text.ToString());
            if (index == -1) { MessageBox.Show("L'étudiant n'existe pas"); }
            else
            {
                txt_nom.Text = Program.listeEtudiant[index].Nom;
                txt_prenom.Text = Program.listeEtudiant[index].Prenom;
                txt_date.Text = Program.listeEtudiant[index].datetoString();
                txt_courriel.Text = Program.listeEtudiant[index].Courriel;
                txt_codeProg.Text = Program.listeEtudiant[index].CodeProg.ToString();
            }
        }

        private void btn_supprime_Click(object sender, EventArgs e)
        {
            int index = Program.SearchEtudiant(txt_code.Text);
            if (index >= 0)
            {
                Program.listeEtudiant.RemoveAt(index);

                MessageBox.Show("L'étudiant a été supprimer avec succès");
            }
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
            btn_supprime.Enabled = textBoxRempli;
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

        private void btn_recherche_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_code.Text))
            {
                btn_recherche.Enabled = true;
            }
            else
                btn_recherche.Enabled = false;
        }

        private void txt_codeProg_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_courriel_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_date_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_prenom_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            txt_code.Text = "";
            txt_nom.Text = "";
            txt_prenom.Text = "";
            txt_date.Text = "";
            txt_courriel.Text = "";
            txt_codeProg.Text = "";
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            form_Menu menu = new form_Menu();
            menu.Show();
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
