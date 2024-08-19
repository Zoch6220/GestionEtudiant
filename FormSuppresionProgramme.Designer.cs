namespace ProjetFinalJonathan
{
    partial class FormSuppresionProgramme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuppresionProgramme));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_code = new TextBox();
            txt_domaine = new TextBox();
            txt_programme = new TextBox();
            txt_heure = new TextBox();
            btn_recherche = new Button();
            btn_Supprime = new Button();
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
            label1.Location = new Point(171, 54);
            label1.Name = "label1";
            label1.Size = new Size(305, 30);
            label1.TabIndex = 0;
            label1.Text = "Suppression d'un programme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 155);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Code du programme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 196);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Domaine";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 234);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Nom du programme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 276);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre d'heure";
            // 
            // txt_code
            // 
            txt_code.Location = new Point(304, 147);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(117, 23);
            txt_code.TabIndex = 5;
            txt_code.TextChanged += txt_code_TextChanged;
            txt_code.KeyPress += txt_code_KeyPress;
            // 
            // txt_domaine
            // 
            txt_domaine.Location = new Point(304, 188);
            txt_domaine.Name = "txt_domaine";
            txt_domaine.ReadOnly = true;
            txt_domaine.Size = new Size(172, 23);
            txt_domaine.TabIndex = 6;
            txt_domaine.TextChanged += txt_domaine_TextChanged;
            // 
            // txt_programme
            // 
            txt_programme.Location = new Point(304, 226);
            txt_programme.Name = "txt_programme";
            txt_programme.ReadOnly = true;
            txt_programme.Size = new Size(172, 23);
            txt_programme.TabIndex = 7;
            txt_programme.TextChanged += txt_programme_TextChanged;
            // 
            // txt_heure
            // 
            txt_heure.Location = new Point(304, 268);
            txt_heure.Name = "txt_heure";
            txt_heure.ReadOnly = true;
            txt_heure.Size = new Size(117, 23);
            txt_heure.TabIndex = 8;
            txt_heure.TextChanged += txt_heure_TextChanged;
            // 
            // btn_recherche
            // 
            btn_recherche.Enabled = false;
            btn_recherche.Location = new Point(427, 146);
            btn_recherche.Name = "btn_recherche";
            btn_recherche.Size = new Size(75, 23);
            btn_recherche.TabIndex = 9;
            btn_recherche.Text = "Recherche";
            btn_recherche.UseVisualStyleBackColor = true;
            btn_recherche.Click += btn_recherche_Click;
            // 
            // btn_Supprime
            // 
            btn_Supprime.Enabled = false;
            btn_Supprime.Location = new Point(265, 350);
            btn_Supprime.Name = "btn_Supprime";
            btn_Supprime.Size = new Size(75, 23);
            btn_Supprime.TabIndex = 10;
            btn_Supprime.Text = "Supprimer";
            btn_Supprime.UseVisualStyleBackColor = true;
            btn_Supprime.Click += btn_Supprime_Click;
            // 
            // btn_annuler
            // 
            btn_annuler.Location = new Point(346, 350);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(75, 23);
            btn_annuler.TabIndex = 11;
            btn_annuler.Text = "Annuler";
            btn_annuler.UseVisualStyleBackColor = true;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // btn_retour
            // 
            btn_retour.Location = new Point(427, 350);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(75, 23);
            btn_retour.TabIndex = 12;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = true;
            btn_retour.Click += btn_retour_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(635, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 110);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FormSuppresionProgramme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_retour);
            Controls.Add(btn_annuler);
            Controls.Add(btn_Supprime);
            Controls.Add(btn_recherche);
            Controls.Add(txt_heure);
            Controls.Add(txt_programme);
            Controls.Add(txt_domaine);
            Controls.Add(txt_code);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSuppresionProgramme";
            Text = "Inscription Collège-Supprimer programme";
          
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
        private TextBox txt_code;
        private TextBox txt_domaine;
        private TextBox txt_programme;
        private TextBox txt_heure;
        private Button btn_recherche;
        private Button btn_Supprime;
        private Button btn_annuler;
        private Button btn_retour;
        private PictureBox pictureBox1;
    }
}