namespace ProjetFinalJonathan
{
    public partial class Form_Ajout_Etu : Form
    {
        form_Menu menu;
        public Form_Ajout_Etu()
        {
            InitializeComponent();
            List<string> listCode = new List<string>();
            foreach (ProgrammeEtude prog in Program.listeProgramme)
            {
                listCode.Add(prog.Code.ToString());
            }
            comboBox1.Items.AddRange(listCode.ToArray());
        }

        private void checkButtonEnable()
        {
            bool textBoxRempli = true;
            foreach (TextBox textbox in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(textbox.Text) && !textbox.ReadOnly)
                {
                    textBoxRempli = false;
                    break;
                }
            }
            if (comboBox1.Text.Equals(""))
            {
                textBoxRempli = false;
            }
            btn_Ajouter.Enabled = textBoxRempli;
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_prenom_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void txt_courriel_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            checkButtonEnable();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            Etudiant etudiant = new Etudiant(txt_nom.Text, txt_prenom.Text, date, txt_courriel.Text, int.Parse(comboBox1.Text));
            Program.listeEtudiant.Add(etudiant);
            txt_code.Text = etudiant.Code.ToString();
            MessageBox.Show("L'étudiant a été ajouté avec succès");
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2000, 12, 31);
            txt_nom.Text = "";
            txt_code.Text = "";
            txt_courriel.Text = "";
            txt_prenom.Text = "";
            comboBox1.Text = "";
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {

            menu = new form_Menu();
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
