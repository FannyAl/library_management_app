namespace WindowsFormsApplication1
{
    partial class Frm_Gerer_les_adherents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gerer_les_adherents));
            this.btn_abondon = new System.Windows.Forms.Button();
            this.grpbox_actions = new System.Windows.Forms.GroupBox();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.grpbox_enreg_effacer = new System.Windows.Forms.GroupBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpbox_infos = new System.Windows.Forms.GroupBox();
            this.txtbox_motdepasse = new System.Windows.Forms.TextBox();
            this.txtbox_codepostal = new System.Windows.Forms.TextBox();
            this.lab_motdepasse = new System.Windows.Forms.Label();
            this.lab_codepostal_adherent_creation = new System.Windows.Forms.Label();
            this.lab_ville_adherent_creation = new System.Windows.Forms.Label();
            this.lab_perimele = new System.Windows.Forms.Label();
            this.DTPicker_perime_le = new System.Windows.Forms.DateTimePicker();
            this.lab_telephone_adherent_creation = new System.Windows.Forms.Label();
            this.txtbox_numadherent = new System.Windows.Forms.TextBox();
            this.txtbox_adresse = new System.Windows.Forms.TextBox();
            this.txtbox_ville = new System.Windows.Forms.TextBox();
            this.numerUpD_numderue = new System.Windows.Forms.NumericUpDown();
            this.lab_numadherent_creation = new System.Windows.Forms.Label();
            this.txtbox_prenom = new System.Windows.Forms.TextBox();
            this.lab_adressemail_adherent_creation = new System.Windows.Forms.Label();
            this.txtbox_nom = new System.Windows.Forms.TextBox();
            this.lab_nom_adherent_creation = new System.Windows.Forms.Label();
            this.txtbox_telephone = new System.Windows.Forms.TextBox();
            this.lab_prenom_adherent_creation = new System.Windows.Forms.Label();
            this.txtbox_adr_mail = new System.Windows.Forms.TextBox();
            this.lab_numderue_adherent_creation = new System.Windows.Forms.Label();
            this.lab_adresse_adherent_creation = new System.Windows.Forms.Label();
            this.grpbox_recherche = new System.Windows.Forms.GroupBox();
            this.txtbox_rechercher = new System.Windows.Forms.TextBox();
            this.datagridview_adherents = new System.Windows.Forms.DataGridView();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.rdbtn_par_num_adh = new System.Windows.Forms.RadioButton();
            this.rdbtn_par_nom = new System.Windows.Forms.RadioButton();
            this.rdbtn_tous_les_adh = new System.Windows.Forms.RadioButton();
            this.grpbox_actions.SuspendLayout();
            this.grpbox_enreg_effacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbox_infos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerUpD_numderue)).BeginInit();
            this.grpbox_recherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_adherents)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_abondon
            // 
            this.btn_abondon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_abondon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_abondon.Location = new System.Drawing.Point(915, 603);
            this.btn_abondon.Name = "btn_abondon";
            this.btn_abondon.Size = new System.Drawing.Size(110, 33);
            this.btn_abondon.TabIndex = 22;
            this.btn_abondon.Text = "Abandon";
            this.btn_abondon.UseVisualStyleBackColor = false;
            this.btn_abondon.Visible = false;
            this.btn_abondon.Click += new System.EventHandler(this.btn_abondon_Click);
            // 
            // grpbox_actions
            // 
            this.grpbox_actions.Controls.Add(this.btn_nouveau);
            this.grpbox_actions.Controls.Add(this.btn_modifier);
            this.grpbox_actions.Controls.Add(this.btn_supprimer);
            this.grpbox_actions.Location = new System.Drawing.Point(606, 45);
            this.grpbox_actions.Name = "grpbox_actions";
            this.grpbox_actions.Size = new System.Drawing.Size(441, 73);
            this.grpbox_actions.TabIndex = 40;
            this.grpbox_actions.TabStop = false;
            this.grpbox_actions.Text = "Actions";
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_nouveau.Location = new System.Drawing.Point(29, 25);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(110, 33);
            this.btn_nouveau.TabIndex = 1;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = false;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_modifier.Location = new System.Drawing.Point(157, 25);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(110, 33);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_supprimer.Location = new System.Drawing.Point(301, 25);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(110, 33);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            // 
            // grpbox_enreg_effacer
            // 
            this.grpbox_enreg_effacer.Controls.Add(this.btn_enregistrer);
            this.grpbox_enreg_effacer.Controls.Add(this.btn_effacer);
            this.grpbox_enreg_effacer.Enabled = false;
            this.grpbox_enreg_effacer.Location = new System.Drawing.Point(587, 585);
            this.grpbox_enreg_effacer.Name = "grpbox_enreg_effacer";
            this.grpbox_enreg_effacer.Size = new System.Drawing.Size(322, 66);
            this.grpbox_enreg_effacer.TabIndex = 39;
            this.grpbox_enreg_effacer.TabStop = false;
            this.grpbox_enreg_effacer.Visible = false;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_enregistrer.Location = new System.Drawing.Point(35, 18);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(110, 33);
            this.btn_enregistrer.TabIndex = 20;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_effacer
            // 
            this.btn_effacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_effacer.Location = new System.Drawing.Point(179, 18);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(110, 33);
            this.btn_effacer.TabIndex = 21;
            this.btn_effacer.Text = "Effacer";
            this.btn_effacer.UseVisualStyleBackColor = false;
            this.btn_effacer.Click += new System.EventHandler(this.bnt_effacer_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(35, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Bangaly Fofana";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Img_petit_service_culturel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(32, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // grpbox_infos
            // 
            this.grpbox_infos.Controls.Add(this.txtbox_motdepasse);
            this.grpbox_infos.Controls.Add(this.txtbox_codepostal);
            this.grpbox_infos.Controls.Add(this.lab_motdepasse);
            this.grpbox_infos.Controls.Add(this.lab_codepostal_adherent_creation);
            this.grpbox_infos.Controls.Add(this.lab_ville_adherent_creation);
            this.grpbox_infos.Controls.Add(this.lab_perimele);
            this.grpbox_infos.Controls.Add(this.DTPicker_perime_le);
            this.grpbox_infos.Controls.Add(this.lab_telephone_adherent_creation);
            this.grpbox_infos.Controls.Add(this.txtbox_numadherent);
            this.grpbox_infos.Controls.Add(this.txtbox_adresse);
            this.grpbox_infos.Controls.Add(this.txtbox_ville);
            this.grpbox_infos.Controls.Add(this.numerUpD_numderue);
            this.grpbox_infos.Controls.Add(this.lab_numadherent_creation);
            this.grpbox_infos.Controls.Add(this.txtbox_prenom);
            this.grpbox_infos.Controls.Add(this.lab_adressemail_adherent_creation);
            this.grpbox_infos.Controls.Add(this.txtbox_nom);
            this.grpbox_infos.Controls.Add(this.lab_nom_adherent_creation);
            this.grpbox_infos.Controls.Add(this.txtbox_telephone);
            this.grpbox_infos.Controls.Add(this.lab_prenom_adherent_creation);
            this.grpbox_infos.Controls.Add(this.txtbox_adr_mail);
            this.grpbox_infos.Controls.Add(this.lab_numderue_adherent_creation);
            this.grpbox_infos.Controls.Add(this.lab_adresse_adherent_creation);
            this.grpbox_infos.Enabled = false;
            this.grpbox_infos.Location = new System.Drawing.Point(32, 405);
            this.grpbox_infos.Name = "grpbox_infos";
            this.grpbox_infos.Size = new System.Drawing.Size(1015, 176);
            this.grpbox_infos.TabIndex = 36;
            this.grpbox_infos.TabStop = false;
            this.grpbox_infos.Text = "Coordonnées de l\'adhérent";
            // 
            // txtbox_motdepasse
            // 
            this.txtbox_motdepasse.Location = new System.Drawing.Point(761, 106);
            this.txtbox_motdepasse.MaxLength = 10;
            this.txtbox_motdepasse.Name = "txtbox_motdepasse";
            this.txtbox_motdepasse.Size = new System.Drawing.Size(232, 26);
            this.txtbox_motdepasse.TabIndex = 17;
            // 
            // txtbox_codepostal
            // 
            this.txtbox_codepostal.Location = new System.Drawing.Point(67, 103);
            this.txtbox_codepostal.MaxLength = 5;
            this.txtbox_codepostal.Name = "txtbox_codepostal";
            this.txtbox_codepostal.Size = new System.Drawing.Size(120, 26);
            this.txtbox_codepostal.TabIndex = 15;
            this.txtbox_codepostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_codepostal_KeyPress);
            // 
            // lab_motdepasse
            // 
            this.lab_motdepasse.AutoSize = true;
            this.lab_motdepasse.Location = new System.Drawing.Point(656, 110);
            this.lab_motdepasse.Name = "lab_motdepasse";
            this.lab_motdepasse.Size = new System.Drawing.Size(96, 18);
            this.lab_motdepasse.TabIndex = 17;
            this.lab_motdepasse.Text = "Mot de Passe :";
            // 
            // lab_codepostal_adherent_creation
            // 
            this.lab_codepostal_adherent_creation.AutoSize = true;
            this.lab_codepostal_adherent_creation.Location = new System.Drawing.Point(16, 107);
            this.lab_codepostal_adherent_creation.Name = "lab_codepostal_adherent_creation";
            this.lab_codepostal_adherent_creation.Size = new System.Drawing.Size(33, 18);
            this.lab_codepostal_adherent_creation.TabIndex = 4;
            this.lab_codepostal_adherent_creation.Text = "CP :";
            // 
            // lab_ville_adherent_creation
            // 
            this.lab_ville_adherent_creation.AutoSize = true;
            this.lab_ville_adherent_creation.Location = new System.Drawing.Point(209, 107);
            this.lab_ville_adherent_creation.Name = "lab_ville_adherent_creation";
            this.lab_ville_adherent_creation.Size = new System.Drawing.Size(40, 18);
            this.lab_ville_adherent_creation.TabIndex = 5;
            this.lab_ville_adherent_creation.Text = "Ville :";
            // 
            // lab_perimele
            // 
            this.lab_perimele.AutoSize = true;
            this.lab_perimele.Location = new System.Drawing.Point(656, 71);
            this.lab_perimele.Name = "lab_perimele";
            this.lab_perimele.Size = new System.Drawing.Size(70, 18);
            this.lab_perimele.TabIndex = 16;
            this.lab_perimele.Text = "Perime le :";
            // 
            // DTPicker_perime_le
            // 
            this.DTPicker_perime_le.Location = new System.Drawing.Point(761, 68);
            this.DTPicker_perime_le.Name = "DTPicker_perime_le";
            this.DTPicker_perime_le.Size = new System.Drawing.Size(232, 26);
            this.DTPicker_perime_le.TabIndex = 14;
            // 
            // lab_telephone_adherent_creation
            // 
            this.lab_telephone_adherent_creation.AutoSize = true;
            this.lab_telephone_adherent_creation.Location = new System.Drawing.Point(16, 144);
            this.lab_telephone_adherent_creation.Name = "lab_telephone_adherent_creation";
            this.lab_telephone_adherent_creation.Size = new System.Drawing.Size(32, 18);
            this.lab_telephone_adherent_creation.TabIndex = 6;
            this.lab_telephone_adherent_creation.Text = "Tél :";
            // 
            // txtbox_numadherent
            // 
            this.txtbox_numadherent.Location = new System.Drawing.Point(761, 24);
            this.txtbox_numadherent.MaxLength = 10;
            this.txtbox_numadherent.Name = "txtbox_numadherent";
            this.txtbox_numadherent.Size = new System.Drawing.Size(232, 26);
            this.txtbox_numadherent.TabIndex = 11;
            // 
            // txtbox_adresse
            // 
            this.txtbox_adresse.Location = new System.Drawing.Point(222, 65);
            this.txtbox_adresse.MaxLength = 50;
            this.txtbox_adresse.Name = "txtbox_adresse";
            this.txtbox_adresse.Size = new System.Drawing.Size(333, 26);
            this.txtbox_adresse.TabIndex = 13;
            this.txtbox_adresse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_adresse_KeyPress);
            // 
            // txtbox_ville
            // 
            this.txtbox_ville.Location = new System.Drawing.Point(265, 103);
            this.txtbox_ville.MaxLength = 50;
            this.txtbox_ville.Name = "txtbox_ville";
            this.txtbox_ville.Size = new System.Drawing.Size(290, 26);
            this.txtbox_ville.TabIndex = 16;
            this.txtbox_ville.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_ville_KeyPress);
            // 
            // numerUpD_numderue
            // 
            this.numerUpD_numderue.Location = new System.Drawing.Point(67, 65);
            this.numerUpD_numderue.Name = "numerUpD_numderue";
            this.numerUpD_numderue.Size = new System.Drawing.Size(74, 26);
            this.numerUpD_numderue.TabIndex = 12;
            // 
            // lab_numadherent_creation
            // 
            this.lab_numadherent_creation.AutoSize = true;
            this.lab_numadherent_creation.Location = new System.Drawing.Point(656, 31);
            this.lab_numadherent_creation.Name = "lab_numadherent_creation";
            this.lab_numadherent_creation.Size = new System.Drawing.Size(91, 18);
            this.lab_numadherent_creation.TabIndex = 12;
            this.lab_numadherent_creation.Text = "N° Adhérent :";
            // 
            // txtbox_prenom
            // 
            this.txtbox_prenom.Location = new System.Drawing.Point(357, 28);
            this.txtbox_prenom.MaxLength = 50;
            this.txtbox_prenom.Name = "txtbox_prenom";
            this.txtbox_prenom.Size = new System.Drawing.Size(198, 26);
            this.txtbox_prenom.TabIndex = 10;
            this.txtbox_prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_prenom_KeyPress);
            // 
            // lab_adressemail_adherent_creation
            // 
            this.lab_adressemail_adherent_creation.AutoSize = true;
            this.lab_adressemail_adherent_creation.Location = new System.Drawing.Point(209, 144);
            this.lab_adressemail_adherent_creation.Name = "lab_adressemail_adherent_creation";
            this.lab_adressemail_adherent_creation.Size = new System.Drawing.Size(53, 18);
            this.lab_adressemail_adherent_creation.TabIndex = 7;
            this.lab_adressemail_adherent_creation.Text = "E-mail :";
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.Location = new System.Drawing.Point(67, 29);
            this.txtbox_nom.MaxLength = 50;
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(200, 26);
            this.txtbox_nom.TabIndex = 9;
            this.txtbox_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_nom_KeyPress);
            // 
            // lab_nom_adherent_creation
            // 
            this.lab_nom_adherent_creation.AutoSize = true;
            this.lab_nom_adherent_creation.Location = new System.Drawing.Point(16, 33);
            this.lab_nom_adherent_creation.Name = "lab_nom_adherent_creation";
            this.lab_nom_adherent_creation.Size = new System.Drawing.Size(45, 18);
            this.lab_nom_adherent_creation.TabIndex = 0;
            this.lab_nom_adherent_creation.Text = "Nom :";
            // 
            // txtbox_telephone
            // 
            this.txtbox_telephone.Location = new System.Drawing.Point(67, 140);
            this.txtbox_telephone.MaxLength = 20;
            this.txtbox_telephone.Name = "txtbox_telephone";
            this.txtbox_telephone.Size = new System.Drawing.Size(120, 26);
            this.txtbox_telephone.TabIndex = 18;
            this.txtbox_telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_telephone_KeyPress);
            // 
            // lab_prenom_adherent_creation
            // 
            this.lab_prenom_adherent_creation.AutoSize = true;
            this.lab_prenom_adherent_creation.Location = new System.Drawing.Point(292, 32);
            this.lab_prenom_adherent_creation.Name = "lab_prenom_adherent_creation";
            this.lab_prenom_adherent_creation.Size = new System.Drawing.Size(64, 18);
            this.lab_prenom_adherent_creation.TabIndex = 1;
            this.lab_prenom_adherent_creation.Text = "Prénom :";
            // 
            // txtbox_adr_mail
            // 
            this.txtbox_adr_mail.Location = new System.Drawing.Point(265, 140);
            this.txtbox_adr_mail.MaxLength = 50;
            this.txtbox_adr_mail.Name = "txtbox_adr_mail";
            this.txtbox_adr_mail.Size = new System.Drawing.Size(290, 26);
            this.txtbox_adr_mail.TabIndex = 19;
            // 
            // lab_numderue_adherent_creation
            // 
            this.lab_numderue_adherent_creation.AutoSize = true;
            this.lab_numderue_adherent_creation.Location = new System.Drawing.Point(16, 69);
            this.lab_numderue_adherent_creation.Name = "lab_numderue_adherent_creation";
            this.lab_numderue_adherent_creation.Size = new System.Drawing.Size(34, 18);
            this.lab_numderue_adherent_creation.TabIndex = 2;
            this.lab_numderue_adherent_creation.Text = "N°  :";
            // 
            // lab_adresse_adherent_creation
            // 
            this.lab_adresse_adherent_creation.AutoSize = true;
            this.lab_adresse_adherent_creation.Location = new System.Drawing.Point(158, 69);
            this.lab_adresse_adherent_creation.Name = "lab_adresse_adherent_creation";
            this.lab_adresse_adherent_creation.Size = new System.Drawing.Size(64, 18);
            this.lab_adresse_adherent_creation.TabIndex = 3;
            this.lab_adresse_adherent_creation.Text = "Adresse :";
            // 
            // grpbox_recherche
            // 
            this.grpbox_recherche.Controls.Add(this.txtbox_rechercher);
            this.grpbox_recherche.Controls.Add(this.datagridview_adherents);
            this.grpbox_recherche.Controls.Add(this.btn_rechercher);
            this.grpbox_recherche.Controls.Add(this.rdbtn_par_num_adh);
            this.grpbox_recherche.Controls.Add(this.rdbtn_par_nom);
            this.grpbox_recherche.Controls.Add(this.rdbtn_tous_les_adh);
            this.grpbox_recherche.Location = new System.Drawing.Point(32, 134);
            this.grpbox_recherche.Name = "grpbox_recherche";
            this.grpbox_recherche.Size = new System.Drawing.Size(1015, 265);
            this.grpbox_recherche.TabIndex = 35;
            this.grpbox_recherche.TabStop = false;
            this.grpbox_recherche.Text = "Rechercher un adhérent";
            // 
            // txtbox_rechercher
            // 
            this.txtbox_rechercher.Location = new System.Drawing.Point(581, 32);
            this.txtbox_rechercher.Name = "txtbox_rechercher";
            this.txtbox_rechercher.Size = new System.Drawing.Size(203, 26);
            this.txtbox_rechercher.TabIndex = 7;
            this.txtbox_rechercher.Visible = false;
            // 
            // datagridview_adherents
            // 
            this.datagridview_adherents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_adherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_adherents.Location = new System.Drawing.Point(12, 86);
            this.datagridview_adherents.Name = "datagridview_adherents";
            this.datagridview_adherents.Size = new System.Drawing.Size(1003, 173);
            this.datagridview_adherents.TabIndex = 0;
            this.datagridview_adherents.SelectionChanged += new System.EventHandler(this.datagridview_adherents_SelectionChanged);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(790, 32);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(203, 26);
            this.btn_rechercher.TabIndex = 8;
            this.btn_rechercher.Text = "LANCER LA RECHERCHE";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Visible = false;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // rdbtn_par_num_adh
            // 
            this.rdbtn_par_num_adh.AutoSize = true;
            this.rdbtn_par_num_adh.Location = new System.Drawing.Point(178, 36);
            this.rdbtn_par_num_adh.Name = "rdbtn_par_num_adh";
            this.rdbtn_par_num_adh.Size = new System.Drawing.Size(156, 22);
            this.rdbtn_par_num_adh.TabIndex = 5;
            this.rdbtn_par_num_adh.Text = "Par numéro adhérent";
            this.rdbtn_par_num_adh.UseVisualStyleBackColor = true;
            this.rdbtn_par_num_adh.CheckedChanged += new System.EventHandler(this.rdbtn_par_num_adh_CheckedChanged);
            // 
            // rdbtn_par_nom
            // 
            this.rdbtn_par_nom.AutoSize = true;
            this.rdbtn_par_nom.Location = new System.Drawing.Point(356, 36);
            this.rdbtn_par_nom.Name = "rdbtn_par_nom";
            this.rdbtn_par_nom.Size = new System.Drawing.Size(78, 22);
            this.rdbtn_par_nom.TabIndex = 6;
            this.rdbtn_par_nom.Text = "Par nom";
            this.rdbtn_par_nom.UseVisualStyleBackColor = true;
            this.rdbtn_par_nom.CheckedChanged += new System.EventHandler(this.rdbtn_par_nom_CheckedChanged);
            // 
            // rdbtn_tous_les_adh
            // 
            this.rdbtn_tous_les_adh.AutoSize = true;
            this.rdbtn_tous_les_adh.Location = new System.Drawing.Point(19, 36);
            this.rdbtn_tous_les_adh.Name = "rdbtn_tous_les_adh";
            this.rdbtn_tous_les_adh.Size = new System.Drawing.Size(138, 22);
            this.rdbtn_tous_les_adh.TabIndex = 4;
            this.rdbtn_tous_les_adh.Text = "Tous les adhérents";
            this.rdbtn_tous_les_adh.UseVisualStyleBackColor = true;
            this.rdbtn_tous_les_adh.CheckedChanged += new System.EventHandler(this.rdbtn_tous_les_adh_CheckedChanged);
            // 
            // Frm_Gerer_les_adherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1079, 682);
            this.Controls.Add(this.btn_abondon);
            this.Controls.Add(this.grpbox_actions);
            this.Controls.Add(this.grpbox_enreg_effacer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbox_infos);
            this.Controls.Add(this.grpbox_recherche);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Gerer_les_adherents";
            this.Text = "Gérer les adhérents";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Gerer_les_adherents_Load);
            this.grpbox_actions.ResumeLayout(false);
            this.grpbox_enreg_effacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbox_infos.ResumeLayout(false);
            this.grpbox_infos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerUpD_numderue)).EndInit();
            this.grpbox_recherche.ResumeLayout(false);
            this.grpbox_recherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_adherents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_abondon;
        private System.Windows.Forms.GroupBox grpbox_actions;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.GroupBox grpbox_enreg_effacer;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpbox_infos;
        private System.Windows.Forms.TextBox txtbox_motdepasse;
        private System.Windows.Forms.TextBox txtbox_codepostal;
        private System.Windows.Forms.Label lab_motdepasse;
        private System.Windows.Forms.Label lab_codepostal_adherent_creation;
        private System.Windows.Forms.Label lab_ville_adherent_creation;
        private System.Windows.Forms.Label lab_perimele;
        private System.Windows.Forms.DateTimePicker DTPicker_perime_le;
        private System.Windows.Forms.Label lab_telephone_adherent_creation;
        private System.Windows.Forms.TextBox txtbox_numadherent;
        private System.Windows.Forms.TextBox txtbox_adresse;
        private System.Windows.Forms.TextBox txtbox_ville;
        private System.Windows.Forms.NumericUpDown numerUpD_numderue;
        private System.Windows.Forms.Label lab_numadherent_creation;
        private System.Windows.Forms.TextBox txtbox_prenom;
        private System.Windows.Forms.Label lab_adressemail_adherent_creation;
        private System.Windows.Forms.TextBox txtbox_nom;
        private System.Windows.Forms.Label lab_nom_adherent_creation;
        private System.Windows.Forms.TextBox txtbox_telephone;
        private System.Windows.Forms.Label lab_prenom_adherent_creation;
        private System.Windows.Forms.TextBox txtbox_adr_mail;
        private System.Windows.Forms.Label lab_numderue_adherent_creation;
        private System.Windows.Forms.Label lab_adresse_adherent_creation;
        private System.Windows.Forms.GroupBox grpbox_recherche;
        private System.Windows.Forms.TextBox txtbox_rechercher;
        private System.Windows.Forms.DataGridView datagridview_adherents;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.RadioButton rdbtn_par_num_adh;
        private System.Windows.Forms.RadioButton rdbtn_par_nom;
        private System.Windows.Forms.RadioButton rdbtn_tous_les_adh;


    }
}