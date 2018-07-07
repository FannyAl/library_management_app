namespace WindowsFormsApplication1
{
    partial class Frm_Gerer_les_prets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gerer_les_prets));
            this.groupBox_Ajouter_Prêt = new System.Windows.Forms.GroupBox();
            this.comboBox_Code_Exemplaire = new System.Windows.Forms.ComboBox();
            this.button_Recherche_NomAdherent = new System.Windows.Forms.Button();
            this.comboBox_Num_Adhérent = new System.Windows.Forms.ComboBox();
            this.label_Code_Exemplaire = new System.Windows.Forms.Label();
            this.label_Num_Adhérent = new System.Windows.Forms.Label();
            this.button_Valider_Prêt = new System.Windows.Forms.Button();
            this.button_Retour_Menu = new System.Windows.Forms.Button();
            this.groupBox_recherche_Avancée = new System.Windows.Forms.GroupBox();
            this.comboBox_Recherhe_Avancée_Code_Exemplaire = new System.Windows.Forms.ComboBox();
            this.button_Precedent = new System.Windows.Forms.Button();
            this.button_Valider_Prêt_GroupBox2 = new System.Windows.Forms.Button();
            this.button_Retour_Menu_GroupBox2 = new System.Windows.Forms.Button();
            this.comboBox_Nom_Adhérent = new System.Windows.Forms.ComboBox();
            this.label_Recherhe_Avancée_Nom_Adrérent = new System.Windows.Forms.Label();
            this.label_Recherhe_Avancée_Code_Exemplaire = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Ajouter_Prêt.SuspendLayout();
            this.groupBox_recherche_Avancée.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Ajouter_Prêt
            // 
            this.groupBox_Ajouter_Prêt.Controls.Add(this.comboBox_Code_Exemplaire);
            this.groupBox_Ajouter_Prêt.Controls.Add(this.button_Recherche_NomAdherent);
            this.groupBox_Ajouter_Prêt.Controls.Add(this.comboBox_Num_Adhérent);
            this.groupBox_Ajouter_Prêt.Controls.Add(this.label_Code_Exemplaire);
            this.groupBox_Ajouter_Prêt.Controls.Add(this.label_Num_Adhérent);
            this.groupBox_Ajouter_Prêt.Controls.Add(this.button_Valider_Prêt);
            this.groupBox_Ajouter_Prêt.Controls.Add(this.button_Retour_Menu);
            this.groupBox_Ajouter_Prêt.Location = new System.Drawing.Point(295, 30);
            this.groupBox_Ajouter_Prêt.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Ajouter_Prêt.Name = "groupBox_Ajouter_Prêt";
            this.groupBox_Ajouter_Prêt.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Ajouter_Prêt.Size = new System.Drawing.Size(646, 230);
            this.groupBox_Ajouter_Prêt.TabIndex = 8;
            this.groupBox_Ajouter_Prêt.TabStop = false;
            this.groupBox_Ajouter_Prêt.Text = "Ajouter un Prêt";
            // 
            // comboBox_Code_Exemplaire
            // 
            this.comboBox_Code_Exemplaire.FormattingEnabled = true;
            this.comboBox_Code_Exemplaire.Location = new System.Drawing.Point(165, 104);
            this.comboBox_Code_Exemplaire.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Code_Exemplaire.Name = "comboBox_Code_Exemplaire";
            this.comboBox_Code_Exemplaire.Size = new System.Drawing.Size(245, 26);
            this.comboBox_Code_Exemplaire.TabIndex = 1;
            this.comboBox_Code_Exemplaire.Text = "Entrez Code Exemplaire";
            this.comboBox_Code_Exemplaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Code_Exemplaire_KeyPress);
            // 
            // button_Recherche_NomAdherent
            // 
            this.button_Recherche_NomAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Recherche_NomAdherent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Recherche_NomAdherent.Location = new System.Drawing.Point(447, 50);
            this.button_Recherche_NomAdherent.Name = "button_Recherche_NomAdherent";
            this.button_Recherche_NomAdherent.Size = new System.Drawing.Size(178, 33);
            this.button_Recherche_NomAdherent.TabIndex = 26;
            this.button_Recherche_NomAdherent.Text = "Recherche Nom Adhérent";
            this.button_Recherche_NomAdherent.UseVisualStyleBackColor = false;
            this.button_Recherche_NomAdherent.Click += new System.EventHandler(this.Recherche_Nom_Adherent);
            // 
            // comboBox_Num_Adhérent
            // 
            this.comboBox_Num_Adhérent.FormattingEnabled = true;
            this.comboBox_Num_Adhérent.Location = new System.Drawing.Point(165, 54);
            this.comboBox_Num_Adhérent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Num_Adhérent.Name = "comboBox_Num_Adhérent";
            this.comboBox_Num_Adhérent.Size = new System.Drawing.Size(245, 26);
            this.comboBox_Num_Adhérent.TabIndex = 0;
            this.comboBox_Num_Adhérent.Text = "Entrez  Num Adhérent";
            this.comboBox_Num_Adhérent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Num_Adhérent_KeyPress);
            // 
            // label_Code_Exemplaire
            // 
            this.label_Code_Exemplaire.AutoSize = true;
            this.label_Code_Exemplaire.Location = new System.Drawing.Point(33, 107);
            this.label_Code_Exemplaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Code_Exemplaire.Name = "label_Code_Exemplaire";
            this.label_Code_Exemplaire.Size = new System.Drawing.Size(117, 18);
            this.label_Code_Exemplaire.TabIndex = 2;
            this.label_Code_Exemplaire.Text = "Code Exemplaire :";
            // 
            // label_Num_Adhérent
            // 
            this.label_Num_Adhérent.AutoSize = true;
            this.label_Num_Adhérent.Location = new System.Drawing.Point(33, 55);
            this.label_Num_Adhérent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Num_Adhérent.Name = "label_Num_Adhérent";
            this.label_Num_Adhérent.Size = new System.Drawing.Size(105, 18);
            this.label_Num_Adhérent.TabIndex = 0;
            this.label_Num_Adhérent.Text = "Num Adhérent :";
            // 
            // button_Valider_Prêt
            // 
            this.button_Valider_Prêt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Valider_Prêt.Location = new System.Drawing.Point(300, 173);
            this.button_Valider_Prêt.Margin = new System.Windows.Forms.Padding(4);
            this.button_Valider_Prêt.Name = "button_Valider_Prêt";
            this.button_Valider_Prêt.Size = new System.Drawing.Size(110, 33);
            this.button_Valider_Prêt.TabIndex = 3;
            this.button_Valider_Prêt.Text = "Valider Prêt";
            this.button_Valider_Prêt.UseVisualStyleBackColor = false;
            this.button_Valider_Prêt.Click += new System.EventHandler(this.button_Valider_Prêt_Click);
            // 
            // button_Retour_Menu
            // 
            this.button_Retour_Menu.Location = new System.Drawing.Point(31, 173);
            this.button_Retour_Menu.Name = "button_Retour_Menu";
            this.button_Retour_Menu.Size = new System.Drawing.Size(110, 33);
            this.button_Retour_Menu.TabIndex = 4;
            this.button_Retour_Menu.Text = "Retour Menu";
            this.button_Retour_Menu.UseVisualStyleBackColor = true;
            this.button_Retour_Menu.Click += new System.EventHandler(this.button_Retour_Menu_Click);
            // 
            // groupBox_recherche_Avancée
            // 
            this.groupBox_recherche_Avancée.Controls.Add(this.comboBox_Recherhe_Avancée_Code_Exemplaire);
            this.groupBox_recherche_Avancée.Controls.Add(this.button_Precedent);
            this.groupBox_recherche_Avancée.Controls.Add(this.button_Valider_Prêt_GroupBox2);
            this.groupBox_recherche_Avancée.Controls.Add(this.button_Retour_Menu_GroupBox2);
            this.groupBox_recherche_Avancée.Controls.Add(this.comboBox_Nom_Adhérent);
            this.groupBox_recherche_Avancée.Controls.Add(this.label_Recherhe_Avancée_Nom_Adrérent);
            this.groupBox_recherche_Avancée.Controls.Add(this.label_Recherhe_Avancée_Code_Exemplaire);
            this.groupBox_recherche_Avancée.Location = new System.Drawing.Point(295, 30);
            this.groupBox_recherche_Avancée.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_recherche_Avancée.Name = "groupBox_recherche_Avancée";
            this.groupBox_recherche_Avancée.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_recherche_Avancée.Size = new System.Drawing.Size(646, 230);
            this.groupBox_recherche_Avancée.TabIndex = 28;
            this.groupBox_recherche_Avancée.TabStop = false;
            this.groupBox_recherche_Avancée.Text = "Recherche NomAdhérent";
            this.groupBox_recherche_Avancée.Visible = false;
            // 
            // comboBox_Recherhe_Avancée_Code_Exemplaire
            // 
            this.comboBox_Recherhe_Avancée_Code_Exemplaire.FormattingEnabled = true;
            this.comboBox_Recherhe_Avancée_Code_Exemplaire.Location = new System.Drawing.Point(165, 104);
            this.comboBox_Recherhe_Avancée_Code_Exemplaire.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Recherhe_Avancée_Code_Exemplaire.Name = "comboBox_Recherhe_Avancée_Code_Exemplaire";
            this.comboBox_Recherhe_Avancée_Code_Exemplaire.Size = new System.Drawing.Size(245, 26);
            this.comboBox_Recherhe_Avancée_Code_Exemplaire.TabIndex = 29;
            this.comboBox_Recherhe_Avancée_Code_Exemplaire.Text = "Entrez Code Exemplaire";
            this.comboBox_Recherhe_Avancée_Code_Exemplaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Recherhe_Avancée_Code_Exemplaire_KeyPress);
            // 
            // button_Precedent
            // 
            this.button_Precedent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Precedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Precedent.Location = new System.Drawing.Point(447, 50);
            this.button_Precedent.Name = "button_Precedent";
            this.button_Precedent.Size = new System.Drawing.Size(110, 33);
            this.button_Precedent.TabIndex = 32;
            this.button_Precedent.Text = "Précédent";
            this.button_Precedent.UseVisualStyleBackColor = false;
            this.button_Precedent.Click += new System.EventHandler(this.button_Precedent_Click);
            // 
            // button_Valider_Prêt_GroupBox2
            // 
            this.button_Valider_Prêt_GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Valider_Prêt_GroupBox2.Location = new System.Drawing.Point(300, 173);
            this.button_Valider_Prêt_GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.button_Valider_Prêt_GroupBox2.Name = "button_Valider_Prêt_GroupBox2";
            this.button_Valider_Prêt_GroupBox2.Size = new System.Drawing.Size(110, 33);
            this.button_Valider_Prêt_GroupBox2.TabIndex = 29;
            this.button_Valider_Prêt_GroupBox2.Text = "Valider Prêt";
            this.button_Valider_Prêt_GroupBox2.UseVisualStyleBackColor = false;
            this.button_Valider_Prêt_GroupBox2.Click += new System.EventHandler(this.button_Valider_Prêt_GroupBox2_Click);
            // 
            // button_Retour_Menu_GroupBox2
            // 
            this.button_Retour_Menu_GroupBox2.Location = new System.Drawing.Point(31, 173);
            this.button_Retour_Menu_GroupBox2.Name = "button_Retour_Menu_GroupBox2";
            this.button_Retour_Menu_GroupBox2.Size = new System.Drawing.Size(110, 33);
            this.button_Retour_Menu_GroupBox2.TabIndex = 30;
            this.button_Retour_Menu_GroupBox2.Text = "Retour Menu";
            this.button_Retour_Menu_GroupBox2.UseVisualStyleBackColor = true;
            this.button_Retour_Menu_GroupBox2.Click += new System.EventHandler(this.button_Retour_Menu_GroupBox2_Click);
            // 
            // comboBox_Nom_Adhérent
            // 
            this.comboBox_Nom_Adhérent.FormattingEnabled = true;
            this.comboBox_Nom_Adhérent.Location = new System.Drawing.Point(165, 54);
            this.comboBox_Nom_Adhérent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Nom_Adhérent.Name = "comboBox_Nom_Adhérent";
            this.comboBox_Nom_Adhérent.Size = new System.Drawing.Size(245, 26);
            this.comboBox_Nom_Adhérent.TabIndex = 27;
            this.comboBox_Nom_Adhérent.Text = "Entrez  Nom Adhérent";
            this.comboBox_Nom_Adhérent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Nom_Adhérent_KeyPress);
            // 
            // label_Recherhe_Avancée_Nom_Adrérent
            // 
            this.label_Recherhe_Avancée_Nom_Adrérent.AutoSize = true;
            this.label_Recherhe_Avancée_Nom_Adrérent.Location = new System.Drawing.Point(33, 55);
            this.label_Recherhe_Avancée_Nom_Adrérent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Recherhe_Avancée_Nom_Adrérent.Name = "label_Recherhe_Avancée_Nom_Adrérent";
            this.label_Recherhe_Avancée_Nom_Adrérent.Size = new System.Drawing.Size(105, 18);
            this.label_Recherhe_Avancée_Nom_Adrérent.TabIndex = 10;
            this.label_Recherhe_Avancée_Nom_Adrérent.Text = "Nom Adhérent :";
            // 
            // label_Recherhe_Avancée_Code_Exemplaire
            // 
            this.label_Recherhe_Avancée_Code_Exemplaire.AutoSize = true;
            this.label_Recherhe_Avancée_Code_Exemplaire.Location = new System.Drawing.Point(33, 107);
            this.label_Recherhe_Avancée_Code_Exemplaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Recherhe_Avancée_Code_Exemplaire.Name = "label_Recherhe_Avancée_Code_Exemplaire";
            this.label_Recherhe_Avancée_Code_Exemplaire.Size = new System.Drawing.Size(117, 18);
            this.label_Recherhe_Avancée_Code_Exemplaire.TabIndex = 7;
            this.label_Recherhe_Avancée_Code_Exemplaire.Text = "Code Exemplaire :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(27, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "David Baller";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 213);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Gerer_les_prets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1189, 742);
            this.Controls.Add(this.groupBox_recherche_Avancée);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_Ajouter_Prêt);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Gerer_les_prets";
            this.Text = "Gérer les prêts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Gerer_les_prets_Load);
            this.groupBox_Ajouter_Prêt.ResumeLayout(false);
            this.groupBox_Ajouter_Prêt.PerformLayout();
            this.groupBox_recherche_Avancée.ResumeLayout(false);
            this.groupBox_recherche_Avancée.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Ajouter_Prêt;
        private System.Windows.Forms.ComboBox comboBox_Num_Adhérent;
        private System.Windows.Forms.Label label_Code_Exemplaire;
        private System.Windows.Forms.Label label_Num_Adhérent;
        private System.Windows.Forms.GroupBox groupBox_recherche_Avancée;
        private System.Windows.Forms.Label label_Recherhe_Avancée_Nom_Adrérent;
        private System.Windows.Forms.Label label_Recherhe_Avancée_Code_Exemplaire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Valider_Prêt;
        private System.Windows.Forms.Button button_Recherche_NomAdherent;
        private System.Windows.Forms.Button button_Retour_Menu;
        private System.Windows.Forms.Button button_Retour_Menu_GroupBox2;
        private System.Windows.Forms.Button button_Valider_Prêt_GroupBox2;
        private System.Windows.Forms.ComboBox comboBox_Nom_Adhérent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Precedent;
        private System.Windows.Forms.ComboBox comboBox_Code_Exemplaire;
        private System.Windows.Forms.ComboBox comboBox_Recherhe_Avancée_Code_Exemplaire;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}