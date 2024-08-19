namespace ProjetFinalJonathan
{
    partial class form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Menu));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            programmeToolStripMenuItem = new ToolStripMenuItem();
            ajouterProgrammeToolStripMenuItem = new ToolStripMenuItem();
            supprimerProgrammeToolStripMenuItem = new ToolStripMenuItem();
            listerProgrammeToolStripMenuItem = new ToolStripMenuItem();
            etudiantToolStripMenuItem = new ToolStripMenuItem();
            ajouterEtudiantToolStripMenuItem = new ToolStripMenuItem();
            supprimerEtudiantToolStripMenuItem = new ToolStripMenuItem();
            listerEtudiantToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            label_etu = new Label();
            label_prog = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 142);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programmeToolStripMenuItem, etudiantToolStripMenuItem, quitterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // programmeToolStripMenuItem
            // 
            programmeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterProgrammeToolStripMenuItem, supprimerProgrammeToolStripMenuItem, listerProgrammeToolStripMenuItem });
            programmeToolStripMenuItem.Name = "programmeToolStripMenuItem";
            programmeToolStripMenuItem.Size = new Size(82, 20);
            programmeToolStripMenuItem.Text = "Programme";
            // 
            // ajouterProgrammeToolStripMenuItem
            // 
            ajouterProgrammeToolStripMenuItem.Name = "ajouterProgrammeToolStripMenuItem";
            ajouterProgrammeToolStripMenuItem.Size = new Size(195, 22);
            ajouterProgrammeToolStripMenuItem.Text = "Ajouter Programme";
            ajouterProgrammeToolStripMenuItem.Click += ajouterProgrammeToolStripMenuItem_Click;
            // 
            // supprimerProgrammeToolStripMenuItem
            // 
            supprimerProgrammeToolStripMenuItem.Name = "supprimerProgrammeToolStripMenuItem";
            supprimerProgrammeToolStripMenuItem.Size = new Size(195, 22);
            supprimerProgrammeToolStripMenuItem.Text = "Supprimer Programme";
            supprimerProgrammeToolStripMenuItem.Click += supprimerProgrammeToolStripMenuItem_Click;
            // 
            // listerProgrammeToolStripMenuItem
            // 
            listerProgrammeToolStripMenuItem.Name = "listerProgrammeToolStripMenuItem";
            listerProgrammeToolStripMenuItem.Size = new Size(195, 22);
            listerProgrammeToolStripMenuItem.Text = "Lister Programme";
            listerProgrammeToolStripMenuItem.Click += listerProgrammeToolStripMenuItem_Click;
            // 
            // etudiantToolStripMenuItem
            // 
            etudiantToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterEtudiantToolStripMenuItem, supprimerEtudiantToolStripMenuItem, listerEtudiantToolStripMenuItem });
            etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            etudiantToolStripMenuItem.Size = new Size(63, 20);
            etudiantToolStripMenuItem.Text = "Etudiant";
            // 
            // ajouterEtudiantToolStripMenuItem
            // 
            ajouterEtudiantToolStripMenuItem.Name = "ajouterEtudiantToolStripMenuItem";
            ajouterEtudiantToolStripMenuItem.Size = new Size(176, 22);
            ajouterEtudiantToolStripMenuItem.Text = "Ajouter Etudiant";
            ajouterEtudiantToolStripMenuItem.Click += ajouterEtudiantToolStripMenuItem_Click;
            // 
            // supprimerEtudiantToolStripMenuItem
            // 
            supprimerEtudiantToolStripMenuItem.Name = "supprimerEtudiantToolStripMenuItem";
            supprimerEtudiantToolStripMenuItem.Size = new Size(176, 22);
            supprimerEtudiantToolStripMenuItem.Text = "Supprimer Etudiant";
            supprimerEtudiantToolStripMenuItem.Click += supprimerEtudiantToolStripMenuItem_Click;
            // 
            // listerEtudiantToolStripMenuItem
            // 
            listerEtudiantToolStripMenuItem.Name = "listerEtudiantToolStripMenuItem";
            listerEtudiantToolStripMenuItem.Size = new Size(176, 22);
            listerEtudiantToolStripMenuItem.Text = "Lister Etudiant";
            listerEtudiantToolStripMenuItem.Click += listerEtudiantToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(56, 20);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // label_etu
            // 
            label_etu.AutoSize = true;
            label_etu.Location = new Point(383, 153);
            label_etu.Name = "label_etu";
            label_etu.Size = new Size(0, 15);
            label_etu.TabIndex = 2;
            // 
            // label_prog
            // 
            label_prog.AutoSize = true;
            label_prog.Location = new Point(383, 220);
            label_prog.Name = "label_prog";
            label_prog.Size = new Size(0, 15);
            label_prog.TabIndex = 3;
            // 
            // form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_prog);
            Controls.Add(label_etu);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "form_Menu";
            Text = "Inscription College";
          
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programmeToolStripMenuItem;
        private ToolStripMenuItem ajouterProgrammeToolStripMenuItem;
        private ToolStripMenuItem supprimerProgrammeToolStripMenuItem;
        private ToolStripMenuItem listerProgrammeToolStripMenuItem;
        private ToolStripMenuItem etudiantToolStripMenuItem;
        private ToolStripMenuItem ajouterEtudiantToolStripMenuItem;
        private ToolStripMenuItem supprimerEtudiantToolStripMenuItem;
        private ToolStripMenuItem listerEtudiantToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private Label label_etu;
        private Label label_prog;
    }
}