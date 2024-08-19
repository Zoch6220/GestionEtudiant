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
    public partial class form_Menu : Form
    {

        private Form_AjoutProgramme ajoutP;
        private FormSuppresionProgramme supresionP;
        public Form_LstProg listerP;
        public Form_Ajout_Etu ajoutE;
        public form_Menu()

        {
            InitializeComponent();
            label_etu.Text = "il y'a " + Program.listeEtudiant.Count.ToString() + " étudiants inscrit au college";
            label_prog.Text = "il y'a " + Program.listeProgramme.Count.ToString() + " programme disponibles au collège";

        }

        private void ajouterProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoutP = new Form_AjoutProgramme();
            ajoutP.Show();
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void supprimerProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supresionP = new FormSuppresionProgramme();
            supresionP.Show();
            this.Hide();
        }

        private void listerProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listerP = new Form_LstProg();
            listerP.Show();
            this.Hide();

        }

        private void ajouterEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoutE = new Form_Ajout_Etu();
            ajoutE.Show();
            this.Hide();
        }

        private void supprimerEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Supp_Etu form_Supp_Etu = new Form_Supp_Etu();
            form_Supp_Etu.Show();
            this.Hide();
        }

        private void listerEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_lst_etu listE = new Form_lst_etu();
            listE.Show();
            this.Hide();
        }
        //private void form_Menu_FormClosing(object sender, FormClosingEventArgs e)
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

        //private void form_Menu_Load(object sender, EventArgs e) => this.FormClosing += form_Menu_FormClosing;
    }
}
