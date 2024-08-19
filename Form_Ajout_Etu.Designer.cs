namespace ProjetFinalJonathan
{
    partial class Form_Ajout_Etu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajout_Etu));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_code = new TextBox();
            txt_nom = new TextBox();
            txt_prenom = new TextBox();
            txt_courriel = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            btn_annuler = new Button();
            btn_Ajouter = new Button();
            btn_retour = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(251, 26);
            label1.Name = "label1";
            label1.Size = new Size(208, 30);
            label1.TabIndex = 0;
            label1.Text = "Ajout d'un étudiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 115);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Code de l'étudiant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 155);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 2;
            label3.Text = "Nom de l'étudiant";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 302);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 4;
            label5.Text = "Code de programme inscrit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 224);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 5;
            label6.Text = "Date de naissance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 261);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 6;
            label7.Text = "Courriel";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 191);
            label8.Name = "label8";
            label8.Size = new Size(118, 15);
            label8.TabIndex = 7;
            label8.Text = "Prenom de l'etudiant";
            // 
            // txt_code
            // 
            txt_code.Location = new Point(279, 107);
            txt_code.Name = "txt_code";
            txt_code.ReadOnly = true;
            txt_code.Size = new Size(164, 23);
            txt_code.TabIndex = 8;
            // 
            // txt_nom
            // 
            txt_nom.Location = new Point(279, 147);
            txt_nom.Name = "txt_nom";
            txt_nom.Size = new Size(164, 23);
            txt_nom.TabIndex = 9;
            txt_nom.TextChanged += txt_nom_TextChanged;
            // 
            // txt_prenom
            // 
            txt_prenom.Location = new Point(279, 183);
            txt_prenom.Name = "txt_prenom";
            txt_prenom.Size = new Size(164, 23);
            txt_prenom.TabIndex = 10;
            txt_prenom.TextChanged += txt_prenom_TextChanged;
            // 
            // txt_courriel
            // 
            txt_courriel.Location = new Point(279, 253);
            txt_courriel.Name = "txt_courriel";
            txt_courriel.Size = new Size(164, 23);
            txt_courriel.TabIndex = 11;
            txt_courriel.TextChanged += txt_courriel_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(279, 224);
            dateTimePicker1.MaxDate = new DateTime(2023, 5, 27, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2023, 5, 27, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(279, 294);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // btn_annuler
            // 
            btn_annuler.Location = new Point(165, 371);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(75, 23);
            btn_annuler.TabIndex = 14;
            btn_annuler.Text = "Annuler";
            btn_annuler.UseVisualStyleBackColor = true;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // btn_Ajouter
            // 
            btn_Ajouter.Location = new Point(306, 371);
            btn_Ajouter.Name = "btn_Ajouter";
            btn_Ajouter.Size = new Size(75, 23);
            btn_Ajouter.TabIndex = 15;
            btn_Ajouter.Text = "Ajouter";
            btn_Ajouter.UseVisualStyleBackColor = true;
            btn_Ajouter.Click += btn_Ajouter_Click;
            // 
            // btn_retour
            // 
            btn_retour.Location = new Point(442, 371);
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
            pictureBox1.Location = new Point(599, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 114);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form_Ajout_Etu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_retour);
            Controls.Add(btn_Ajouter);
            Controls.Add(btn_annuler);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_courriel);
            Controls.Add(txt_prenom);
            Controls.Add(txt_nom);
            Controls.Add(txt_code);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Ajout_Etu";
            Text = "Inscription collège- Ajouter Étudiant";
          
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_code;
        private TextBox txt_nom;
        private TextBox txt_prenom;
        private TextBox txt_courriel;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button btn_annuler;
        private Button btn_Ajouter;
        private Button btn_retour;
        private PictureBox pictureBox1;
    }
}