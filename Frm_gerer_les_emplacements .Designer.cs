namespace WindowsFormsApplication1
{
    partial class Frm_gerer_les_emplacements
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_gerer_les_emplacements));
            this.comboBox_Emplacement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Supprimer = new System.Windows.Forms.Button();
            this.B_modifier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gp_données_emplacement = new System.Windows.Forms.GroupBox();
            this.comboBox_Thème = new System.Windows.Forms.ComboBox();
            this.Label_Thème = new System.Windows.Forms.Label();
            this.textBox_Libellé = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Retour_menu = new System.Windows.Forms.Button();
            this.B_Effacer = new System.Windows.Forms.Button();
            this.B_enregistrer = new System.Windows.Forms.Button();
            this.DG_emplacements = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_détails = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.B_less = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gp_données_emplacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_emplacements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Emplacement
            // 
            this.comboBox_Emplacement.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_Emplacement.FormattingEnabled = true;
            this.comboBox_Emplacement.Items.AddRange(new object[] {
            "Emplacement 1",
            "Emplacement 2",
            "Emplacement 3"});
            this.comboBox_Emplacement.Location = new System.Drawing.Point(131, 84);
            this.comboBox_Emplacement.Name = "comboBox_Emplacement";
            this.comboBox_Emplacement.Size = new System.Drawing.Size(213, 26);
            this.comboBox_Emplacement.TabIndex = 9;
            this.comboBox_Emplacement.Text = "Emplacement 1";
            this.comboBox_Emplacement.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sélectionnez un emplacement :";
            // 
            // B_Supprimer
            // 
            this.B_Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.B_Supprimer.Location = new System.Drawing.Point(939, 77);
            this.B_Supprimer.Name = "B_Supprimer";
            this.B_Supprimer.Size = new System.Drawing.Size(110, 33);
            this.B_Supprimer.TabIndex = 7;
            this.B_Supprimer.Text = "Supprimer";
            this.B_Supprimer.UseVisualStyleBackColor = false;
            this.B_Supprimer.Visible = false;
            this.B_Supprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // B_modifier
            // 
            this.B_modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.B_modifier.Location = new System.Drawing.Point(795, 77);
            this.B_modifier.Name = "B_modifier";
            this.B_modifier.Size = new System.Drawing.Size(110, 33);
            this.B_modifier.TabIndex = 6;
            this.B_modifier.Text = "Modifier";
            this.B_modifier.UseVisualStyleBackColor = false;
            this.B_modifier.Visible = false;
            this.B_modifier.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(667, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gp_données_emplacement
            // 
            this.gp_données_emplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_données_emplacement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gp_données_emplacement.Controls.Add(this.comboBox_Thème);
            this.gp_données_emplacement.Controls.Add(this.Label_Thème);
            this.gp_données_emplacement.Controls.Add(this.textBox_Libellé);
            this.gp_données_emplacement.Controls.Add(this.textBox3);
            this.gp_données_emplacement.Controls.Add(this.textBox2);
            this.gp_données_emplacement.Controls.Add(this.textBox1);
            this.gp_données_emplacement.Controls.Add(this.label6);
            this.gp_données_emplacement.Controls.Add(this.label4);
            this.gp_données_emplacement.Controls.Add(this.label3);
            this.gp_données_emplacement.Controls.Add(this.label2);
            this.gp_données_emplacement.ForeColor = System.Drawing.Color.Black;
            this.gp_données_emplacement.Location = new System.Drawing.Point(30, 143);
            this.gp_données_emplacement.Name = "gp_données_emplacement";
            this.gp_données_emplacement.Size = new System.Drawing.Size(1021, 207);
            this.gp_données_emplacement.TabIndex = 11;
            this.gp_données_emplacement.TabStop = false;
            this.gp_données_emplacement.Text = "Données de l\'emplacement";
            this.gp_données_emplacement.Visible = false;
            // 
            // comboBox_Thème
            // 
            this.comboBox_Thème.FormattingEnabled = true;
            this.comboBox_Thème.Items.AddRange(new object[] {
            "Thème 1",
            "Thème 2",
            "Thème 3"});
            this.comboBox_Thème.Location = new System.Drawing.Point(455, 115);
            this.comboBox_Thème.Name = "comboBox_Thème";
            this.comboBox_Thème.Size = new System.Drawing.Size(213, 26);
            this.comboBox_Thème.TabIndex = 12;
            this.comboBox_Thème.Visible = false;
            // 
            // Label_Thème
            // 
            this.Label_Thème.AutoSize = true;
            this.Label_Thème.Location = new System.Drawing.Point(395, 118);
            this.Label_Thème.Name = "Label_Thème";
            this.Label_Thème.Size = new System.Drawing.Size(50, 18);
            this.Label_Thème.TabIndex = 11;
            this.Label_Thème.Text = "Thème";
            this.Label_Thème.Visible = false;
            // 
            // textBox_Libellé
            // 
            this.textBox_Libellé.Location = new System.Drawing.Point(208, 158);
            this.textBox_Libellé.MaxLength = 50;
            this.textBox_Libellé.Name = "textBox_Libellé";
            this.textBox_Libellé.Size = new System.Drawing.Size(460, 26);
            this.textBox_Libellé.TabIndex = 9;
            this.textBox_Libellé.TextChanged += new System.EventHandler(this.textBox_Libellé_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.Location = new System.Drawing.Point(208, 115);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Location = new System.Drawing.Point(208, 71);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(208, 30);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Code Bibliothèque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Libellé de l\'emplacement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Code Thème";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code Emplacement";
            // 
            // B_Retour_menu
            // 
            this.B_Retour_menu.Location = new System.Drawing.Point(28, 379);
            this.B_Retour_menu.Name = "B_Retour_menu";
            this.B_Retour_menu.Size = new System.Drawing.Size(110, 33);
            this.B_Retour_menu.TabIndex = 14;
            this.B_Retour_menu.Text = "Retour Menu";
            this.B_Retour_menu.UseVisualStyleBackColor = true;
            this.B_Retour_menu.Visible = false;
            this.B_Retour_menu.Click += new System.EventHandler(this.B_Retour_menu_Click);
            // 
            // B_Effacer
            // 
            this.B_Effacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.B_Effacer.Location = new System.Drawing.Point(939, 379);
            this.B_Effacer.Name = "B_Effacer";
            this.B_Effacer.Size = new System.Drawing.Size(110, 33);
            this.B_Effacer.TabIndex = 13;
            this.B_Effacer.Text = "Annuler";
            this.B_Effacer.UseVisualStyleBackColor = false;
            this.B_Effacer.Visible = false;
            this.B_Effacer.Click += new System.EventHandler(this.B_Effacer_Click);
            // 
            // B_enregistrer
            // 
            this.B_enregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.B_enregistrer.Location = new System.Drawing.Point(795, 379);
            this.B_enregistrer.Name = "B_enregistrer";
            this.B_enregistrer.Size = new System.Drawing.Size(110, 33);
            this.B_enregistrer.TabIndex = 12;
            this.B_enregistrer.Text = "Enregistrer";
            this.B_enregistrer.UseVisualStyleBackColor = false;
            this.B_enregistrer.Visible = false;
            this.B_enregistrer.Click += new System.EventHandler(this.button6_Click);
            // 
            // DG_emplacements
            // 
            this.DG_emplacements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_emplacements.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DG_emplacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_emplacements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.DG_emplacements.Location = new System.Drawing.Point(28, 447);
            this.DG_emplacements.Name = "DG_emplacements";
            this.DG_emplacements.Size = new System.Drawing.Size(1021, 197);
            this.DG_emplacements.TabIndex = 16;
            this.DG_emplacements.Visible = false;
            this.DG_emplacements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_emplacements_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "codBibliotheque";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "codEmplacement";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "codTheme";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thème";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "libelEmplacement";
            this.Column4.Name = "Column4";
            this.Column4.Width = 400;
            // 
            // B_détails
            // 
            this.B_détails.Location = new System.Drawing.Point(149, 379);
            this.B_détails.Name = "B_détails";
            this.B_détails.Size = new System.Drawing.Size(36, 33);
            this.B_détails.TabIndex = 15;
            this.B_détails.Text = "+";
            this.B_détails.UseVisualStyleBackColor = true;
            this.B_détails.Visible = false;
            this.B_détails.Click += new System.EventHandler(this.B_détails_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(974, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fanny Alliaume";
            // 
            // B_less
            // 
            this.B_less.Location = new System.Drawing.Point(149, 379);
            this.B_less.Name = "B_less";
            this.B_less.Size = new System.Drawing.Size(36, 33);
            this.B_less.TabIndex = 18;
            this.B_less.Text = "-";
            this.B_less.UseVisualStyleBackColor = true;
            this.B_less.Visible = false;
            this.B_less.Click += new System.EventHandler(this.B_less_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_gerer_les_emplacements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1079, 682);
            this.Controls.Add(this.B_less);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DG_emplacements);
            this.Controls.Add(this.B_détails);
            this.Controls.Add(this.B_Retour_menu);
            this.Controls.Add(this.B_Effacer);
            this.Controls.Add(this.B_enregistrer);
            this.Controls.Add(this.gp_données_emplacement);
            this.Controls.Add(this.comboBox_Emplacement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Supprimer);
            this.Controls.Add(this.B_modifier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_gerer_les_emplacements";
            this.Text = "Gérer les emplacements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gp_données_emplacement.ResumeLayout(false);
            this.gp_données_emplacement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_emplacements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_Emplacement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Supprimer;
        private System.Windows.Forms.Button B_modifier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gp_données_emplacement;
        private System.Windows.Forms.TextBox textBox_Libellé;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Thème;
        private System.Windows.Forms.ComboBox comboBox_Thème;
        private System.Windows.Forms.Button B_Retour_menu;
        private System.Windows.Forms.Button B_Effacer;
        private System.Windows.Forms.Button B_enregistrer;
        private System.Windows.Forms.DataGridView DG_emplacements;
        private System.Windows.Forms.Button B_détails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_less;
    }
}

