namespace WindowsFormsApplication1
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.TXTBX_identifiant = new System.Windows.Forms.TextBox();
            this.LBL_identifiant = new System.Windows.Forms.Label();
            this.TXTBX_motDePasse = new System.Windows.Forms.TextBox();
            this.LBL_motDePasse = new System.Windows.Forms.Label();
            this.BTN_Seconnecter = new System.Windows.Forms.Button();
            this.PCTBX_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCTBX_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTBX_identifiant
            // 
            this.TXTBX_identifiant.Location = new System.Drawing.Point(107, 187);
            this.TXTBX_identifiant.Name = "TXTBX_identifiant";
            this.TXTBX_identifiant.Size = new System.Drawing.Size(145, 26);
            this.TXTBX_identifiant.TabIndex = 11;
            // 
            // LBL_identifiant
            // 
            this.LBL_identifiant.AutoSize = true;
            this.LBL_identifiant.Location = new System.Drawing.Point(142, 167);
            this.LBL_identifiant.Name = "LBL_identifiant";
            this.LBL_identifiant.Size = new System.Drawing.Size(71, 18);
            this.LBL_identifiant.TabIndex = 10;
            this.LBL_identifiant.Text = "Identifiant";
            // 
            // TXTBX_motDePasse
            // 
            this.TXTBX_motDePasse.Location = new System.Drawing.Point(107, 247);
            this.TXTBX_motDePasse.Name = "TXTBX_motDePasse";
            this.TXTBX_motDePasse.Size = new System.Drawing.Size(145, 26);
            this.TXTBX_motDePasse.TabIndex = 13;
            this.TXTBX_motDePasse.UseSystemPasswordChar = true;
            // 
            // LBL_motDePasse
            // 
            this.LBL_motDePasse.AutoSize = true;
            this.LBL_motDePasse.Location = new System.Drawing.Point(133, 227);
            this.LBL_motDePasse.Name = "LBL_motDePasse";
            this.LBL_motDePasse.Size = new System.Drawing.Size(88, 18);
            this.LBL_motDePasse.TabIndex = 12;
            this.LBL_motDePasse.Text = "Mot de passe";
            // 
            // BTN_Seconnecter
            // 
            this.BTN_Seconnecter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Seconnecter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BTN_Seconnecter.Location = new System.Drawing.Point(107, 294);
            this.BTN_Seconnecter.Name = "BTN_Seconnecter";
            this.BTN_Seconnecter.Size = new System.Drawing.Size(145, 34);
            this.BTN_Seconnecter.TabIndex = 14;
            this.BTN_Seconnecter.Text = "Se connecter";
            this.BTN_Seconnecter.UseVisualStyleBackColor = false;
            this.BTN_Seconnecter.Click += new System.EventHandler(this.BTN_Seconnecter_Click);
            // 
            // PCTBX_logo
            // 
            this.PCTBX_logo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.centre_culturel_M;
            this.PCTBX_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCTBX_logo.ErrorImage = null;
            this.PCTBX_logo.InitialImage = null;
            this.PCTBX_logo.Location = new System.Drawing.Point(122, 30);
            this.PCTBX_logo.Name = "PCTBX_logo";
            this.PCTBX_logo.Size = new System.Drawing.Size(117, 106);
            this.PCTBX_logo.TabIndex = 1;
            this.PCTBX_logo.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.BTN_Seconnecter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 367);
            this.Controls.Add(this.BTN_Seconnecter);
            this.Controls.Add(this.TXTBX_motDePasse);
            this.Controls.Add(this.LBL_motDePasse);
            this.Controls.Add(this.TXTBX_identifiant);
            this.Controls.Add(this.LBL_identifiant);
            this.Controls.Add(this.PCTBX_logo);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 405);
            this.MinimumSize = new System.Drawing.Size(371, 405);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PCTBX_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCTBX_logo;
        private System.Windows.Forms.TextBox TXTBX_identifiant;
        private System.Windows.Forms.Label LBL_identifiant;
        private System.Windows.Forms.TextBox TXTBX_motDePasse;
        private System.Windows.Forms.Label LBL_motDePasse;
        private System.Windows.Forms.Button BTN_Seconnecter;
    }
}