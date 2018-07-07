namespace WindowsFormsApplication1
{
    partial class Frm_gerer_les_bibliotheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_gerer_les_bibliotheques));
            this.B_Nouveau = new System.Windows.Forms.Button();
            this.B_Modifier = new System.Windows.Forms.Button();
            this.B_supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Bibliothèque = new System.Windows.Forms.ComboBox();
            this.GB_Données_Bibliothèque = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Effacer = new System.Windows.Forms.Button();
            this.B_Enregistrer = new System.Windows.Forms.Button();
            this.B_Retour_Menu = new System.Windows.Forms.Button();
            this.DG_Bibliothèque = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.B_less = new System.Windows.Forms.Button();
            this.B_détails = new System.Windows.Forms.Button();
            this.GB_Données_Bibliothèque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Bibliothèque)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Nouveau
            // 
            this.B_Nouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.B_Nouveau.Location = new System.Drawing.Point(668, 75);
            this.B_Nouveau.Name = "B_Nouveau";
            this.B_Nouveau.Size = new System.Drawing.Size(110, 33);
            this.B_Nouveau.TabIndex = 0;
            this.B_Nouveau.Text = "Nouveau";
            this.B_Nouveau.UseVisualStyleBackColor = false;
            this.B_Nouveau.Click += new System.EventHandler(this.B_Nouveau_Click);
            // 
            // B_Modifier
            // 
            this.B_Modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.B_Modifier.Location = new System.Drawing.Point(796, 75);
            this.B_Modifier.Name = "B_Modifier";
            this.B_Modifier.Size = new System.Drawing.Size(110, 33);
            this.B_Modifier.TabIndex = 1;
            this.B_Modifier.Text = "Modifier";
            this.B_Modifier.UseVisualStyleBackColor = false;
            this.B_Modifier.Visible = false;
            this.B_Modifier.Click += new System.EventHandler(this.B_Modifier_Click);
            // 
            // B_supprimer
            // 
            this.B_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.B_supprimer.Location = new System.Drawing.Point(940, 75);
            this.B_supprimer.Name = "B_supprimer";
            this.B_supprimer.Size = new System.Drawing.Size(110, 33);
            this.B_supprimer.TabIndex = 2;
            this.B_supprimer.Text = "Supprimer";
            this.B_supprimer.UseVisualStyleBackColor = false;
            this.B_supprimer.Visible = false;
            this.B_supprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sélectionnez une bibliothèque";
            // 
            // comboBox_Bibliothèque
            // 
            this.comboBox_Bibliothèque.FormattingEnabled = true;
            this.comboBox_Bibliothèque.Items.AddRange(new object[] {
            "Bibli 1",
            "Bibli 2",
            "Bibli 3"});
            this.comboBox_Bibliothèque.Location = new System.Drawing.Point(237, 79);
            this.comboBox_Bibliothèque.Name = "comboBox_Bibliothèque";
            this.comboBox_Bibliothèque.Size = new System.Drawing.Size(209, 26);
            this.comboBox_Bibliothèque.TabIndex = 4;
            this.comboBox_Bibliothèque.Text = "Bibliothèque";
            this.comboBox_Bibliothèque.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GB_Données_Bibliothèque
            // 
            this.GB_Données_Bibliothèque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Données_Bibliothèque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GB_Données_Bibliothèque.Controls.Add(this.pictureBox1);
            this.GB_Données_Bibliothèque.Controls.Add(this.textBox5);
            this.GB_Données_Bibliothèque.Controls.Add(this.textBox4);
            this.GB_Données_Bibliothèque.Controls.Add(this.textBox3);
            this.GB_Données_Bibliothèque.Controls.Add(this.textBox2);
            this.GB_Données_Bibliothèque.Controls.Add(this.textBox1);
            this.GB_Données_Bibliothèque.Controls.Add(this.label6);
            this.GB_Données_Bibliothèque.Controls.Add(this.label5);
            this.GB_Données_Bibliothèque.Controls.Add(this.label4);
            this.GB_Données_Bibliothèque.Controls.Add(this.label3);
            this.GB_Données_Bibliothèque.Controls.Add(this.label2);
            this.GB_Données_Bibliothèque.ForeColor = System.Drawing.Color.Black;
            this.GB_Données_Bibliothèque.Location = new System.Drawing.Point(29, 138);
            this.GB_Données_Bibliothèque.Name = "GB_Données_Bibliothèque";
            this.GB_Données_Bibliothèque.Size = new System.Drawing.Size(1021, 207);
            this.GB_Données_Bibliothèque.TabIndex = 5;
            this.GB_Données_Bibliothèque.TabStop = false;
            this.GB_Données_Bibliothèque.Text = "Données de la bibliothèque";
            this.GB_Données_Bibliothèque.Visible = false;
            this.GB_Données_Bibliothèque.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M;
            this.pictureBox1.Location = new System.Drawing.Point(835, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(522, 158);
            this.textBox5.MaxLength = 20;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(245, 26);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(208, 158);
            this.textBox4.MaxLength = 5;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 26);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 115);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(559, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 71);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(559, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(208, 30);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Code Bibliothèque";
            this.label6.UseWaitCursor = true;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ville";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Code postal";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adresse";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Libellé";
            this.label2.UseWaitCursor = true;
            // 
            // B_Effacer
            // 
            this.B_Effacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.B_Effacer.Location = new System.Drawing.Point(940, 385);
            this.B_Effacer.Name = "B_Effacer";
            this.B_Effacer.Size = new System.Drawing.Size(110, 33);
            this.B_Effacer.TabIndex = 7;
            this.B_Effacer.Text = "Annuler";
            this.B_Effacer.UseVisualStyleBackColor = false;
            this.B_Effacer.Visible = false;
            this.B_Effacer.Click += new System.EventHandler(this.button5_Click);
            // 
            // B_Enregistrer
            // 
            this.B_Enregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.B_Enregistrer.Location = new System.Drawing.Point(796, 385);
            this.B_Enregistrer.Name = "B_Enregistrer";
            this.B_Enregistrer.Size = new System.Drawing.Size(110, 33);
            this.B_Enregistrer.TabIndex = 6;
            this.B_Enregistrer.Text = "Enregistrer";
            this.B_Enregistrer.UseVisualStyleBackColor = false;
            this.B_Enregistrer.Visible = false;
            this.B_Enregistrer.Click += new System.EventHandler(this.button6_Click);
            // 
            // B_Retour_Menu
            // 
            this.B_Retour_Menu.Location = new System.Drawing.Point(29, 385);
            this.B_Retour_Menu.Name = "B_Retour_Menu";
            this.B_Retour_Menu.Size = new System.Drawing.Size(110, 33);
            this.B_Retour_Menu.TabIndex = 9;
            this.B_Retour_Menu.Text = "Retour Menu";
            this.B_Retour_Menu.UseVisualStyleBackColor = true;
            this.B_Retour_Menu.Visible = false;
            this.B_Retour_Menu.Click += new System.EventHandler(this.B_Retour_Menu_Click);
            // 
            // DG_Bibliothèque
            // 
            this.DG_Bibliothèque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Bibliothèque.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DG_Bibliothèque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Bibliothèque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DG_Bibliothèque.Location = new System.Drawing.Point(29, 450);
            this.DG_Bibliothèque.Name = "DG_Bibliothèque";
            this.DG_Bibliothèque.Size = new System.Drawing.Size(1021, 197);
            this.DG_Bibliothèque.TabIndex = 11;
            this.DG_Bibliothèque.Visible = false;
            this.DG_Bibliothèque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Bibliothèque_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code Bibliothèque";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Libellé";
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adresse";
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Code Postal";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ville";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(973, 659);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fanny Alliaume";
            // 
            // B_less
            // 
            this.B_less.Location = new System.Drawing.Point(196, 385);
            this.B_less.Name = "B_less";
            this.B_less.Size = new System.Drawing.Size(36, 33);
            this.B_less.TabIndex = 19;
            this.B_less.Text = "-";
            this.B_less.UseVisualStyleBackColor = true;
            this.B_less.Visible = false;
            this.B_less.Click += new System.EventHandler(this.B_less_Click);
            // 
            // B_détails
            // 
            this.B_détails.Location = new System.Drawing.Point(154, 385);
            this.B_détails.Name = "B_détails";
            this.B_détails.Size = new System.Drawing.Size(36, 33);
            this.B_détails.TabIndex = 20;
            this.B_détails.Text = "+";
            this.B_détails.UseVisualStyleBackColor = true;
            this.B_détails.Visible = false;
            this.B_détails.Click += new System.EventHandler(this.B_détails_Click);
            // 
            // Frm_gerer_les_bibliotheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1079, 682);
            this.Controls.Add(this.B_less);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DG_Bibliothèque);
            this.Controls.Add(this.B_Retour_Menu);
            this.Controls.Add(this.B_Effacer);
            this.Controls.Add(this.B_Enregistrer);
            this.Controls.Add(this.GB_Données_Bibliothèque);
            this.Controls.Add(this.comboBox_Bibliothèque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_supprimer);
            this.Controls.Add(this.B_Modifier);
            this.Controls.Add(this.B_Nouveau);
            this.Controls.Add(this.B_détails);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_gerer_les_bibliotheques";
            this.Text = "Gérer les bibliothèques";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_gerer_les_bibliotheques_Load);
            this.GB_Données_Bibliothèque.ResumeLayout(false);
            this.GB_Données_Bibliothèque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Bibliothèque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Nouveau;
        private System.Windows.Forms.Button B_Modifier;
        private System.Windows.Forms.Button B_supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Bibliothèque;
        private System.Windows.Forms.GroupBox GB_Données_Bibliothèque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Effacer;
        private System.Windows.Forms.Button B_Enregistrer;
        private System.Windows.Forms.Button B_Retour_Menu;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DG_Bibliothèque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button B_less;
        private System.Windows.Forms.Button B_détails;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}