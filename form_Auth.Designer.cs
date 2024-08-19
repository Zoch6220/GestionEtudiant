namespace ProjetFinalJonathan
{
    partial class form_Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Auth));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txt_user = new TextBox();
            txt_mdp = new TextBox();
            btn_connect = new Button();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(77, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 110);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Nom d'utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 176);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "mot de passe";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(547, 107);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(156, 23);
            txt_user.TabIndex = 3;
            // 
            // txt_mdp
            // 
            txt_mdp.Location = new Point(547, 176);
            txt_mdp.Name = "txt_mdp";
            txt_mdp.Size = new Size(156, 23);
            txt_mdp.TabIndex = 4;
            txt_mdp.UseSystemPasswordChar = true;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(547, 304);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(75, 23);
            btn_connect.TabIndex = 5;
            btn_connect.Text = "Connexion";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(628, 304);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Quitter";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // form_Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(btn_connect);
            Controls.Add(txt_mdp);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "form_Auth";
            Text = "Authentification";
           
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txt_user;
        private TextBox txt_mdp;
        private Button btn_connect;
        private Button btn_exit;
    }
}