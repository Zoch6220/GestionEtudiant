namespace ProjetFinalJonathan
{
    partial class Form_lst_etu
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
            txt_code = new TextBox();
            txt_codeProg = new TextBox();
            txt_courriel = new TextBox();
            txt_date = new TextBox();
            txt_prenom = new TextBox();
            txt_nom = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_first = new Button();
            btn_last = new Button();
            btn_suivant = new Button();
            btn_presse = new Button();
            btn_annuler = new Button();
            btn_retour = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_code
            // 
            txt_code.Location = new Point(213, 93);
            txt_code.Name = "txt_code";
            txt_code.ReadOnly = true;
            txt_code.Size = new Size(100, 23);
            txt_code.TabIndex = 24;
            // 
            // txt_codeProg
            // 
            txt_codeProg.Location = new Point(213, 329);
            txt_codeProg.Name = "txt_codeProg";
            txt_codeProg.ReadOnly = true;
            txt_codeProg.Size = new Size(100, 23);
            txt_codeProg.TabIndex = 23;
            // 
            // txt_courriel
            // 
            txt_courriel.Location = new Point(213, 286);
            txt_courriel.Name = "txt_courriel";
            txt_courriel.ReadOnly = true;
            txt_courriel.Size = new Size(181, 23);
            txt_courriel.TabIndex = 22;
            // 
            // txt_date
            // 
            txt_date.Location = new Point(213, 244);
            txt_date.Name = "txt_date";
            txt_date.ReadOnly = true;
            txt_date.Size = new Size(100, 23);
            txt_date.TabIndex = 21;
            // 
            // txt_prenom
            // 
            txt_prenom.Location = new Point(213, 200);
            txt_prenom.Name = "txt_prenom";
            txt_prenom.ReadOnly = true;
            txt_prenom.Size = new Size(181, 23);
            txt_prenom.TabIndex = 20;
            // 
            // txt_nom
            // 
            txt_nom.Location = new Point(213, 144);
            txt_nom.Name = "txt_nom";
            txt_nom.ReadOnly = true;
            txt_nom.Size = new Size(181, 23);
            txt_nom.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 101);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 18;
            label7.Text = "code de l'étudiant";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 152);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 17;
            label6.Text = "nom de l'étudiant";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 208);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 16;
            label5.Text = "prénom de l'étudiant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 252);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 15;
            label4.Text = "date de naissance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 294);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 14;
            label3.Text = "courriel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 337);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 13;
            label2.Text = "code du programme inscrit";
            // 
            // btn_first
            // 
            btn_first.Location = new Point(646, 109);
            btn_first.Name = "btn_first";
            btn_first.Size = new Size(75, 23);
            btn_first.TabIndex = 25;
            btn_first.Text = "Premier";
            btn_first.UseVisualStyleBackColor = true;
            btn_first.Click += btn_first_Click;
            // 
            // btn_last
            // 
            btn_last.Location = new Point(646, 196);
            btn_last.Name = "btn_last";
            btn_last.Size = new Size(75, 23);
            btn_last.TabIndex = 26;
            btn_last.Text = "Dernier";
            btn_last.UseVisualStyleBackColor = true;
            btn_last.Click += btn_last_Click;
            // 
            // btn_suivant
            // 
            btn_suivant.Enabled = false;
            btn_suivant.Location = new Point(646, 167);
            btn_suivant.Name = "btn_suivant";
            btn_suivant.Size = new Size(75, 23);
            btn_suivant.TabIndex = 27;
            btn_suivant.Text = "Suivant";
            btn_suivant.UseVisualStyleBackColor = true;
            btn_suivant.Click += btn_suivant_Click;
            // 
            // btn_presse
            // 
            btn_presse.Enabled = false;
            btn_presse.Location = new Point(646, 138);
            btn_presse.Name = "btn_presse";
            btn_presse.Size = new Size(75, 23);
            btn_presse.TabIndex = 28;
            btn_presse.Text = "Précédent";
            btn_presse.UseVisualStyleBackColor = true;
            btn_presse.Click += btn_presse_Click;
            // 
            // btn_annuler
            // 
            btn_annuler.Location = new Point(319, 400);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(75, 23);
            btn_annuler.TabIndex = 29;
            btn_annuler.Text = "Annuler";
            btn_annuler.UseVisualStyleBackColor = true;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // btn_retour
            // 
            btn_retour.Location = new Point(400, 400);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(75, 23);
            btn_retour.TabIndex = 30;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = true;
            btn_retour.Click += btn_retour_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(299, 25);
            label1.Name = "label1";
            label1.Size = new Size(195, 30);
            label1.TabIndex = 31;
            label1.Text = "Liste des étudiants";
            // 
            // Form_lst_etu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_retour);
            Controls.Add(btn_annuler);
            Controls.Add(btn_presse);
            Controls.Add(btn_suivant);
            Controls.Add(btn_last);
            Controls.Add(btn_first);
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
            Name = "Form_lst_etu";
            Text = "Inscription Collège -Liste Étudiant";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_code;
        private TextBox txt_codeProg;
        private TextBox txt_courriel;
        private TextBox txt_date;
        private TextBox txt_prenom;
        private TextBox txt_nom;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_first;
        private Button btn_last;
        private Button btn_suivant;
        private Button btn_presse;
        private Button btn_annuler;
        private Button btn_retour;
        private Label label1;
    }
}