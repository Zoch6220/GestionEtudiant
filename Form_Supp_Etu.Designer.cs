namespace ProjetFinalJonathan
{
    partial class Form_Supp_Etu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Supp_Etu));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_nom = new TextBox();
            txt_prenom = new TextBox();
            txt_date = new TextBox();
            txt_courriel = new TextBox();
            txt_codeProg = new TextBox();
            txt_code = new TextBox();
            btn_recherche = new Button();
            btn_supprime = new Button();
            btn_annuler = new Button();
            btn_retour = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 30);
            label1.Name = "label1";
            label1.Size = new Size(273, 30);
            label1.TabIndex = 0;
            label1.Text = "Suppression d'un étudiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 350);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "code du programme inscrit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 307);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "courriel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 265);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "date de naissance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 221);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 4;
            label5.Text = "prénom de l'étudiant";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 170);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 5;
            label6.Text = "nom de l'étudiant";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 119);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 6;
            label7.Text = "code de l'étudiant";
            // 
            // txt_nom
            // 
            txt_nom.Location = new Point(281, 162);
            txt_nom.Name = "txt_nom";
            txt_nom.ReadOnly = true;
            txt_nom.Size = new Size(181, 23);
            txt_nom.TabIndex = 7;
            txt_nom.TextChanged += txt_nom_TextChanged;
            // 
            // txt_prenom
            // 
            txt_prenom.Location = new Point(281, 213);
            txt_prenom.Name = "txt_prenom";
            txt_prenom.ReadOnly = true;
            txt_prenom.Size = new Size(181, 23);
            txt_prenom.TabIndex = 8;
            txt_prenom.TextChanged += txt_prenom_TextChanged;
            // 
            // txt_date
            // 
            txt_date.Location = new Point(281, 257);
            txt_date.Name = "txt_date";
            txt_date.ReadOnly = true;
            txt_date.Size = new Size(100, 23);
            txt_date.TabIndex = 9;
            txt_date.TextChanged += txt_date_TextChanged;
            // 
            // txt_courriel
            // 
            txt_courriel.Location = new Point(281, 299);
            txt_courriel.Name = "txt_courriel";
            txt_courriel.ReadOnly = true;
            txt_courriel.Size = new Size(181, 23);
            txt_courriel.TabIndex = 10;
            txt_courriel.TextChanged += txt_courriel_TextChanged;
            // 
            // txt_codeProg
            // 
            txt_codeProg.Location = new Point(281, 342);
            txt_codeProg.Name = "txt_codeProg";
            txt_codeProg.ReadOnly = true;
            txt_codeProg.Size = new Size(100, 23);
            txt_codeProg.TabIndex = 11;
            txt_codeProg.TextChanged += txt_codeProg_TextChanged;
            // 
            // txt_code
            // 
            txt_code.Location = new Point(281, 111);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(100, 23);
            txt_code.TabIndex = 12;
            txt_code.TextChanged += txt_code_TextChanged;
            // 
            // btn_recherche
            // 
            btn_recherche.Enabled = false;
            btn_recherche.Location = new Point(387, 110);
            btn_recherche.Name = "btn_recherche";
            btn_recherche.Size = new Size(75, 23);
            btn_recherche.TabIndex = 13;
            btn_recherche.Text = "Recherche";
            btn_recherche.UseVisualStyleBackColor = true;
            btn_recherche.TextChanged += btn_recherche_TextChanged;
            btn_recherche.Click += btn_recherche_Click;
            // 
            // btn_supprime
            // 
            btn_supprime.Enabled = false;
            btn_supprime.Location = new Point(225, 402);
            btn_supprime.Name = "btn_supprime";
            btn_supprime.Size = new Size(75, 23);
            btn_supprime.TabIndex = 14;
            btn_supprime.Text = "Supprimer";
            btn_supprime.UseVisualStyleBackColor = true;
            btn_supprime.Click += btn_supprime_Click;
            // 
            // btn_annuler
            // 
            btn_annuler.Location = new Point(306, 402);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(75, 23);
            btn_annuler.TabIndex = 15;
            btn_annuler.Text = "Annuler";
            btn_annuler.UseVisualStyleBackColor = true;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // btn_retour
            // 
            btn_retour.Location = new Point(387, 402);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(75, 23);
            btn_retour.TabIndex = 16;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = true;
            btn_retour.Click += btn_retour_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(604, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 104);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form_Supp_Etu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_retour);
            Controls.Add(btn_annuler);
            Controls.Add(btn_supprime);
            Controls.Add(btn_recherche);
            Controls.Add(txt_code);
            Controls.Add(txt_codeProg);
            Controls.Add(txt_courriel);
            Controls.Add(txt_date);
            Controls.Add(txt_prenom);
            Controls.Add(txt_nom);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Supp_Etu";
            Text = "Inscription college -Supprimer Étudiant";
            
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_nom;
        private TextBox txt_prenom;
        private TextBox txt_date;
        private TextBox txt_courriel;
        private TextBox txt_codeProg;
        private TextBox txt_code;
        private Button btn_recherche;
        private Button btn_supprime;
        private Button btn_annuler;
        private Button btn_retour;
        private PictureBox pictureBox1;
    }
}