namespace WindowsFormsApplication1
{
    partial class Frm_Consulter_le_fond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulter_le_fond));
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox_actions = new System.Windows.Forms.GroupBox();
            this.btn_retour_menu = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.grpbox_leslivres = new System.Windows.Forms.GroupBox();
            this.lab_liste_livre = new System.Windows.Forms.Label();
            this.cmbbox_livre = new System.Windows.Forms.ComboBox();
            this.grpbox_lesthemes = new System.Windows.Forms.GroupBox();
            this.cmbbox_theme = new System.Windows.Forms.ComboBox();
            this.lab_liste_themes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpbox_liste_exemplaire = new System.Windows.Forms.GroupBox();
            this.datagb_exemplaires = new System.Windows.Forms.DataGridView();
            this.grpbox_actions.SuspendLayout();
            this.grpbox_leslivres.SuspendLayout();
            this.grpbox_lesthemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbox_liste_exemplaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagb_exemplaires)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(32, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Bangaly Fofana";
            // 
            // grpbox_actions
            // 
            this.grpbox_actions.Controls.Add(this.btn_retour_menu);
            this.grpbox_actions.Controls.Add(this.btn_imprimer);
            this.grpbox_actions.Location = new System.Drawing.Point(853, 553);
            this.grpbox_actions.Name = "grpbox_actions";
            this.grpbox_actions.Size = new System.Drawing.Size(200, 92);
            this.grpbox_actions.TabIndex = 42;
            this.grpbox_actions.TabStop = false;
            this.grpbox_actions.Text = "Actions";
            this.grpbox_actions.Visible = false;
            // 
            // btn_retour_menu
            // 
            this.btn_retour_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_retour_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_retour_menu.Location = new System.Drawing.Point(71, 37);
            this.btn_retour_menu.Name = "btn_retour_menu";
            this.btn_retour_menu.Size = new System.Drawing.Size(110, 33);
            this.btn_retour_menu.TabIndex = 18;
            this.btn_retour_menu.Text = "Retour Menu";
            this.btn_retour_menu.UseVisualStyleBackColor = false;
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimer.BackColor = System.Drawing.Color.White;
            this.btn_imprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imprimer.BackgroundImage")));
            this.btn_imprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimer.Location = new System.Drawing.Point(17, 25);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(47, 45);
            this.btn_imprimer.TabIndex = 20;
            this.btn_imprimer.UseVisualStyleBackColor = false;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click_1);
            // 
            // grpbox_leslivres
            // 
            this.grpbox_leslivres.Controls.Add(this.lab_liste_livre);
            this.grpbox_leslivres.Controls.Add(this.cmbbox_livre);
            this.grpbox_leslivres.Location = new System.Drawing.Point(126, 87);
            this.grpbox_leslivres.Name = "grpbox_leslivres";
            this.grpbox_leslivres.Size = new System.Drawing.Size(540, 54);
            this.grpbox_leslivres.TabIndex = 41;
            this.grpbox_leslivres.TabStop = false;
            this.grpbox_leslivres.Text = "Livres";
            this.grpbox_leslivres.Visible = false;
            // 
            // lab_liste_livre
            // 
            this.lab_liste_livre.AutoSize = true;
            this.lab_liste_livre.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_liste_livre.Location = new System.Drawing.Point(6, 22);
            this.lab_liste_livre.Name = "lab_liste_livre";
            this.lab_liste_livre.Size = new System.Drawing.Size(154, 18);
            this.lab_liste_livre.TabIndex = 11;
            this.lab_liste_livre.Text = "Sélectionnez un Livre :";
            // 
            // cmbbox_livre
            // 
            this.cmbbox_livre.Items.AddRange(new object[] {
            "rest"});
            this.cmbbox_livre.Location = new System.Drawing.Point(218, 19);
            this.cmbbox_livre.Name = "cmbbox_livre";
            this.cmbbox_livre.Size = new System.Drawing.Size(259, 26);
            this.cmbbox_livre.TabIndex = 12;
            this.cmbbox_livre.SelectedIndexChanged += new System.EventHandler(this.cmbbox_livre_SelectedIndexChanged);
            // 
            // grpbox_lesthemes
            // 
            this.grpbox_lesthemes.Controls.Add(this.cmbbox_theme);
            this.grpbox_lesthemes.Controls.Add(this.lab_liste_themes);
            this.grpbox_lesthemes.Location = new System.Drawing.Point(126, 37);
            this.grpbox_lesthemes.Name = "grpbox_lesthemes";
            this.grpbox_lesthemes.Size = new System.Drawing.Size(540, 51);
            this.grpbox_lesthemes.TabIndex = 40;
            this.grpbox_lesthemes.TabStop = false;
            this.grpbox_lesthemes.Text = "Thèmes";
            // 
            // cmbbox_theme
            // 
            this.cmbbox_theme.FormattingEnabled = true;
            this.cmbbox_theme.Items.AddRange(new object[] {
            "Bandes dessinées",
            "Dictionnaires",
            "Histoire comtemporaine",
            "Polard",
            "Science Fiction"});
            this.cmbbox_theme.Location = new System.Drawing.Point(218, 18);
            this.cmbbox_theme.Name = "cmbbox_theme";
            this.cmbbox_theme.Size = new System.Drawing.Size(259, 26);
            this.cmbbox_theme.TabIndex = 10;
            this.cmbbox_theme.SelectedIndexChanged += new System.EventHandler(this.cmbbox_theme_SelectedIndexChanged_1);
            // 
            // lab_liste_themes
            // 
            this.lab_liste_themes.AutoSize = true;
            this.lab_liste_themes.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_liste_themes.Location = new System.Drawing.Point(6, 22);
            this.lab_liste_themes.Name = "lab_liste_themes";
            this.lab_liste_themes.Size = new System.Drawing.Size(167, 18);
            this.lab_liste_themes.TabIndex = 9;
            this.lab_liste_themes.Text = "Selectionnez un Thème :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Img_petit_service_culturel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(35, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // grpbox_liste_exemplaire
            // 
            this.grpbox_liste_exemplaire.Controls.Add(this.datagb_exemplaires);
            this.grpbox_liste_exemplaire.Location = new System.Drawing.Point(35, 175);
            this.grpbox_liste_exemplaire.Name = "grpbox_liste_exemplaire";
            this.grpbox_liste_exemplaire.Size = new System.Drawing.Size(1018, 372);
            this.grpbox_liste_exemplaire.TabIndex = 38;
            this.grpbox_liste_exemplaire.TabStop = false;
            this.grpbox_liste_exemplaire.Text = "Liste des Exemplaires existant";
            this.grpbox_liste_exemplaire.Visible = false;
            // 
            // datagb_exemplaires
            // 
            this.datagb_exemplaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagb_exemplaires.Location = new System.Drawing.Point(6, 51);
            this.datagb_exemplaires.Name = "datagb_exemplaires";
            this.datagb_exemplaires.Size = new System.Drawing.Size(1006, 315);
            this.datagb_exemplaires.TabIndex = 5;
            // 
            // Frm_Consulter_le_fond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1085, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbox_actions);
            this.Controls.Add(this.grpbox_leslivres);
            this.Controls.Add(this.grpbox_lesthemes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbox_liste_exemplaire);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Consulter_le_fond";
            this.Text = "Consulter le fond";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Consulter_le_fond_Load);
            this.grpbox_actions.ResumeLayout(false);
            this.grpbox_leslivres.ResumeLayout(false);
            this.grpbox_leslivres.PerformLayout();
            this.grpbox_lesthemes.ResumeLayout(false);
            this.grpbox_lesthemes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbox_liste_exemplaire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagb_exemplaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbox_actions;
        private System.Windows.Forms.Button btn_retour_menu;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.GroupBox grpbox_leslivres;
        private System.Windows.Forms.Label lab_liste_livre;
        private System.Windows.Forms.ComboBox cmbbox_livre;
        private System.Windows.Forms.GroupBox grpbox_lesthemes;
        private System.Windows.Forms.ComboBox cmbbox_theme;
        private System.Windows.Forms.Label lab_liste_themes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpbox_liste_exemplaire;
        private System.Windows.Forms.DataGridView datagb_exemplaires;

    }
}