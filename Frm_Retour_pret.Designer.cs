namespace WindowsFormsApplication1
{
    partial class Frm_Retour_pret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Retour_pret));
            this.groupBox_Retour_Prêt = new System.Windows.Forms.GroupBox();
            this.comboBox_Titre_Livre_Retour = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Date_Prêt = new System.Windows.Forms.DateTimePicker();
            this.button_Valider_Retour = new System.Windows.Forms.Button();
            this.comboBox_Code_Exemplaire = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Date_Retour = new System.Windows.Forms.DateTimePicker();
            this.button_Recherche_Par_Adherent = new System.Windows.Forms.Button();
            this.label_Date_du_prêt = new System.Windows.Forms.Label();
            this.label_Date_du_retour = new System.Windows.Forms.Label();
            this.label_Code_Exemplaire_Retour = new System.Windows.Forms.Label();
            this.label_Titre_Livre_Retour = new System.Windows.Forms.Label();
            this.button_Retour_Menu = new System.Windows.Forms.Button();
            this.groupBox_rechecher_Par_Adhérent = new System.Windows.Forms.GroupBox();
            this.textBox_Recherhe_Avancée_Nom_Adrérent = new System.Windows.Forms.TextBox();
            this.button_Valider_Prêt_Recherhe_Avancée = new System.Windows.Forms.Button();
            this.button_Retour_Recherhe_Avancée = new System.Windows.Forms.Button();
            this.radioButton_Par_Num = new System.Windows.Forms.RadioButton();
            this.radioButton_Par_Nom = new System.Windows.Forms.RadioButton();
            this.button_Lancer_Recherche_Par = new System.Windows.Forms.Button();
            this.dataGridView_Liste_Adhérent = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Retour_Prêt.SuspendLayout();
            this.groupBox_rechecher_Par_Adhérent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Liste_Adhérent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Retour_Prêt
            // 
            this.groupBox_Retour_Prêt.Controls.Add(this.comboBox_Titre_Livre_Retour);
            this.groupBox_Retour_Prêt.Controls.Add(this.dateTimePicker_Date_Prêt);
            this.groupBox_Retour_Prêt.Controls.Add(this.button_Valider_Retour);
            this.groupBox_Retour_Prêt.Controls.Add(this.comboBox_Code_Exemplaire);
            this.groupBox_Retour_Prêt.Controls.Add(this.dateTimePicker_Date_Retour);
            this.groupBox_Retour_Prêt.Controls.Add(this.button_Recherche_Par_Adherent);
            this.groupBox_Retour_Prêt.Controls.Add(this.label_Date_du_prêt);
            this.groupBox_Retour_Prêt.Controls.Add(this.label_Date_du_retour);
            this.groupBox_Retour_Prêt.Controls.Add(this.label_Code_Exemplaire_Retour);
            this.groupBox_Retour_Prêt.Controls.Add(this.label_Titre_Livre_Retour);
            this.groupBox_Retour_Prêt.Controls.Add(this.button_Retour_Menu);
            this.groupBox_Retour_Prêt.Location = new System.Drawing.Point(298, 30);
            this.groupBox_Retour_Prêt.Name = "groupBox_Retour_Prêt";
            this.groupBox_Retour_Prêt.Size = new System.Drawing.Size(628, 342);
            this.groupBox_Retour_Prêt.TabIndex = 12;
            this.groupBox_Retour_Prêt.TabStop = false;
            this.groupBox_Retour_Prêt.Text = "Retour du Prêt";
            // 
            // comboBox_Titre_Livre_Retour
            // 
            this.comboBox_Titre_Livre_Retour.FormattingEnabled = true;
            this.comboBox_Titre_Livre_Retour.Location = new System.Drawing.Point(156, 101);
            this.comboBox_Titre_Livre_Retour.Name = "comboBox_Titre_Livre_Retour";
            this.comboBox_Titre_Livre_Retour.Size = new System.Drawing.Size(240, 26);
            this.comboBox_Titre_Livre_Retour.TabIndex = 32;
            this.comboBox_Titre_Livre_Retour.Text = "Affichage titre du livre";
            // 
            // dateTimePicker_Date_Prêt
            // 
            this.dateTimePicker_Date_Prêt.Location = new System.Drawing.Point(156, 155);
            this.dateTimePicker_Date_Prêt.Name = "dateTimePicker_Date_Prêt";
            this.dateTimePicker_Date_Prêt.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker_Date_Prêt.TabIndex = 0;
            this.dateTimePicker_Date_Prêt.TabStop = false;
            // 
            // button_Valider_Retour
            // 
            this.button_Valider_Retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Valider_Retour.Location = new System.Drawing.Point(392, 289);
            this.button_Valider_Retour.Name = "button_Valider_Retour";
            this.button_Valider_Retour.Size = new System.Drawing.Size(121, 33);
            this.button_Valider_Retour.TabIndex = 1;
            this.button_Valider_Retour.Text = "Valider";
            this.button_Valider_Retour.UseVisualStyleBackColor = false;
            this.button_Valider_Retour.Click += new System.EventHandler(this.button_Valider_Retour_Click);
            // 
            // comboBox_Code_Exemplaire
            // 
            this.comboBox_Code_Exemplaire.FormattingEnabled = true;
            this.comboBox_Code_Exemplaire.Location = new System.Drawing.Point(156, 46);
            this.comboBox_Code_Exemplaire.Name = "comboBox_Code_Exemplaire";
            this.comboBox_Code_Exemplaire.Size = new System.Drawing.Size(240, 26);
            this.comboBox_Code_Exemplaire.TabIndex = 0;
            this.comboBox_Code_Exemplaire.Text = "Entrez Code Exemplaire";
            // 
            // dateTimePicker_Date_Retour
            // 
            this.dateTimePicker_Date_Retour.Location = new System.Drawing.Point(156, 208);
            this.dateTimePicker_Date_Retour.Name = "dateTimePicker_Date_Retour";
            this.dateTimePicker_Date_Retour.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker_Date_Retour.TabIndex = 0;
            this.dateTimePicker_Date_Retour.TabStop = false;
            // 
            // button_Recherche_Par_Adherent
            // 
            this.button_Recherche_Par_Adherent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Recherche_Par_Adherent.Location = new System.Drawing.Point(422, 42);
            this.button_Recherche_Par_Adherent.Name = "button_Recherche_Par_Adherent";
            this.button_Recherche_Par_Adherent.Size = new System.Drawing.Size(181, 33);
            this.button_Recherche_Par_Adherent.TabIndex = 2;
            this.button_Recherche_Par_Adherent.Text = "Recherche par Adhérent ";
            this.button_Recherche_Par_Adherent.UseVisualStyleBackColor = false;
            this.button_Recherche_Par_Adherent.Click += new System.EventHandler(this.button_Recherche_Par_Adherent_Click);
            // 
            // label_Date_du_prêt
            // 
            this.label_Date_du_prêt.AutoSize = true;
            this.label_Date_du_prêt.Location = new System.Drawing.Point(22, 161);
            this.label_Date_du_prêt.Name = "label_Date_du_prêt";
            this.label_Date_du_prêt.Size = new System.Drawing.Size(84, 18);
            this.label_Date_du_prêt.TabIndex = 7;
            this.label_Date_du_prêt.Text = "Date du prêt";
            this.label_Date_du_prêt.Click += new System.EventHandler(this.label_Date_du_prêt_Click);
            // 
            // label_Date_du_retour
            // 
            this.label_Date_du_retour.AutoSize = true;
            this.label_Date_du_retour.Location = new System.Drawing.Point(21, 214);
            this.label_Date_du_retour.Name = "label_Date_du_retour";
            this.label_Date_du_retour.Size = new System.Drawing.Size(97, 18);
            this.label_Date_du_retour.TabIndex = 6;
            this.label_Date_du_retour.Text = "Date du retour";
            // 
            // label_Code_Exemplaire_Retour
            // 
            this.label_Code_Exemplaire_Retour.AutoSize = true;
            this.label_Code_Exemplaire_Retour.Location = new System.Drawing.Point(21, 49);
            this.label_Code_Exemplaire_Retour.Name = "label_Code_Exemplaire_Retour";
            this.label_Code_Exemplaire_Retour.Size = new System.Drawing.Size(110, 18);
            this.label_Code_Exemplaire_Retour.TabIndex = 2;
            this.label_Code_Exemplaire_Retour.Text = "Code Exemplaire";
            // 
            // label_Titre_Livre_Retour
            // 
            this.label_Titre_Livre_Retour.AutoSize = true;
            this.label_Titre_Livre_Retour.Location = new System.Drawing.Point(21, 104);
            this.label_Titre_Livre_Retour.Name = "label_Titre_Livre_Retour";
            this.label_Titre_Livre_Retour.Size = new System.Drawing.Size(83, 18);
            this.label_Titre_Livre_Retour.TabIndex = 2;
            this.label_Titre_Livre_Retour.Text = "Titre du livre";
            // 
            // button_Retour_Menu
            // 
            this.button_Retour_Menu.Location = new System.Drawing.Point(25, 289);
            this.button_Retour_Menu.Name = "button_Retour_Menu";
            this.button_Retour_Menu.Size = new System.Drawing.Size(110, 33);
            this.button_Retour_Menu.TabIndex = 3;
            this.button_Retour_Menu.Text = "Retour Menu";
            this.button_Retour_Menu.UseVisualStyleBackColor = true;
            this.button_Retour_Menu.Click += new System.EventHandler(this.button_Retour_Menu_Click);
            // 
            // groupBox_rechecher_Par_Adhérent
            // 
            this.groupBox_rechecher_Par_Adhérent.Controls.Add(this.textBox_Recherhe_Avancée_Nom_Adrérent);
            this.groupBox_rechecher_Par_Adhérent.Controls.Add(this.button_Valider_Prêt_Recherhe_Avancée);
            this.groupBox_rechecher_Par_Adhérent.Controls.Add(this.button_Retour_Recherhe_Avancée);
            this.groupBox_rechecher_Par_Adhérent.Controls.Add(this.radioButton_Par_Num);
            this.groupBox_rechecher_Par_Adhérent.Controls.Add(this.radioButton_Par_Nom);
            this.groupBox_rechecher_Par_Adhérent.Controls.Add(this.button_Lancer_Recherche_Par);
            this.groupBox_rechecher_Par_Adhérent.Controls.Add(this.dataGridView_Liste_Adhérent);
            this.groupBox_rechecher_Par_Adhérent.Location = new System.Drawing.Point(298, 30);
            this.groupBox_rechecher_Par_Adhérent.Name = "groupBox_rechecher_Par_Adhérent";
            this.groupBox_rechecher_Par_Adhérent.Size = new System.Drawing.Size(660, 403);
            this.groupBox_rechecher_Par_Adhérent.TabIndex = 16;
            this.groupBox_rechecher_Par_Adhérent.TabStop = false;
            this.groupBox_rechecher_Par_Adhérent.Text = "Recherche par Adhérent";
            this.groupBox_rechecher_Par_Adhérent.Visible = false;
            // 
            // textBox_Recherhe_Avancée_Nom_Adrérent
            // 
            this.textBox_Recherhe_Avancée_Nom_Adrérent.Location = new System.Drawing.Point(256, 45);
            this.textBox_Recherhe_Avancée_Nom_Adrérent.Name = "textBox_Recherhe_Avancée_Nom_Adrérent";
            this.textBox_Recherhe_Avancée_Nom_Adrérent.Size = new System.Drawing.Size(205, 26);
            this.textBox_Recherhe_Avancée_Nom_Adrérent.TabIndex = 34;
            this.textBox_Recherhe_Avancée_Nom_Adrérent.TextChanged += new System.EventHandler(this.textBox_Recherhe_Avancée_Nom_Adrérent_TextChanged);
            // 
            // button_Valider_Prêt_Recherhe_Avancée
            // 
            this.button_Valider_Prêt_Recherhe_Avancée.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Valider_Prêt_Recherhe_Avancée.Location = new System.Drawing.Point(403, 348);
            this.button_Valider_Prêt_Recherhe_Avancée.Name = "button_Valider_Prêt_Recherhe_Avancée";
            this.button_Valider_Prêt_Recherhe_Avancée.Size = new System.Drawing.Size(110, 33);
            this.button_Valider_Prêt_Recherhe_Avancée.TabIndex = 8;
            this.button_Valider_Prêt_Recherhe_Avancée.Text = "Valider";
            this.button_Valider_Prêt_Recherhe_Avancée.UseVisualStyleBackColor = false;
            this.button_Valider_Prêt_Recherhe_Avancée.Click += new System.EventHandler(this.button_Valider_Prêt_Recherhe_Avancée_Click);
            // 
            // button_Retour_Recherhe_Avancée
            // 
            this.button_Retour_Recherhe_Avancée.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Retour_Recherhe_Avancée.Location = new System.Drawing.Point(519, 348);
            this.button_Retour_Recherhe_Avancée.Name = "button_Retour_Recherhe_Avancée";
            this.button_Retour_Recherhe_Avancée.Size = new System.Drawing.Size(110, 33);
            this.button_Retour_Recherhe_Avancée.TabIndex = 9;
            this.button_Retour_Recherhe_Avancée.Text = "Retour";
            this.button_Retour_Recherhe_Avancée.UseVisualStyleBackColor = false;
            this.button_Retour_Recherhe_Avancée.Click += new System.EventHandler(this.button_Retour_Recherhe_Avancée_Click);
            // 
            // radioButton_Par_Num
            // 
            this.radioButton_Par_Num.AutoSize = true;
            this.radioButton_Par_Num.Location = new System.Drawing.Point(148, 45);
            this.radioButton_Par_Num.Name = "radioButton_Par_Num";
            this.radioButton_Par_Num.Size = new System.Drawing.Size(80, 22);
            this.radioButton_Par_Num.TabIndex = 4;
            this.radioButton_Par_Num.TabStop = true;
            this.radioButton_Par_Num.Text = "Par Num";
            this.radioButton_Par_Num.UseVisualStyleBackColor = true;
            this.radioButton_Par_Num.CheckedChanged += new System.EventHandler(this.radioButton_Par_Num_CheckedChanged);
            // 
            // radioButton_Par_Nom
            // 
            this.radioButton_Par_Nom.AutoSize = true;
            this.radioButton_Par_Nom.Checked = true;
            this.radioButton_Par_Nom.Location = new System.Drawing.Point(25, 45);
            this.radioButton_Par_Nom.Name = "radioButton_Par_Nom";
            this.radioButton_Par_Nom.Size = new System.Drawing.Size(80, 22);
            this.radioButton_Par_Nom.TabIndex = 3;
            this.radioButton_Par_Nom.TabStop = true;
            this.radioButton_Par_Nom.Text = "Par Nom";
            this.radioButton_Par_Nom.UseVisualStyleBackColor = true;
            this.radioButton_Par_Nom.CheckedChanged += new System.EventHandler(this.radioButton_Par_Nom_CheckedChanged);
            // 
            // button_Lancer_Recherche_Par
            // 
            this.button_Lancer_Recherche_Par.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Lancer_Recherche_Par.Location = new System.Drawing.Point(467, 38);
            this.button_Lancer_Recherche_Par.Name = "button_Lancer_Recherche_Par";
            this.button_Lancer_Recherche_Par.Size = new System.Drawing.Size(161, 33);
            this.button_Lancer_Recherche_Par.TabIndex = 6;
            this.button_Lancer_Recherche_Par.Text = "Lancer Recherche";
            this.button_Lancer_Recherche_Par.UseVisualStyleBackColor = false;
            this.button_Lancer_Recherche_Par.Click += new System.EventHandler(this.button_Lancer_Recherche_Par_Click);
            // 
            // dataGridView_Liste_Adhérent
            // 
            this.dataGridView_Liste_Adhérent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Liste_Adhérent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Liste_Adhérent.Location = new System.Drawing.Point(24, 108);
            this.dataGridView_Liste_Adhérent.Name = "dataGridView_Liste_Adhérent";
            this.dataGridView_Liste_Adhérent.Size = new System.Drawing.Size(604, 209);
            this.dataGridView_Liste_Adhérent.TabIndex = 7;
            this.dataGridView_Liste_Adhérent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Liste_Adhérent_CellClick);

            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(27, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "David Baller";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 213);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Retour_pret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 682);
            this.Controls.Add(this.groupBox_rechecher_Par_Adhérent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_Retour_Prêt);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Retour_pret";
            this.Text = "Gérer les retours";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Retour_pret_Load);
            this.groupBox_Retour_Prêt.ResumeLayout(false);
            this.groupBox_Retour_Prêt.PerformLayout();
            this.groupBox_rechecher_Par_Adhérent.ResumeLayout(false);
            this.groupBox_rechecher_Par_Adhérent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Liste_Adhérent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Retour_Prêt;
        private System.Windows.Forms.Button button_Recherche_Par_Adherent;
        private System.Windows.Forms.Label label_Code_Exemplaire_Retour;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date_Prêt;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date_Retour;
        private System.Windows.Forms.Label label_Date_du_prêt;
        private System.Windows.Forms.Label label_Date_du_retour;
        private System.Windows.Forms.Label label_Titre_Livre_Retour;
        private System.Windows.Forms.Button button_Valider_Retour;
        private System.Windows.Forms.GroupBox groupBox_rechecher_Par_Adhérent;
        private System.Windows.Forms.RadioButton radioButton_Par_Num;
        private System.Windows.Forms.RadioButton radioButton_Par_Nom;
        private System.Windows.Forms.Button button_Valider_Prêt_Recherhe_Avancée;
        private System.Windows.Forms.Button button_Retour_Recherhe_Avancée;
        private System.Windows.Forms.Button button_Lancer_Recherche_Par;
        private System.Windows.Forms.DataGridView dataGridView_Liste_Adhérent;
        private System.Windows.Forms.ComboBox comboBox_Code_Exemplaire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Retour_Menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Titre_Livre_Retour;
        private System.Windows.Forms.TextBox textBox_Recherhe_Avancée_Nom_Adrérent;
    }
}