namespace WindowsFormsApplication1
{
    partial class Frm_Emplacements
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Emplacements));
            this.BTN_Less = new System.Windows.Forms.Button();
            this.LBL_Designer = new System.Windows.Forms.Label();
            this.DTGRD_Emplacements = new System.Windows.Forms.DataGridView();
            this.BTN_Retour_Menu = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Enregistrer = new System.Windows.Forms.Button();
            this.GRPBX_Donnees_emplacement = new System.Windows.Forms.GroupBox();
            this.GRPBX_Libelle = new System.Windows.Forms.GroupBox();
            this.LBL_Etage = new System.Windows.Forms.Label();
            this.NUMRC_Rayon = new System.Windows.Forms.NumericUpDown();
            this.NUMRC_Etage = new System.Windows.Forms.NumericUpDown();
            this.LBL_Rayon = new System.Windows.Forms.Label();
            this.LBL_Allee = new System.Windows.Forms.Label();
            this.NUMRC_Allee = new System.Windows.Forms.NumericUpDown();
            this.COMBO_Theme = new System.Windows.Forms.ComboBox();
            this.LBL_Theme = new System.Windows.Forms.Label();
            this.TXTBX_CodeTheme = new System.Windows.Forms.TextBox();
            this.TXTBX_CodeEmplacement = new System.Windows.Forms.TextBox();
            this.TXTBX_CodeBiblio = new System.Windows.Forms.TextBox();
            this.LBL_CodeBiblio = new System.Windows.Forms.Label();
            this.LBL_CodeTheme = new System.Windows.Forms.Label();
            this.LBL_CodeEmplacement = new System.Windows.Forms.Label();
            this.COMBO_SelectEmplacement = new System.Windows.Forms.ComboBox();
            this.LBL_SelectEmplacements = new System.Windows.Forms.Label();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Nouveau = new System.Windows.Forms.Button();
            this.PICBX_Biblio = new System.Windows.Forms.PictureBox();
            this.BTN_Details = new System.Windows.Forms.Button();
            this.BTN_MAJ = new System.Windows.Forms.Button();
            this.BTN_Suiv = new System.Windows.Forms.Button();
            this.BTN_Prec = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DTGRD_Emplacements)).BeginInit();
            this.GRPBX_Donnees_emplacement.SuspendLayout();
            this.GRPBX_Libelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRC_Rayon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRC_Etage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRC_Allee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBX_Biblio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Less
            // 
            this.BTN_Less.Location = new System.Drawing.Point(147, 370);
            this.BTN_Less.Name = "BTN_Less";
            this.BTN_Less.Size = new System.Drawing.Size(36, 33);
            this.BTN_Less.TabIndex = 31;
            this.BTN_Less.Text = "-";
            this.BTN_Less.UseVisualStyleBackColor = true;
            this.BTN_Less.Visible = false;
            this.BTN_Less.Click += new System.EventHandler(this.BTN_Less_Click);
            // 
            // LBL_Designer
            // 
            this.LBL_Designer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Designer.AutoSize = true;
            this.LBL_Designer.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Designer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LBL_Designer.Location = new System.Drawing.Point(972, 642);
            this.LBL_Designer.Name = "LBL_Designer";
            this.LBL_Designer.Size = new System.Drawing.Size(77, 13);
            this.LBL_Designer.TabIndex = 30;
            this.LBL_Designer.Text = "Fanny Alliaume";
            // 
            // DTGRD_Emplacements
            // 
            this.DTGRD_Emplacements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTGRD_Emplacements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGRD_Emplacements.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DTGRD_Emplacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGRD_Emplacements.Location = new System.Drawing.Point(26, 438);
            this.DTGRD_Emplacements.Name = "DTGRD_Emplacements";
            this.DTGRD_Emplacements.Size = new System.Drawing.Size(1021, 197);
            this.DTGRD_Emplacements.TabIndex = 29;
            this.DTGRD_Emplacements.Visible = false;
            // 
            // BTN_Retour_Menu
            // 
            this.BTN_Retour_Menu.Location = new System.Drawing.Point(26, 370);
            this.BTN_Retour_Menu.Name = "BTN_Retour_Menu";
            this.BTN_Retour_Menu.Size = new System.Drawing.Size(110, 33);
            this.BTN_Retour_Menu.TabIndex = 28;
            this.BTN_Retour_Menu.Text = "Retour Menu";
            this.BTN_Retour_Menu.UseVisualStyleBackColor = true;
            this.BTN_Retour_Menu.Visible = false;
            this.BTN_Retour_Menu.Click += new System.EventHandler(this.BTN_Retour_Menu_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Annuler.Location = new System.Drawing.Point(937, 370);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(110, 33);
            this.BTN_Annuler.TabIndex = 27;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = false;
            this.BTN_Annuler.Visible = false;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Effacer_Click);
            // 
            // BTN_Enregistrer
            // 
            this.BTN_Enregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Enregistrer.Location = new System.Drawing.Point(793, 370);
            this.BTN_Enregistrer.Name = "BTN_Enregistrer";
            this.BTN_Enregistrer.Size = new System.Drawing.Size(110, 33);
            this.BTN_Enregistrer.TabIndex = 26;
            this.BTN_Enregistrer.Text = "Enregistrer";
            this.BTN_Enregistrer.UseVisualStyleBackColor = false;
            this.BTN_Enregistrer.Visible = false;
            this.BTN_Enregistrer.Click += new System.EventHandler(this.BTN_Enregistrer_Click);
            // 
            // GRPBX_Donnees_emplacement
            // 
            this.GRPBX_Donnees_emplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRPBX_Donnees_emplacement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GRPBX_Donnees_emplacement.Controls.Add(this.GRPBX_Libelle);
            this.GRPBX_Donnees_emplacement.Controls.Add(this.COMBO_Theme);
            this.GRPBX_Donnees_emplacement.Controls.Add(this.LBL_Theme);
            this.GRPBX_Donnees_emplacement.Controls.Add(this.TXTBX_CodeTheme);
            this.GRPBX_Donnees_emplacement.Controls.Add(this.TXTBX_CodeEmplacement);
            this.GRPBX_Donnees_emplacement.Controls.Add(this.TXTBX_CodeBiblio);
            this.GRPBX_Donnees_emplacement.Controls.Add(this.LBL_CodeBiblio);
            this.GRPBX_Donnees_emplacement.Controls.Add(this.LBL_CodeTheme);
            this.GRPBX_Donnees_emplacement.Controls.Add(this.LBL_CodeEmplacement);
            this.GRPBX_Donnees_emplacement.ForeColor = System.Drawing.Color.Black;
            this.GRPBX_Donnees_emplacement.Location = new System.Drawing.Point(28, 134);
            this.GRPBX_Donnees_emplacement.Name = "GRPBX_Donnees_emplacement";
            this.GRPBX_Donnees_emplacement.Size = new System.Drawing.Size(1021, 207);
            this.GRPBX_Donnees_emplacement.TabIndex = 25;
            this.GRPBX_Donnees_emplacement.TabStop = false;
            this.GRPBX_Donnees_emplacement.Text = "Données de l\'emplacement";
            this.GRPBX_Donnees_emplacement.Visible = false;
            // 
            // GRPBX_Libelle
            // 
            this.GRPBX_Libelle.Controls.Add(this.LBL_Etage);
            this.GRPBX_Libelle.Controls.Add(this.NUMRC_Rayon);
            this.GRPBX_Libelle.Controls.Add(this.NUMRC_Etage);
            this.GRPBX_Libelle.Controls.Add(this.LBL_Rayon);
            this.GRPBX_Libelle.Controls.Add(this.LBL_Allee);
            this.GRPBX_Libelle.Controls.Add(this.NUMRC_Allee);
            this.GRPBX_Libelle.Location = new System.Drawing.Point(31, 120);
            this.GRPBX_Libelle.Name = "GRPBX_Libelle";
            this.GRPBX_Libelle.Size = new System.Drawing.Size(962, 63);
            this.GRPBX_Libelle.TabIndex = 19;
            this.GRPBX_Libelle.TabStop = false;
            this.GRPBX_Libelle.Text = "Libellé de l\'emplacement";
            this.GRPBX_Libelle.Visible = false;
            // 
            // LBL_Etage
            // 
            this.LBL_Etage.AutoSize = true;
            this.LBL_Etage.Location = new System.Drawing.Point(85, 28);
            this.LBL_Etage.Name = "LBL_Etage";
            this.LBL_Etage.Size = new System.Drawing.Size(60, 18);
            this.LBL_Etage.TabIndex = 2;
            this.LBL_Etage.Text = "Etage n°";
            // 
            // NUMRC_Rayon
            // 
            this.NUMRC_Rayon.Location = new System.Drawing.Point(688, 24);
            this.NUMRC_Rayon.Name = "NUMRC_Rayon";
            this.NUMRC_Rayon.Size = new System.Drawing.Size(56, 26);
            this.NUMRC_Rayon.TabIndex = 18;
            this.NUMRC_Rayon.Click += new System.EventHandler(this.NUMRC_Rayon_Click);
            // 
            // NUMRC_Etage
            // 
            this.NUMRC_Etage.Location = new System.Drawing.Point(157, 24);
            this.NUMRC_Etage.Name = "NUMRC_Etage";
            this.NUMRC_Etage.Size = new System.Drawing.Size(56, 26);
            this.NUMRC_Etage.TabIndex = 14;
            this.NUMRC_Etage.Click += new System.EventHandler(this.NUMRC_Etage_Click);
            // 
            // LBL_Rayon
            // 
            this.LBL_Rayon.AutoSize = true;
            this.LBL_Rayon.Location = new System.Drawing.Point(603, 28);
            this.LBL_Rayon.Name = "LBL_Rayon";
            this.LBL_Rayon.Size = new System.Drawing.Size(64, 18);
            this.LBL_Rayon.TabIndex = 17;
            this.LBL_Rayon.Text = "Rayon n°";
            // 
            // LBL_Allee
            // 
            this.LBL_Allee.AutoSize = true;
            this.LBL_Allee.Location = new System.Drawing.Point(364, 28);
            this.LBL_Allee.Name = "LBL_Allee";
            this.LBL_Allee.Size = new System.Drawing.Size(55, 18);
            this.LBL_Allee.TabIndex = 15;
            this.LBL_Allee.Text = "Allée n°";
            // 
            // NUMRC_Allee
            // 
            this.NUMRC_Allee.Location = new System.Drawing.Point(436, 24);
            this.NUMRC_Allee.Name = "NUMRC_Allee";
            this.NUMRC_Allee.Size = new System.Drawing.Size(56, 26);
            this.NUMRC_Allee.TabIndex = 16;
            this.NUMRC_Allee.Click += new System.EventHandler(this.NUMRC_Allee_Click);
            // 
            // COMBO_Theme
            // 
            this.COMBO_Theme.FormattingEnabled = true;
            this.COMBO_Theme.Items.AddRange(new object[] {
            "Bande Dessinée",
            "Roman",
            "Art",
            "Enfant",
            "Documentaire"});
            this.COMBO_Theme.Location = new System.Drawing.Point(467, 71);
            this.COMBO_Theme.Name = "COMBO_Theme";
            this.COMBO_Theme.Size = new System.Drawing.Size(179, 26);
            this.COMBO_Theme.TabIndex = 12;
            this.COMBO_Theme.Visible = false;
            this.COMBO_Theme.SelectedIndexChanged += new System.EventHandler(this.COMBO_Theme_SelectedIndexChanged);
            // 
            // LBL_Theme
            // 
            this.LBL_Theme.AutoSize = true;
            this.LBL_Theme.Location = new System.Drawing.Point(395, 75);
            this.LBL_Theme.Name = "LBL_Theme";
            this.LBL_Theme.Size = new System.Drawing.Size(50, 18);
            this.LBL_Theme.TabIndex = 11;
            this.LBL_Theme.Text = "Thème";
            this.LBL_Theme.Visible = false;
            // 
            // TXTBX_CodeTheme
            // 
            this.TXTBX_CodeTheme.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXTBX_CodeTheme.Location = new System.Drawing.Point(540, 29);
            this.TXTBX_CodeTheme.MaxLength = 10;
            this.TXTBX_CodeTheme.Name = "TXTBX_CodeTheme";
            this.TXTBX_CodeTheme.Size = new System.Drawing.Size(106, 26);
            this.TXTBX_CodeTheme.TabIndex = 8;
            // 
            // TXTBX_CodeEmplacement
            // 
            this.TXTBX_CodeEmplacement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXTBX_CodeEmplacement.Location = new System.Drawing.Point(188, 71);
            this.TXTBX_CodeEmplacement.MaxLength = 10;
            this.TXTBX_CodeEmplacement.Name = "TXTBX_CodeEmplacement";
            this.TXTBX_CodeEmplacement.Size = new System.Drawing.Size(106, 26);
            this.TXTBX_CodeEmplacement.TabIndex = 6;
            this.TXTBX_CodeEmplacement.TextChanged += new System.EventHandler(this.TXTBX_CodeEmplacement_TextChanged);
            // 
            // TXTBX_CodeBiblio
            // 
            this.TXTBX_CodeBiblio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXTBX_CodeBiblio.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXTBX_CodeBiblio.Location = new System.Drawing.Point(188, 29);
            this.TXTBX_CodeBiblio.MaxLength = 50;
            this.TXTBX_CodeBiblio.Name = "TXTBX_CodeBiblio";
            this.TXTBX_CodeBiblio.Size = new System.Drawing.Size(106, 26);
            this.TXTBX_CodeBiblio.TabIndex = 5;
            this.TXTBX_CodeBiblio.TextChanged += new System.EventHandler(this.TXTBX_CodeBiblio_TextChanged);
            // 
            // LBL_CodeBiblio
            // 
            this.LBL_CodeBiblio.AutoSize = true;
            this.LBL_CodeBiblio.Location = new System.Drawing.Point(28, 33);
            this.LBL_CodeBiblio.Name = "LBL_CodeBiblio";
            this.LBL_CodeBiblio.Size = new System.Drawing.Size(120, 18);
            this.LBL_CodeBiblio.TabIndex = 4;
            this.LBL_CodeBiblio.Text = "Code Bibliothèque";
            // 
            // LBL_CodeTheme
            // 
            this.LBL_CodeTheme.AutoSize = true;
            this.LBL_CodeTheme.Location = new System.Drawing.Point(395, 33);
            this.LBL_CodeTheme.Name = "LBL_CodeTheme";
            this.LBL_CodeTheme.Size = new System.Drawing.Size(84, 18);
            this.LBL_CodeTheme.TabIndex = 1;
            this.LBL_CodeTheme.Text = "Code Thème";
            // 
            // LBL_CodeEmplacement
            // 
            this.LBL_CodeEmplacement.AutoSize = true;
            this.LBL_CodeEmplacement.Location = new System.Drawing.Point(28, 76);
            this.LBL_CodeEmplacement.Name = "LBL_CodeEmplacement";
            this.LBL_CodeEmplacement.Size = new System.Drawing.Size(127, 18);
            this.LBL_CodeEmplacement.TabIndex = 0;
            this.LBL_CodeEmplacement.Text = "Code Emplacement";
            // 
            // COMBO_SelectEmplacement
            // 
            this.COMBO_SelectEmplacement.ForeColor = System.Drawing.SystemColors.WindowText;
            this.COMBO_SelectEmplacement.FormattingEnabled = true;
            this.COMBO_SelectEmplacement.Location = new System.Drawing.Point(129, 75);
            this.COMBO_SelectEmplacement.Name = "COMBO_SelectEmplacement";
            this.COMBO_SelectEmplacement.Size = new System.Drawing.Size(213, 26);
            this.COMBO_SelectEmplacement.TabIndex = 24;
            this.COMBO_SelectEmplacement.SelectedIndexChanged += new System.EventHandler(this.COMBO_SelectEmplacement_SelectedIndexChanged);
            this.COMBO_SelectEmplacement.SelectionChangeCommitted += new System.EventHandler(this.COMBO_SelectEmplacement_SelectedIndexChanged);
            this.COMBO_SelectEmplacement.SelectedValueChanged += new System.EventHandler(this.COMBO_SelectEmplacement_SelectedIndexChanged);
            this.COMBO_SelectEmplacement.Click += new System.EventHandler(this.COMBO_SelectEmplacement_SelectedIndexChanged);
            this.COMBO_SelectEmplacement.Enter += new System.EventHandler(this.COMBO_SelectEmplacement_SelectedIndexChanged);
            // 
            // LBL_SelectEmplacements
            // 
            this.LBL_SelectEmplacements.AutoSize = true;
            this.LBL_SelectEmplacements.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SelectEmplacements.Location = new System.Drawing.Point(129, 44);
            this.LBL_SelectEmplacements.Name = "LBL_SelectEmplacements";
            this.LBL_SelectEmplacements.Size = new System.Drawing.Size(213, 18);
            this.LBL_SelectEmplacements.TabIndex = 23;
            this.LBL_SelectEmplacements.Text = "Sélectionnez un emplacement :";
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Supprimer.Location = new System.Drawing.Point(937, 68);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(110, 33);
            this.BTN_Supprimer.TabIndex = 22;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = false;
            this.BTN_Supprimer.Visible = false;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Modifier.Location = new System.Drawing.Point(793, 68);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(110, 33);
            this.BTN_Modifier.TabIndex = 21;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = false;
            this.BTN_Modifier.Visible = false;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Nouveau
            // 
            this.BTN_Nouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Nouveau.Location = new System.Drawing.Point(665, 68);
            this.BTN_Nouveau.Name = "BTN_Nouveau";
            this.BTN_Nouveau.Size = new System.Drawing.Size(110, 33);
            this.BTN_Nouveau.TabIndex = 20;
            this.BTN_Nouveau.Text = "Nouveau";
            this.BTN_Nouveau.UseVisualStyleBackColor = false;
            this.BTN_Nouveau.Click += new System.EventHandler(this.BTN_Nouveau_Click);
            // 
            // PICBX_Biblio
            // 
            this.PICBX_Biblio.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M;
            this.PICBX_Biblio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PICBX_Biblio.ErrorImage = null;
            this.PICBX_Biblio.InitialImage = null;
            this.PICBX_Biblio.Location = new System.Drawing.Point(28, 21);
            this.PICBX_Biblio.Name = "PICBX_Biblio";
            this.PICBX_Biblio.Size = new System.Drawing.Size(85, 83);
            this.PICBX_Biblio.TabIndex = 19;
            this.PICBX_Biblio.TabStop = false;
            // 
            // BTN_Details
            // 
            this.BTN_Details.Location = new System.Drawing.Point(147, 370);
            this.BTN_Details.Name = "BTN_Details";
            this.BTN_Details.Size = new System.Drawing.Size(36, 33);
            this.BTN_Details.TabIndex = 32;
            this.BTN_Details.Text = "+";
            this.BTN_Details.UseVisualStyleBackColor = true;
            this.BTN_Details.Visible = false;
            this.BTN_Details.Click += new System.EventHandler(this.BTN_Details_Click);
            // 
            // BTN_MAJ
            // 
            this.BTN_MAJ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_MAJ.BackgroundImage")));
            this.BTN_MAJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_MAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MAJ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_MAJ.Location = new System.Drawing.Point(189, 369);
            this.BTN_MAJ.Name = "BTN_MAJ";
            this.BTN_MAJ.Size = new System.Drawing.Size(41, 34);
            this.BTN_MAJ.TabIndex = 38;
            this.BTN_MAJ.UseVisualStyleBackColor = true;
            this.BTN_MAJ.Visible = false;
            this.BTN_MAJ.Click += new System.EventHandler(this.BTN_MAJ_Click);
            // 
            // BTN_Suiv
            // 
            this.BTN_Suiv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Suiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Suiv.ForeColor = System.Drawing.Color.White;
            this.BTN_Suiv.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Suiv.Image")));
            this.BTN_Suiv.Location = new System.Drawing.Point(274, 370);
            this.BTN_Suiv.Name = "BTN_Suiv";
            this.BTN_Suiv.Size = new System.Drawing.Size(36, 33);
            this.BTN_Suiv.TabIndex = 37;
            this.BTN_Suiv.UseVisualStyleBackColor = false;
            this.BTN_Suiv.Visible = false;
            this.BTN_Suiv.Click += new System.EventHandler(this.BTN_Suiv_Click);
            // 
            // BTN_Prec
            // 
            this.BTN_Prec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Prec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Prec.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_Prec.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Prec.Image")));
            this.BTN_Prec.Location = new System.Drawing.Point(236, 370);
            this.BTN_Prec.Name = "BTN_Prec";
            this.BTN_Prec.Size = new System.Drawing.Size(36, 33);
            this.BTN_Prec.TabIndex = 36;
            this.BTN_Prec.UseVisualStyleBackColor = false;
            this.BTN_Prec.Visible = false;
            this.BTN_Prec.Click += new System.EventHandler(this.BTN_Prec_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Frm_Emplacements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1074, 662);
            this.Controls.Add(this.BTN_MAJ);
            this.Controls.Add(this.BTN_Suiv);
            this.Controls.Add(this.BTN_Prec);
            this.Controls.Add(this.BTN_Less);
            this.Controls.Add(this.LBL_Designer);
            this.Controls.Add(this.DTGRD_Emplacements);
            this.Controls.Add(this.BTN_Retour_Menu);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Enregistrer);
            this.Controls.Add(this.GRPBX_Donnees_emplacement);
            this.Controls.Add(this.COMBO_SelectEmplacement);
            this.Controls.Add(this.LBL_SelectEmplacements);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Nouveau);
            this.Controls.Add(this.PICBX_Biblio);
            this.Controls.Add(this.BTN_Details);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Emplacements";
            this.Text = "Gérer les emplacements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Emplacements_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Emplacements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGRD_Emplacements)).EndInit();
            this.GRPBX_Donnees_emplacement.ResumeLayout(false);
            this.GRPBX_Donnees_emplacement.PerformLayout();
            this.GRPBX_Libelle.ResumeLayout(false);
            this.GRPBX_Libelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRC_Rayon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRC_Etage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMRC_Allee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBX_Biblio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Less;
        private System.Windows.Forms.Label LBL_Designer;
        private System.Windows.Forms.DataGridView DTGRD_Emplacements;
        private System.Windows.Forms.Button BTN_Retour_Menu;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Enregistrer;
        private System.Windows.Forms.GroupBox GRPBX_Donnees_emplacement;
        private System.Windows.Forms.ComboBox COMBO_Theme;
        private System.Windows.Forms.Label LBL_Theme;
        private System.Windows.Forms.TextBox TXTBX_CodeTheme;
        private System.Windows.Forms.TextBox TXTBX_CodeEmplacement;
        private System.Windows.Forms.TextBox TXTBX_CodeBiblio;
        private System.Windows.Forms.Label LBL_CodeBiblio;
        private System.Windows.Forms.Label LBL_Etage;
        private System.Windows.Forms.Label LBL_CodeTheme;
        private System.Windows.Forms.Label LBL_CodeEmplacement;
        private System.Windows.Forms.ComboBox COMBO_SelectEmplacement;
        private System.Windows.Forms.Label LBL_SelectEmplacements;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Nouveau;
        private System.Windows.Forms.PictureBox PICBX_Biblio;
        private System.Windows.Forms.Button BTN_Details;
        private System.Windows.Forms.Button BTN_MAJ;
        private System.Windows.Forms.Button BTN_Suiv;
        private System.Windows.Forms.Button BTN_Prec;
        private System.Windows.Forms.GroupBox GRPBX_Libelle;
        private System.Windows.Forms.NumericUpDown NUMRC_Rayon;
        private System.Windows.Forms.NumericUpDown NUMRC_Etage;
        private System.Windows.Forms.Label LBL_Rayon;
        private System.Windows.Forms.Label LBL_Allee;
        private System.Windows.Forms.NumericUpDown NUMRC_Allee;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}