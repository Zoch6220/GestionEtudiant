namespace ProjetFinalJonathan
{
    partial class Form_AjoutProgramme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AjoutProgramme));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_annuler = new Button();
            btn_ajouter = new Button();
            btn_retour = new Button();
            txt_code = new TextBox();
            txt_heure = new TextBox();
            txt_domaine = new TextBox();
            txt_programme = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 66);
            label1.Name = "label1";
            label1.Size = new Size(335, 40);
            label1.TabIndex = 0;
            label1.Text = "Ajout d'un programme";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 192);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Code du programme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 229);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Domaine";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 274);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Nom du programme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 313);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre d'heures";
            // 
            // btn_annuler
            // 
            btn_annuler.Location = new Point(270, 376);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(75, 23);
            btn_annuler.TabIndex = 5;
            btn_annuler.Text = "Annuler";
            btn_annuler.UseVisualStyleBackColor = true;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // btn_ajouter
            // 
            btn_ajouter.Enabled = false;
            btn_ajouter.Location = new Point(380, 376);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(75, 23);
            btn_ajouter.TabIndex = 6;
            btn_ajouter.Text = "Ajouter";
            btn_ajouter.UseVisualStyleBackColor = true;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // btn_retour
            // 
            btn_retour.Location = new Point(489, 376);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(75, 23);
            btn_retour.TabIndex = 7;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = true;
            btn_retour.Click += btn_retour_Click;
            // 
            // txt_code
            // 
            txt_code.Location = new Point(380, 184);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(184, 23);
            txt_code.TabIndex = 8;
            txt_code.TextChanged += txt_code_TextChanged;
            txt_code.KeyPress += txt_code_KeyPress;
            // 
            // txt_heure
            // 
            txt_heure.Location = new Point(380, 305);
            txt_heure.Name = "txt_heure";
            txt_heure.Size = new Size(184, 23);
            txt_heure.TabIndex = 9;
            txt_heure.TextChanged += txt_heure_TextChanged;
            txt_heure.KeyPress += txt_heure_KeyPress;
            // 
            // txt_domaine
            // 
            txt_domaine.Location = new Point(380, 221);
            txt_domaine.Name = "txt_domaine";
            txt_domaine.Size = new Size(184, 23);
            txt_domaine.TabIndex = 10;
            txt_domaine.TextChanged += txt_domaine_TextChanged;
            // 
            // txt_programme
            // 
            txt_programme.Location = new Point(380, 266);
            txt_programme.Name = "txt_programme";
            txt_programme.Size = new Size(184, 23);
            txt_programme.TabIndex = 11;
            txt_programme.TextChanged += txt_programme_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(636, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 107);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form_AjoutProgramme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txt_programme);
            Controls.Add(txt_domaine);
            Controls.Add(txt_heure);
            Controls.Add(txt_code);
            Controls.Add(btn_retour);
            Controls.Add(btn_ajouter);
            Controls.Add(btn_annuler);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_AjoutProgramme";
            Text = "Inscription College -Ajouter programme";
           
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
        private Button btn_annuler;
        private Button btn_ajouter;
        private Button btn_retour;
        private TextBox txt_code;
        private TextBox txt_heure;
        private TextBox txt_domaine;
        private TextBox txt_programme;
        private PictureBox pictureBox1;
    }
}