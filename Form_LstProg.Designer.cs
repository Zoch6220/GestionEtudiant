namespace ProjetFinalJonathan
{
    partial class Form_LstProg
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            domaine = new DataGridViewTextBoxColumn();
            nom = new DataGridViewTextBoxColumn();
            nb_heure = new DataGridViewTextBoxColumn();
            btn_retour = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 29);
            label1.Name = "label1";
            label1.Size = new Size(326, 30);
            label1.TabIndex = 0;
            label1.Text = "Liste des programme du collège";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { code, domaine, nom, nb_heure });
            dataGridView1.Location = new Point(190, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 175);
            dataGridView1.TabIndex = 1;
            // 
            // code
            // 
            code.HeaderText = "Code";
            code.Name = "code";
            // 
            // domaine
            // 
            domaine.HeaderText = "Domaine";
            domaine.Name = "domaine";
            // 
            // nom
            // 
            nom.HeaderText = "Nom";
            nom.Name = "nom";
            // 
            // nb_heure
            // 
            nb_heure.HeaderText = "Nombres d'heure";
            nb_heure.Name = "nb_heure";
            // 
            // btn_retour
            // 
            btn_retour.Location = new Point(373, 348);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(75, 23);
            btn_retour.TabIndex = 2;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = true;
            btn_retour.Click += btn_retour_Click;
            // 
            // Form_LstProg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_retour);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form_LstProg";
            Text = "Inscription Collège -Lister programme";
          
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn domaine;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn nb_heure;
        private Button btn_retour;
    }
}