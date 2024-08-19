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
    public partial class form_Auth : Form
    {
        public form_Auth()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool auth = false;
            try { auth = Program.SearchUser(txt_user.Text, int.Parse(txt_mdp.Text)); }catch { MessageBox.Show("Une erreur c'est produite"); }
           
            if(auth)
            {   form_Menu menu = new form_Menu();
                menu.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("l'utilisateur ou l'utilisateur est incorrect");
            }

        }

            private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
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
