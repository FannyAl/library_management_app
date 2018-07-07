namespace WindowsFormsApplication1
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.MENU_Principal = new System.Windows.Forms.MenuStrip();
            this.TLSTRP_CMBBX_SelectBibli = new System.Windows.Forms.ToolStripComboBox();
            this.consulterLesFondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prêtRetourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesEmpruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesRetoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adherentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEmplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliothèqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU_Principal
            // 
            this.MENU_Principal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MENU_Principal.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU_Principal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MENU_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TLSTRP_CMBBX_SelectBibli,
            this.consulterLesFondsToolStripMenuItem,
            this.prêtRetourToolStripMenuItem,
            this.adherentsToolStripMenuItem,
            this.gestionEmplacementToolStripMenuItem,
            this.bibliothèqueToolStripMenuItem,
            this.fenêtreToolStripMenuItem,
            this.déconnectionToolStripMenuItem,
            this.connexionToolStripMenuItem});
            this.MENU_Principal.Location = new System.Drawing.Point(0, 0);
            this.MENU_Principal.MdiWindowListItem = this.fenêtreToolStripMenuItem;
            this.MENU_Principal.Name = "MENU_Principal";
            this.MENU_Principal.Size = new System.Drawing.Size(1079, 30);
            this.MENU_Principal.TabIndex = 0;
            this.MENU_Principal.Text = "menuStrip1";
            // 
            // TLSTRP_CMBBX_SelectBibli
            // 
            this.TLSTRP_CMBBX_SelectBibli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TLSTRP_CMBBX_SelectBibli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TLSTRP_CMBBX_SelectBibli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TLSTRP_CMBBX_SelectBibli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TLSTRP_CMBBX_SelectBibli.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLSTRP_CMBBX_SelectBibli.ForeColor = System.Drawing.Color.Black;
            this.TLSTRP_CMBBX_SelectBibli.Name = "TLSTRP_CMBBX_SelectBibli";
            this.TLSTRP_CMBBX_SelectBibli.Size = new System.Drawing.Size(220, 26);
            this.TLSTRP_CMBBX_SelectBibli.Text = " Select Biblio";
            this.TLSTRP_CMBBX_SelectBibli.Click += new System.EventHandler(this.TLSTRP_CMBBX_SelectBibli_Click);
            // 
            // consulterLesFondsToolStripMenuItem
            // 
            this.consulterLesFondsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consulterLesFondsToolStripMenuItem.Image")));
            this.consulterLesFondsToolStripMenuItem.Name = "consulterLesFondsToolStripMenuItem";
            this.consulterLesFondsToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.consulterLesFondsToolStripMenuItem.Text = "Consulter le fonds";
            this.consulterLesFondsToolStripMenuItem.Click += new System.EventHandler(this.consulterLesFondsToolStripMenuItem_Click);
            // 
            // prêtRetourToolStripMenuItem
            // 
            this.prêtRetourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesEmpruntsToolStripMenuItem,
            this.gérerLesRetoursToolStripMenuItem});
            this.prêtRetourToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prêtRetourToolStripMenuItem.Image")));
            this.prêtRetourToolStripMenuItem.Name = "prêtRetourToolStripMenuItem";
            this.prêtRetourToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.prêtRetourToolStripMenuItem.Text = "Prêts";
            // 
            // gérerLesEmpruntsToolStripMenuItem
            // 
            this.gérerLesEmpruntsToolStripMenuItem.Name = "gérerLesEmpruntsToolStripMenuItem";
            this.gérerLesEmpruntsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gérerLesEmpruntsToolStripMenuItem.Text = "Gérer les emprunts";
            this.gérerLesEmpruntsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesEmpruntsToolStripMenuItem_Click);
            // 
            // gérerLesRetoursToolStripMenuItem
            // 
            this.gérerLesRetoursToolStripMenuItem.Name = "gérerLesRetoursToolStripMenuItem";
            this.gérerLesRetoursToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gérerLesRetoursToolStripMenuItem.Text = "Gérer les retours";
            this.gérerLesRetoursToolStripMenuItem.Click += new System.EventHandler(this.gérerLesRetoursToolStripMenuItem_Click);
            // 
            // adherentsToolStripMenuItem
            // 
            this.adherentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adherentsToolStripMenuItem.Image")));
            this.adherentsToolStripMenuItem.Name = "adherentsToolStripMenuItem";
            this.adherentsToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.adherentsToolStripMenuItem.Text = "Adhérents";
            this.adherentsToolStripMenuItem.Click += new System.EventHandler(this.gestionLivreToolStripMenuItem_Click);
            // 
            // gestionEmplacementToolStripMenuItem
            // 
            this.gestionEmplacementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionEmplacementToolStripMenuItem.Image")));
            this.gestionEmplacementToolStripMenuItem.Name = "gestionEmplacementToolStripMenuItem";
            this.gestionEmplacementToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.gestionEmplacementToolStripMenuItem.Text = "Emplacements";
            this.gestionEmplacementToolStripMenuItem.Click += new System.EventHandler(this.gestionEmplacementToolStripMenuItem_Click);
            // 
            // bibliothèqueToolStripMenuItem
            // 
            this.bibliothèqueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bibliothèqueToolStripMenuItem.Image")));
            this.bibliothèqueToolStripMenuItem.Name = "bibliothèqueToolStripMenuItem";
            this.bibliothèqueToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.bibliothèqueToolStripMenuItem.Text = "Bibliothèques";
            this.bibliothèqueToolStripMenuItem.Click += new System.EventHandler(this.bibliothèqueToolStripMenuItem_Click);
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fenêtreToolStripMenuItem.Image")));
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.fenêtreToolStripMenuItem.Text = "Fenêtre";
            // 
            // déconnectionToolStripMenuItem
            // 
            this.déconnectionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.déconnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("déconnectionToolStripMenuItem.Image")));
            this.déconnectionToolStripMenuItem.Name = "déconnectionToolStripMenuItem";
            this.déconnectionToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.déconnectionToolStripMenuItem.Text = "Déconnexion";
            this.déconnectionToolStripMenuItem.Click += new System.EventHandler(this.déconnectionToolStripMenuItem_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.connexionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connexionToolStripMenuItem.Image")));
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 682);
            this.Controls.Add(this.MENU_Principal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MENU_Principal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1095, 720);
            this.MinimumSize = new System.Drawing.Size(1022, 720);
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.MENU_Principal.ResumeLayout(false);
            this.MENU_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENU_Principal;
        private System.Windows.Forms.ToolStripMenuItem consulterLesFondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prêtRetourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adherentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEmplacementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliothèqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesEmpruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesRetoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox TLSTRP_CMBBX_SelectBibli;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;

    }
}