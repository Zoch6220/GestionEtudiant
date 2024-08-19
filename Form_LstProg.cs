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
    public partial class Form_LstProg : Form
    {
        form_Menu menuP;
        public Form_LstProg()
        {
            InitializeComponent();

            foreach (ProgrammeEtude prog in Program.listeProgramme)
            {
                dataGridView1.Rows.Add(prog.Code.ToString(), prog.Domaine, prog.Nom_Programme, prog.Nb_Heure.ToString());
            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            menuP = new form_Menu();
            menuP.Show();
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
