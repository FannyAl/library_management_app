using Biblio_class;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Text;

namespace WindowsFormsApplication1
{
    public partial class Frm_Menu : Form
    {
        //***************************************************************
        //***************************************************************
        //************   Les "variables" internes à la form  ************
        //***************************************************************
        //***************************************************************


        public Frm_Menu()
        {
            InitializeComponent();
        }

        //*********************************************************
        //************   Chargement du formulaire    **************
        //*********************************************************
        #region Chargement du formulaire
        
        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            //Ouverture de l'application avec la fenêtre de LOGIN
            Frm_Login f = new Frm_Login();
            //f.MdiParent = this;
            f.Show();

            //Approvisionnement du COMBO-BOX : Sélect bibliothèque
            Bibliotheques Liste = new Bibliotheques();
            TLSTRP_CMBBX_SelectBibli.Items.Clear();
            foreach (Bibliotheque b in Liste)
            {
                TLSTRP_CMBBX_SelectBibli.Items.Add(b.CodeBiblio + " : " +b.Libelle);
                
            }
        }

        #endregion


        //*********************************************************
        //************ COMBO-BOX : sélection biblio  **************
        //*********************************************************

        #region ALIMENTATION Combo-box


        


        #endregion

        #region SELECTION Combo-box

        //SELECTION BIBLIOTHEQUE dans le COMBO
        private void TLSTRP_CMBBX_SelectBibli_Click(object sender, EventArgs e)
        {

            //Accès aux rubriques seulement après sélection d'une bibliothèque
            if (TLSTRP_CMBBX_SelectBibli.SelectedIndex != 0)
            {
                MENU_Principal.Items["gestionLivresToolStripMenuItem"].Visible = true;
                MENU_Principal.Items["prêtRetourToolStripMenuItem"].Visible = false;
                MENU_Principal.Items["bibliothèqueToolStripMenuItem"].Visible = true;
                MENU_Principal.Items["gestionEmplacementToolStripMenuItem"].Visible = true;
            }
        }

        #endregion

        //*********************************************************
        //********************   Menu    **************************
        //*********************************************************

        #region Gestion visibilité des menus

        //Gestion de l'affichage du Menu au départ de l'application
        public void Menu_init()
        {
            //Connexion visible PAR DEFAULT
            MENU_Principal.Items["connexionToolStripMenuItem"].Visible = true;

            //Désactivation options ADHERENTS
            MENU_Principal.Items["consulterLesFondsToolStripMenuItem"].Visible = false;
            MENU_Principal.Items["prêtRetourToolStripMenuItem"].Visible = false;
            MENU_Principal.Items["fenêtreToolStripMenuItem"].Visible = false;

            //Désactivation options AGENT
            MENU_Principal.Items["adherentsToolStripMenuItem"].Visible = false;

            //Désactivation options GESTIONNAIRE
            MENU_Principal.Items["gestionLivresToolStripMenuItem"].Visible = false;
            MENU_Principal.Items["parAUTEURToolStripMenuItem"].Visible = true;
            MENU_Principal.Items["parTHEMEToolStripMenuItem"].Visible = true;
            MENU_Principal.Items["parLIVREToolStripMenuItem"].Visible = true;
            MENU_Principal.Items["parTHEMEToolStripMenuItem"].Visible = true;
            MENU_Principal.Items["TLSTRP_CMBBX_SelectBibli"].Visible = false;
            MENU_Principal.Items["bibliothèqueToolStripMenuItem"].Visible = false;
            MENU_Principal.Items["gestionEmplacementToolStripMenuItem"].Visible = false;

            //DECONNEXION
            MENU_Principal.Items["déconnectionToolStripMenuItem"].Visible = false;
        }

        // Eléments du menu visible pour les ADHERENTS
        public void Menu_ADHERENT()
        {
            MENU_Principal.Items["connexionToolStripMenuItem"].Visible = false;
            MENU_Principal.Items["consulterLesFondsToolStripMenuItem"].Visible = true;
            MENU_Principal.Items["fenêtreToolStripMenuItem"].Visible = true;
            MENU_Principal.Items["déconnectionToolStripMenuItem"].Visible = true;
        }

        // Eléments du menu visible pour les AGENTS
        public void Menu_AGENT()
        {
            MENU_Principal.Items["adherentsToolStripMenuItem"].Visible = true;
            MENU_Principal.Items["prêtRetourToolStripMenuItem"].Visible = true;
        }

        // Eléments du menu visible pour le GESTIONNAIRE DE FONDS
        public void Menu_GESTIONNAIRE()
        {
            Frm_Menu Gestionnaire;
            Gestionnaire = this;
            MENU_Principal.Items["TLSTRP_CMBBX_SelectBibli"].Visible = true;
        }

        #endregion


        #region Connexion Menu -- Formulaire
        
        //Consulter les FONDS
        private void consulterLesFondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consulter_le_fond f = new Frm_Consulter_le_fond();
            f.MdiParent = this;
            f.Show();
        
        }

        //Gérer les EMPRUNTS
        private void gérerLesEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Gerer_les_prets f = new Frm_Gerer_les_prets();
            f.MdiParent = this;
            f.Show();
        }

        //Gérer les RETOURS
        private void gérerLesRetoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Retour_pret f = new Frm_Retour_pret();
            f.MdiParent = this;
            f.Show();
        }

        //Gérer les LIVRES
        private void gestionLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Gerer_les_adherents f = new Frm_Gerer_les_adherents();
            f.MdiParent = this;
            f.Show();
        
        }

        //Gérer les EMPLACEMENTS
        private void gestionEmplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Emplacements f = new Frm_Emplacements();
            f.MdiParent = this;
            f.Show();
        
        }

        //Gérer les BIBLIOTHEQUES
        private void bibliothèqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bibliotheques f = new Frm_Bibliotheques();
            f.MdiParent = this;
            f.Show();
        
        }

        //DECONNEXION
        private void déconnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Etes-vous sûr de vouloir fermer votre connexion ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //Menu innaxessible
            }
            else
            {
                this.Close();
            }
        }

        #endregion


        //*********************************************************
        //*************   Fermeture du formulaire    **************
        //*********************************************************
        private void Frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Etes-vous sûr de vouloir fermer l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }

}
