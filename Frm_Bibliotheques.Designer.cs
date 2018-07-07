namespace WindowsFormsApplication1
{
    partial class Frm_Bibliotheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bibliotheques));
            this.BTN_Less = new System.Windows.Forms.Button();
            this.LBL_Designer = new System.Windows.Forms.Label();
            this.DTGRD_Biblio = new System.Windows.Forms.DataGridView();
            this.BTN_Retour_Menu = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Enregistrer = new System.Windows.Forms.Button();
            this.GRPBX_Données_Bibliothèque = new System.Windows.Forms.GroupBox();
            this.PICBX_Biblio = new System.Windows.Forms.PictureBox();
            this.TXTBX_Ville = new System.Windows.Forms.TextBox();
            this.TXTBX_CodePostal = new System.Windows.Forms.TextBox();
            this.TXTBX_Adresse = new System.Windows.Forms.TextBox();
            this.TXTBX_Libelle = new System.Windows.Forms.TextBox();
            this.TXTBX_CodeBiblio = new System.Windows.Forms.TextBox();
            this.LBL_CodeBiblio = new System.Windows.Forms.Label();
            this.LBL_Ville = new System.Windows.Forms.Label();
            this.LBL_CodePostal = new System.Windows.Forms.Label();
            this.LBL_Adresse = new System.Windows.Forms.Label();
            this.LBL_Libelle = new System.Windows.Forms.Label();
            this.COMBO_SelectBiblio = new System.Windows.Forms.ComboBox();
            this.LBL_SelectBiblio = new System.Windows.Forms.Label();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Nouveau = new System.Windows.Forms.Button();
            this.BTN_Details = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTN_Suiv = new System.Windows.Forms.Button();
            this.BTN_Prec = new System.Windows.Forms.Button();
            this.BTN_MAJ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGRD_Biblio)).BeginInit();
            this.GRPBX_Données_Bibliothèque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBX_Biblio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Less
            // 
            this.BTN_Less.Location = new System.Drawing.Point(146, 373);
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
            this.LBL_Designer.Location = new System.Drawing.Point(973, 637);
            this.LBL_Designer.Name = "LBL_Designer";
            this.LBL_Designer.Size = new System.Drawing.Size(77, 13);
            this.LBL_Designer.TabIndex = 30;
            this.LBL_Designer.Text = "Fanny Alliaume";
            // 
            // DTGRD_Biblio
            // 
            this.DTGRD_Biblio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTGRD_Biblio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGRD_Biblio.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DTGRD_Biblio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGRD_Biblio.Location = new System.Drawing.Point(27, 433);
            this.DTGRD_Biblio.Name = "DTGRD_Biblio";
            this.DTGRD_Biblio.Size = new System.Drawing.Size(1023, 197);
            this.DTGRD_Biblio.TabIndex = 29;
            this.DTGRD_Biblio.Visible = false;
            this.DTGRD_Biblio.SelectionChanged += new System.EventHandler(this.COMBO_SelectBiblio_SelectedIndexChanged);
            // 
            // BTN_Retour_Menu
            // 
            this.BTN_Retour_Menu.Location = new System.Drawing.Point(27, 373);
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
            this.BTN_Annuler.Location = new System.Drawing.Point(940, 373);
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
            this.BTN_Enregistrer.Location = new System.Drawing.Point(796, 373);
            this.BTN_Enregistrer.Name = "BTN_Enregistrer";
            this.BTN_Enregistrer.Size = new System.Drawing.Size(110, 33);
            this.BTN_Enregistrer.TabIndex = 26;
            this.BTN_Enregistrer.Text = "Enregistrer";
            this.BTN_Enregistrer.UseVisualStyleBackColor = false;
            this.BTN_Enregistrer.Visible = false;
            this.BTN_Enregistrer.Click += new System.EventHandler(this.BTN_Enregistrer_Click);
            // 
            // GRPBX_Données_Bibliothèque
            // 
            this.GRPBX_Données_Bibliothèque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRPBX_Données_Bibliothèque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.PICBX_Biblio);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.TXTBX_Ville);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.TXTBX_CodePostal);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.TXTBX_Adresse);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.TXTBX_Libelle);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.TXTBX_CodeBiblio);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.LBL_CodeBiblio);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.LBL_Ville);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.LBL_CodePostal);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.LBL_Adresse);
            this.GRPBX_Données_Bibliothèque.Controls.Add(this.LBL_Libelle);
            this.GRPBX_Données_Bibliothèque.ForeColor = System.Drawing.Color.Black;
            this.GRPBX_Données_Bibliothèque.Location = new System.Drawing.Point(27, 126);
            this.GRPBX_Données_Bibliothèque.Name = "GRPBX_Données_Bibliothèque";
            this.GRPBX_Données_Bibliothèque.Size = new System.Drawing.Size(1023, 207);
            this.GRPBX_Données_Bibliothèque.TabIndex = 25;
            this.GRPBX_Données_Bibliothèque.TabStop = false;
            this.GRPBX_Données_Bibliothèque.Text = "Données de la bibliothèque";
            this.GRPBX_Données_Bibliothèque.Visible = false;
            // 
            // PICBX_Biblio
            // 
            this.PICBX_Biblio.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M;
            this.PICBX_Biblio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PICBX_Biblio.Location = new System.Drawing.Point(839, 33);
            this.PICBX_Biblio.Name = "PICBX_Biblio";
            this.PICBX_Biblio.Size = new System.Drawing.Size(160, 152);
            this.PICBX_Biblio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBX_Biblio.TabIndex = 11;
            this.PICBX_Biblio.TabStop = false;
            // 
            // TXTBX_Ville
            // 
            this.TXTBX_Ville.Location = new System.Drawing.Point(522, 167);
            this.TXTBX_Ville.MaxLength = 20;
            this.TXTBX_Ville.Name = "TXTBX_Ville";
            this.TXTBX_Ville.Size = new System.Drawing.Size(245, 26);
            this.TXTBX_Ville.TabIndex = 10;
            this.TXTBX_Ville.TextChanged += new System.EventHandler(this.TXTBX_Ville_TextChanged);
            // 
            // TXTBX_CodePostal
            // 
            this.TXTBX_CodePostal.Location = new System.Drawing.Point(208, 167);
            this.TXTBX_CodePostal.MaxLength = 5;
            this.TXTBX_CodePostal.Name = "TXTBX_CodePostal";
            this.TXTBX_CodePostal.Size = new System.Drawing.Size(209, 26);
            this.TXTBX_CodePostal.TabIndex = 9;
            // 
            // TXTBX_Adresse
            // 
            this.TXTBX_Adresse.Location = new System.Drawing.Point(208, 124);
            this.TXTBX_Adresse.MaxLength = 50;
            this.TXTBX_Adresse.Name = "TXTBX_Adresse";
            this.TXTBX_Adresse.Size = new System.Drawing.Size(559, 26);
            this.TXTBX_Adresse.TabIndex = 8;
            this.TXTBX_Adresse.TextChanged += new System.EventHandler(this.TXTBX_Adresse_TextChanged);
            // 
            // TXTBX_Libelle
            // 
            this.TXTBX_Libelle.Location = new System.Drawing.Point(208, 80);
            this.TXTBX_Libelle.MaxLength = 50;
            this.TXTBX_Libelle.Name = "TXTBX_Libelle";
            this.TXTBX_Libelle.Size = new System.Drawing.Size(559, 26);
            this.TXTBX_Libelle.TabIndex = 6;
            this.TXTBX_Libelle.TextChanged += new System.EventHandler(this.TXTBX_Libelle_TextChanged);
            // 
            // TXTBX_CodeBiblio
            // 
            this.TXTBX_CodeBiblio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TXTBX_CodeBiblio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXTBX_CodeBiblio.Location = new System.Drawing.Point(208, 39);
            this.TXTBX_CodeBiblio.MaxLength = 5;
            this.TXTBX_CodeBiblio.Name = "TXTBX_CodeBiblio";
            this.TXTBX_CodeBiblio.Size = new System.Drawing.Size(209, 26);
            this.TXTBX_CodeBiblio.TabIndex = 5;
            // 
            // LBL_CodeBiblio
            // 
            this.LBL_CodeBiblio.AutoSize = true;
            this.LBL_CodeBiblio.Location = new System.Drawing.Point(28, 42);
            this.LBL_CodeBiblio.Name = "LBL_CodeBiblio";
            this.LBL_CodeBiblio.Size = new System.Drawing.Size(120, 18);
            this.LBL_CodeBiblio.TabIndex = 4;
            this.LBL_CodeBiblio.Text = "Code Bibliothèque";
            this.LBL_CodeBiblio.UseWaitCursor = true;
            // 
            // LBL_Ville
            // 
            this.LBL_Ville.AutoSize = true;
            this.LBL_Ville.Location = new System.Drawing.Point(483, 171);
            this.LBL_Ville.Name = "LBL_Ville";
            this.LBL_Ville.Size = new System.Drawing.Size(33, 18);
            this.LBL_Ville.TabIndex = 3;
            this.LBL_Ville.Text = "Ville";
            this.LBL_Ville.UseWaitCursor = true;
            // 
            // LBL_CodePostal
            // 
            this.LBL_CodePostal.AutoSize = true;
            this.LBL_CodePostal.Location = new System.Drawing.Point(28, 171);
            this.LBL_CodePostal.Name = "LBL_CodePostal";
            this.LBL_CodePostal.Size = new System.Drawing.Size(80, 18);
            this.LBL_CodePostal.TabIndex = 2;
            this.LBL_CodePostal.Text = "Code postal";
            this.LBL_CodePostal.UseWaitCursor = true;
            // 
            // LBL_Adresse
            // 
            this.LBL_Adresse.AutoSize = true;
            this.LBL_Adresse.Location = new System.Drawing.Point(28, 128);
            this.LBL_Adresse.Name = "LBL_Adresse";
            this.LBL_Adresse.Size = new System.Drawing.Size(57, 18);
            this.LBL_Adresse.TabIndex = 1;
            this.LBL_Adresse.Text = "Adresse";
            this.LBL_Adresse.UseWaitCursor = true;
            // 
            // LBL_Libelle
            // 
            this.LBL_Libelle.AutoSize = true;
            this.LBL_Libelle.Location = new System.Drawing.Point(28, 84);
            this.LBL_Libelle.Name = "LBL_Libelle";
            this.LBL_Libelle.Size = new System.Drawing.Size(47, 18);
            this.LBL_Libelle.TabIndex = 0;
            this.LBL_Libelle.Text = "Libellé";
            this.LBL_Libelle.UseWaitCursor = true;
            // 
            // COMBO_SelectBiblio
            // 
            this.COMBO_SelectBiblio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMBO_SelectBiblio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMBO_SelectBiblio.FormattingEnabled = true;
            this.COMBO_SelectBiblio.Items.AddRange(new object[] {
            "Bibli 1",
            "Bibli 2",
            "Bibli 3"});
            this.COMBO_SelectBiblio.Location = new System.Drawing.Point(235, 67);
            this.COMBO_SelectBiblio.Name = "COMBO_SelectBiblio";
            this.COMBO_SelectBiblio.Size = new System.Drawing.Size(209, 26);
            this.COMBO_SelectBiblio.TabIndex = 24;
            this.COMBO_SelectBiblio.SelectedIndexChanged += new System.EventHandler(this.COMBO_SelectBiblio_SelectedIndexChanged);
            // 
            // LBL_SelectBiblio
            // 
            this.LBL_SelectBiblio.AutoSize = true;
            this.LBL_SelectBiblio.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SelectBiblio.Location = new System.Drawing.Point(24, 71);
            this.LBL_SelectBiblio.Name = "LBL_SelectBiblio";
            this.LBL_SelectBiblio.Size = new System.Drawing.Size(205, 18);
            this.LBL_SelectBiblio.TabIndex = 23;
            this.LBL_SelectBiblio.Text = "Sélectionnez une bibliothèque";
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Supprimer.Location = new System.Drawing.Point(940, 63);
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
            this.BTN_Modifier.Location = new System.Drawing.Point(796, 63);
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
            this.BTN_Nouveau.Location = new System.Drawing.Point(668, 63);
            this.BTN_Nouveau.Name = "BTN_Nouveau";
            this.BTN_Nouveau.Size = new System.Drawing.Size(110, 33);
            this.BTN_Nouveau.TabIndex = 20;
            this.BTN_Nouveau.Text = "Nouveau";
            this.BTN_Nouveau.UseVisualStyleBackColor = false;
            this.BTN_Nouveau.Click += new System.EventHandler(this.BTN_Nouveau_Click);
            // 
            // BTN_Details
            // 
            this.BTN_Details.Location = new System.Drawing.Point(146, 373);
            this.BTN_Details.Name = "BTN_Details";
            this.BTN_Details.Size = new System.Drawing.Size(36, 33);
            this.BTN_Details.TabIndex = 32;
            this.BTN_Details.Text = "+";
            this.BTN_Details.UseVisualStyleBackColor = true;
            this.BTN_Details.Visible = false;
            this.BTN_Details.Click += new System.EventHandler(this.BTN_Details_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BTN_Suiv
            // 
            this.BTN_Suiv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Suiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Suiv.ForeColor = System.Drawing.Color.White;
            this.BTN_Suiv.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Suiv.Image")));
            this.BTN_Suiv.Location = new System.Drawing.Point(273, 373);
            this.BTN_Suiv.Name = "BTN_Suiv";
            this.BTN_Suiv.Size = new System.Drawing.Size(36, 33);
            this.BTN_Suiv.TabIndex = 34;
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
            this.BTN_Prec.Location = new System.Drawing.Point(235, 373);
            this.BTN_Prec.Name = "BTN_Prec";
            this.BTN_Prec.Size = new System.Drawing.Size(36, 33);
            this.BTN_Prec.TabIndex = 33;
            this.BTN_Prec.UseVisualStyleBackColor = false;
            this.BTN_Prec.Visible = false;
            this.BTN_Prec.Click += new System.EventHandler(this.BTN_Prec_Click);
            // 
            // BTN_MAJ
            // 
            this.BTN_MAJ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_MAJ.BackgroundImage")));
            this.BTN_MAJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_MAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MAJ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_MAJ.Location = new System.Drawing.Point(188, 373);
            this.BTN_MAJ.Name = "BTN_MAJ";
            this.BTN_MAJ.Size = new System.Drawing.Size(41, 34);
            this.BTN_MAJ.TabIndex = 35;
            this.BTN_MAJ.UseVisualStyleBackColor = true;
            this.BTN_MAJ.Visible = false;
            this.BTN_MAJ.Click += new System.EventHandler(this.BTN_MAJ_Click);
            // 
            // Frm_Bibliotheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1076, 657);
            this.Controls.Add(this.BTN_MAJ);
            this.Controls.Add(this.BTN_Suiv);
            this.Controls.Add(this.BTN_Prec);
            this.Controls.Add(this.BTN_Less);
            this.Controls.Add(this.LBL_Designer);
            this.Controls.Add(this.DTGRD_Biblio);
            this.Controls.Add(this.BTN_Retour_Menu);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Enregistrer);
            this.Controls.Add(this.GRPBX_Données_Bibliothèque);
            this.Controls.Add(this.COMBO_SelectBiblio);
            this.Controls.Add(this.LBL_SelectBiblio);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Nouveau);
            this.Controls.Add(this.BTN_Details);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Bibliotheques";
            this.Text = "Gérer les Bibliotheques";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Bibliotheques_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Bibliotheques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGRD_Biblio)).EndInit();
            this.GRPBX_Données_Bibliothèque.ResumeLayout(false);
            this.GRPBX_Données_Bibliothèque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBX_Biblio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Less;
        private System.Windows.Forms.Label LBL_Designer;
        private System.Windows.Forms.DataGridView DTGRD_Biblio;
        private System.Windows.Forms.Button BTN_Retour_Menu;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Enregistrer;
        private System.Windows.Forms.GroupBox GRPBX_Données_Bibliothèque;
        private System.Windows.Forms.PictureBox PICBX_Biblio;
        private System.Windows.Forms.TextBox TXTBX_Ville;
        private System.Windows.Forms.TextBox TXTBX_CodePostal;
        private System.Windows.Forms.TextBox TXTBX_Adresse;
        private System.Windows.Forms.TextBox TXTBX_Libelle;
        private System.Windows.Forms.TextBox TXTBX_CodeBiblio;
        private System.Windows.Forms.Label LBL_CodeBiblio;
        private System.Windows.Forms.Label LBL_Ville;
        private System.Windows.Forms.Label LBL_CodePostal;
        private System.Windows.Forms.Label LBL_Adresse;
        private System.Windows.Forms.Label LBL_Libelle;
        private System.Windows.Forms.ComboBox COMBO_SelectBiblio;
        private System.Windows.Forms.Label LBL_SelectBiblio;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Nouveau;
        private System.Windows.Forms.Button BTN_Details;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button BTN_Suiv;
        private System.Windows.Forms.Button BTN_Prec;
        private System.Windows.Forms.Button BTN_MAJ;
    }
}