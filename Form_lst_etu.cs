namespace ProjetFinalJonathan
{
    public partial class Form_lst_etu : Form
    {
        int index = 0;
        public Form_lst_etu()
        {
            InitializeComponent();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            if (Program.listeEtudiant.Count > 0)
            {
                index = 0;
                txt_code.Text = Program.listeEtudiant[index].Code;
                txt_nom.Text = Program.listeEtudiant[index].Nom;
                txt_prenom.Text = Program.listeEtudiant[index].Prenom;
                txt_date.Text = Program.listeEtudiant[index].datetoString();
                txt_courriel.Text = Program.listeEtudiant[index].Courriel;
                txt_codeProg.Text = Program.listeEtudiant[index].CodeProg.ToString();
                btn_presse.Enabled = false;
                btn_suivant.Enabled = true;
            }
            else
                MessageBox.Show("Il n'y'a pas d'étudiant d'inscrit");


        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            if (Program.listeEtudiant.Count > 0)
            {
                index = Program.listeEtudiant.Count - 1;
                txt_code.Text = Program.listeEtudiant[index].Code;
                txt_nom.Text = Program.listeEtudiant[index].Nom;
                txt_prenom.Text = Program.listeEtudiant[index].Prenom;
                txt_date.Text = Program.listeEtudiant[index].datetoString();
                txt_courriel.Text = Program.listeEtudiant[index].Courriel;
                txt_codeProg.Text = Program.listeEtudiant[index].CodeProg.ToString();
                btn_presse.Enabled = true;
                btn_suivant.Enabled = false;
            }
            else { MessageBox.Show("Il n'y'a pas d'étudiant d'inscrit"); }


        }

        private void btn_presse_Click(object sender, EventArgs e)
        {
            index--;
            txt_code.Text = Program.listeEtudiant[index].Code;
            txt_nom.Text = Program.listeEtudiant[index].Nom;
            txt_prenom.Text = Program.listeEtudiant[index].Prenom;
            txt_date.Text = Program.listeEtudiant[index].datetoString();
            txt_courriel.Text = Program.listeEtudiant[index].Courriel;
            txt_codeProg.Text = Program.listeEtudiant[index].CodeProg.ToString();
            if (index == 0)
            {
                btn_first.Enabled = false;
                btn_presse.Enabled = false;
            }
            else { btn_presse.Enabled = true; btn_first.Enabled = true; }
            btn_last.Enabled = true;
            btn_suivant.Enabled = true;

        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            index++;
            txt_code.Text = Program.listeEtudiant[index].Code;
            txt_nom.Text = Program.listeEtudiant[index].Nom;
            txt_prenom.Text = Program.listeEtudiant[index].Prenom;
            txt_date.Text = Program.listeEtudiant[index].datetoString();
            txt_courriel.Text = Program.listeEtudiant[index].Courriel;
            txt_codeProg.Text = Program.listeEtudiant[index].CodeProg.ToString();
            if (index == Program.listeEtudiant.Count - 1)
            {
                btn_last.Enabled = false;
                btn_suivant.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_suivant.Enabled = true;
            }
            btn_first.Enabled = true;
            btn_presse.Enabled = true;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {

            txt_code.Text = "";
            txt_nom.Text = "";
            txt_prenom.Text = "";
            txt_date.Text = "";
            txt_courriel.Text = "";
            txt_codeProg.Text = "";
            index = 0;
            btn_first.Enabled = true;
            btn_last.Enabled = true; btn_suivant.Enabled = false;
            btn_presse.Enabled = false;

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
