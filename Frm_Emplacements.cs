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
    public partial class Frm_Emplacements : Form
    {
        //***************************************************************
        //***************************************************************
        //************   Les "variables" internes à la form  ************
        //***************************************************************
        //***************************************************************


        //Déclaration des attributs
        Emplacement emp_infos;
        Emplacements ListeEmplacements;
        Themes ListeThemes;
        String Action = "";


        public Frm_Emplacements()
        {
            InitializeComponent();
        }


        //***************************************************************
        //***************************************************************
        //************   Les événements geres dans le form  *************
        //***************************************************************
        //***************************************************************


        //*********************************************************
        //*************** Chargement du formulaire    *************
        //*********************************************************
        #region Evènements chargement du formulaire bibliothèque

        //CHARGEMENT DU FORMULAIRE***************************************
        /// <summary>
        /// CHARGEMENT DU FORMULAIRE
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Frm_Emplacements_Load(object sender, EventArgs e)
        {
            // Initialisation du jeu d'essai
            //Chargement des emplacements
            ListeEmplacements = new Emplacements();
            //Alimentation du combo-box et du datagrid view
            Init_Empl();

            //Gestion visibilité des contrôles
            Affiche_logo();
            Visible_CHARGEMENT();
        }

        #endregion



        //*********************************************************
        //************* Sélection d'un emplacement  ***************
        //*********************************************************
        #region Sélection emplacement COMBO

        //Sélection COMBOBOX**********************************************
        /// <summary>
        /// Sélection COMBOBOX
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">e</param>
        private void COMBO_SelectEmplacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gestion visibilité des contôles
            Visible_SELECTION();
            Enable_TXTBX_Code();

            //Efface tous les symboles erreurs
            errorProvider.SetError(NUMRC_Etage, "");
            errorProvider.SetError(NUMRC_Allee, "");
            errorProvider.SetError(NUMRC_Rayon, "");

            if (COMBO_SelectEmplacement.SelectedIndex > -1)
            {
                if (COMBO_SelectEmplacement.SelectedValue.GetType() != typeof(Emplacement)) //si emplacement existe
                {
                    Action = "SELECT";

                    //Transmission des données de l'emplacement à la variable emp_infos
                    emp_infos = (Emplacement)COMBO_SelectEmplacement.SelectedItem; 
                    //Affichage des données dans le groupbox données de la bibliothèque
                    Affiche_txtbox();
                }
            }
        }

        #endregion


        //*********************************************************
        //*********** NOUVEAU / MODIFIER / SUPPRIMER  *************
        //*********************************************************
        #region Action boutons NOUVEAU / MODIFIER / SUPPRIMER

        //Bouton NOUVEAU*************************************************
        /// <summary>
        /// Bouton NOUVEAU
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BTN_Nouveau_Click(object sender, EventArgs e)
        {
            //Positionnement ComboBox sur zone neutre
            COMBO_SelectEmplacement.SelectedIndex = -1;
            DTGRD_Emplacements.RowHeadersVisible = false;

            //Focus combo_theme
            COMBO_Theme.Focus();
            alimenter_combo_themes();

            //Gestion visibilité des contôles
            Visible_NOUVEAU_MODIFIER();

            // Initialisation des zones textes
            Efface_Textbox();
            // Affichage automatique d'un code emplacement par défault le temps de la saisie
            TXTBX_CodeEmplacement.Text = "E0-A0-R0";

            Action = "NOUVEAU";
        }

        //Bouton MODIFIER************************************************
        /// <summary>
        /// Bouton MODIFIER
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            //Positionnement ComboBox sur zone neutre
            COMBO_SelectEmplacement.SelectedIndex = -1;

            //Focus combo_theme
            COMBO_Theme.Focus();
            alimenter_combo_themes();

            //Gestion visibilité des contôles
            Visible_NOUVEAU_MODIFIER();

            Action = "MODIF";
        }

        //Bouton SUPPRIMER***********************************************
        /// <summary>
        /// Bouton SUPPRIMER
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            //Message d'alerte avant la suppression
            MessageBox.Show("Etes-vous sûr de vouloir supprimer l'emplacment " + GRPBX_Libelle.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (DialogResult != DialogResult.Yes)
            {
                // Suppression de la couche PERSISTANCE de la bibliothèque courant
                ListeEmplacements.SUPPRIMER(emp_infos);
                //Réactualisation du datagrid
                Init_Empl();

                //Gestion visibilité des contôles
                Visible_SUPPRIMER();
                Efface_Textbox();

                //Message de confirmation
                MessageBox.Show("Suppression effectuée.");
            }
            else
            {
                //Réinitialisation des informations de la bibliothèque courante
                Visible_SELECTION();
                Affiche_txtbox();
            }
        }

        #endregion


        //*********************************************************
        //************ RETOUR MENU / DETAILS / LESS  **************
        //*********************************************************
        #region Action boutons RETOUR / DETAILS / LESS

        //Bouton RETOUR MENU
        /// <summary>
        /// Bouton RETOUR MENU
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Retour_Menu_Click(object sender, EventArgs e)
        {
            this.Close(); //Fermeture du formulaire
        }

        //Bouton + : affichage du tableau de la base de données 
        /// <summary>
        /// Bouton + : affichage du tableau de la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Details_Click(object sender, EventArgs e)
        {
            //Gestion visibilité contrôles
            Visible_DATAGRID_Fle();
        }

        //Bouton - : cache le tableau de la base de données
        /// <summary>
        /// Bouton - : cache le tableau de la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Less_Click(object sender, EventArgs e)
        {
            //Gestion visibilité contrôles
            Invisible_DATAGRID_Fle();
        }

        #endregion


        //*********************************************************
        //**************** ENREGISTRER / ANNULER  *****************
        //*********************************************************
        #region Action boutons ENREGISTRER / ANNULER

        //Bouton ENREGISTRER
        /// <summary>
        /// Bouton ENREGISTRER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            #region Contrôle de saisie
            
            //ETAGE VALIDE
                if (NUMRC_Etage.Text != "" )
                {
                    errorProvider.SetError(NUMRC_Etage, ""); // Efface le symbole erreur
                }
                else
                {
                    errorProvider.SetError(NUMRC_Etage, "Sélectionnez le numero de l'étage."); // Affiche le symbole erreur avec affichage infobulle
                    NUMRC_Etage.Focus();
                    return;
                }

                //ALLEE VALIDE
                if (NUMRC_Allee.Text != "0")
                {
                    errorProvider.SetError(NUMRC_Allee, "");
                }
                else
                {
                    errorProvider.SetError(NUMRC_Allee, "Sélectionnez le numero de l'allée.");
                    NUMRC_Allee.Focus();
                    return;
                }

                //RAYON VALIDE
                if (NUMRC_Rayon.Text != "0")
                {
                    errorProvider.SetError(NUMRC_Rayon, "");
                }
                else
                {
                    errorProvider.SetError(NUMRC_Rayon, "Saisie du Code invalide.");
                    NUMRC_Rayon.Focus();
                    return;
                }

                #endregion

                if (Action == "NOUVEAU")
                {
                    //Ajout de cet emplacement dans la base de données
                    ListeEmplacements.AJOUT_new(Reccupere_données());

                    //Message d'information enregistrement réussit
                    MessageBox.Show("Ajout dans la base de donnée réussit.");
                }

                else
                {
                    if (Action == "MODIF")
                    {
                        //Message d'alerte avant de rétablir les anciennes saisies
                        MessageBox.Show("Etes-vous sûr de vouloir modifier les informations de cet emplacement ?", "Confirmation", MessageBoxButtons.YesNo);

                        if (DialogResult != DialogResult.Yes)
                        {
                            //Modification de cet emplacment dans la base de données
                            ListeEmplacements.MAJ_Empl(Reccupere_données());
                            //Message d'information enregistrement réussit
                            MessageBox.Show("Enregitrement des modifications réussit.");
                        }
                    }
                }

            //Réalimentation COMBO-BOX liste des emplacements
            Init_Empl();
        }

        //Bouton ANNULER
        /// <summary>
        /// Bouton ANNULER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            //Message d'alerte avant de rétablir les anciennes saisies
            MessageBox.Show("Etes-vous sûr de vouloir réinitialiser les informations de cet emplacement ?", "Confirmation", MessageBoxButtons.YesNo);

            if (DialogResult != DialogResult.Yes)
            {
                //Réinitialisation des informations de la bibliothèque courante
                Visible_SELECTION();
                Affiche_txtbox();
            }
        }

        #endregion


        //*********************************************************
        //******************* Actions GROUPBOX  *******************
        //*********************************************************
        #region Actions dans le GROUPBOX données de l'emplacement

        //Zone de saisie CODE BIBLIO
        /// <summary>
        /// Zone de saisie CODE BIBLIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTBX_CodeBiblio_TextChanged(object sender, EventArgs e)
        {
        //Pas de saisie possible car générer automatiquement
            TXTBX_CodeBiblio.Enabled = false;
        }

        //Zone de saisie CODE EMPLACEMENT
        /// <summary>
        /// Zone de saisie CODE EMPLACEMENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTBX_CodeEmplacement_TextChanged(object sender, EventArgs e)
        {
            //Pas de saisie possible car générer automatiquement
            TXTBX_CodeEmplacement.Enabled = false;
        }

        //Sélection Combobox THEME
        /// <summary>
        /// Sélection Combobox THEME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void COMBO_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visible_NOUVEAU_MODIFIER();
            BTN_Enregistrer.Visible = true;

            if ((Action == "NOUVEAU") && (Action == "MODIFIER"))
            {
                if (COMBO_Theme.SelectedValue != null)
                {
                    TXTBX_CodeTheme.Text = COMBO_Theme.SelectedValue.ToString();
                }
            }
            
        }

        //Zone de saisie ETAGE
        /// <summary>
        /// Zone de saisie ETAGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NUMRC_Etage_Click(object sender, EventArgs e)
        {
            //Affiche bouton valide et annuler
            BTN_Enregistrer.Visible = true;
        }

        //Zone de saisie ALLEE
        /// <summary>
        /// Zone de saisie ALLEE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NUMRC_Allee_Click(object sender, EventArgs e)
        {
            //Affiche bouton valide et annuler
            BTN_Enregistrer.Visible = true;
        }

        //Zone de saisie RAYON
        /// <summary>
        /// Zone de saisie RAYON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NUMRC_Rayon_Click(object sender, EventArgs e)
        {
            //Affiche bouton valide et annuler
            BTN_Enregistrer.Visible = true;
        }

        #endregion


        //*********************************************************
        //************* Boutons SUIVANT / PRECEDENT  **************
        //*********************************************************
        #region Bouton SUIVANT / PRECEDENT

        //Bouton PRECEDENT
        /// <summary>
        /// Bouton PRECEDENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Prec_Click(object sender, EventArgs e)
        {
            int index = COMBO_SelectEmplacement.SelectedIndex;

            try
            {
                emp_infos = ListeEmplacements.empl_PRECEDENT(); //Recuperation de la bibliothèque precedente
                Affiche_txtbox();
                COMBO_SelectEmplacement.SelectedItem = emp_infos;

                if ((COMBO_SelectEmplacement.SelectedIndex == 0))//Si haut de la liste
                {
                    BTN_Prec.Visible = false;
                }
                else
                {
                    BTN_Prec.Visible = true;
                    BTN_Suiv.Visible = true;
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Pas d'enreg " + ev.Message.ToString());
            }
        }

        //Bouton SUIVANT
        /// <summary>
        /// Bouton SUIVANT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Suiv_Click(object sender, EventArgs e)
        {
            int index = COMBO_SelectEmplacement.SelectedIndex;

            try
            {
                emp_infos = ListeEmplacements.empl_SUIVANT(); //Recuperation de l'adherent suivant
                Affiche_txtbox();
                COMBO_SelectEmplacement.SelectedItem = emp_infos;

                if (COMBO_SelectEmplacement.SelectedIndex == COMBO_SelectEmplacement.Items.Count - 1) //Si bas de la liste
                {
                    BTN_Suiv.Visible = false;
                }
                else
                {
                    BTN_Prec.Visible = true;
                    BTN_Suiv.Visible = true;
                }
            }
            catch (Exception ev)
            {

                MessageBox.Show("Pas d'enreg " + ev.Message.ToString());
            }
        }

        #endregion


        //*********************************************************
        //******************* Actualisation  **********************
        //*********************************************************
        #region Actualisation
        /// <summary>
        /// Actualisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_MAJ_Click(object sender, EventArgs e)
        {
            Init_Empl();
            Invisible_DATAGRID_Fle();
            Visible_DATAGRID_Fle();
        }

        #endregion


        //*********************************************************
        //*************   FERMETURE du formulaire    **************
        //*********************************************************
        /// <summary>
        /// FERMETURE du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Emplacements_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Etes-vous sûr de vouloir quitter ce formulaire ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        //***************************************************************
        //***************************************************************
        //************   Procedures et fonctions internes  **************
        //***************************************************************
        //***************************************************************


        //*********************************************************
        //************** Visibilité des contrôles  ****************
        //*********************************************************
        #region Visibilité des contrôles

        /// <summary>
        /// Visibilité des contrôles au chargement du formulaire
        /// </summary>
        void Visible_CHARGEMENT()
        {
            //Contrôles visibles --> action SELECTION d'un emplacement dans le combobox ou le datagrid view 

            //COMBO-BOX liste
            COMBO_SelectEmplacement.Visible = true;
            COMBO_SelectEmplacement.Enabled = true;
            LBL_SelectEmplacements.Visible = true;
            PICBX_Biblio.Visible = true;

            //Boutons NOUVEAU / MODIFIER / SUPPRIMER
            BTN_Nouveau.Visible = true;
            BTN_Nouveau.Enabled = true;
            BTN_Modifier.Visible = false;
            BTN_Supprimer.Visible = false;

            //Les zones de saisies
            GRPBX_Donnees_emplacement.Visible = false;

            //Boutons RETOUR MENU et DETAILS
            BTN_Retour_Menu.Visible = false;
            BTN_Details.Visible = false;

            //Boutons ENREGISTRER / ANNULER
            BTN_Enregistrer.Visible = false;
            BTN_Annuler.Visible = false;    
        }

        /// <summary>
        /// Visibilité des contrôles avec affichage des données
        /// </summary>
        void Visible_SELECTION()
        {
            //Contrôles visibles --> action SELECTION d'un emplacement dans le combobox ou le datagrid view 

            //COMBO-BOX liste
            COMBO_SelectEmplacement.Visible = true;
            COMBO_SelectEmplacement.Enabled = true;
            LBL_SelectEmplacements.Visible = true;
            PICBX_Biblio.Visible = true;

            //Boutons NOUVEAU / MODIFIER / SUPPRIMER
            BTN_Nouveau.Visible = true;
            BTN_Nouveau.Enabled = true;
            BTN_Modifier.Visible = true;
            BTN_Modifier.Enabled = true;
            BTN_Supprimer.Visible = true;
            BTN_Supprimer.Enabled = true;

            //Les zones de saisies
            GRPBX_Donnees_emplacement.Visible = true;
            GRPBX_Donnees_emplacement.Enabled = false;
            GRPBX_Libelle.Visible = true;
            GRPBX_Libelle.Enabled = false;
            LBL_Theme.Visible = false;
            COMBO_Theme.Visible = false;

            //Boutons RETOUR MENU et DETAILS
            BTN_Retour_Menu.Visible = true;
            BTN_Details.Visible = true;

            //Boutons ENREGISTRER / ANNULER
            BTN_Enregistrer.Visible = false;
            BTN_Annuler.Visible = false;    
        }

        /// <summary>
        /// Contrôles visibles --> action NOUVEAU / MODIFIER un emplacement
        /// </summary>
        void Visible_NOUVEAU_MODIFIER()
        {
            //Contrôles visibles --> action NOUVEAU / MODIFIER

            //COMBO-BOX liste
            COMBO_SelectEmplacement.Visible = true;
            COMBO_SelectEmplacement.Enabled = false;
            LBL_SelectEmplacements.Visible = true;
            PICBX_Biblio.Visible = true;

            //Boutons NOUVEAU / MODIFIER / SUPPRIMER
            BTN_Nouveau.Visible = true;
            BTN_Nouveau.Enabled = false;
            BTN_Modifier.Visible = true;
            BTN_Modifier.Enabled = false;
            BTN_Supprimer.Visible = true;
            BTN_Supprimer.Enabled = false;

            //Les zones de saisies
            GRPBX_Donnees_emplacement.Visible = true;
            GRPBX_Donnees_emplacement.Enabled = true;
            GRPBX_Libelle.Visible = true;
            GRPBX_Libelle.Enabled = true;
            LBL_Theme.Visible = true;
            COMBO_Theme.Visible = true;
            NUMRC_Etage.Enabled = true;

            //Boutons RETOUR MENU et DETAILS
            BTN_Retour_Menu.Visible = true;
            BTN_Details.Visible = true;

            //Boutons ENREGISTRER / ANNULER
            BTN_Enregistrer.Visible = false;
            BTN_Annuler.Visible = true;    
        }

        /// <summary>
        /// Contrôles visibles --> action SUPPRIMER un emplacement
        /// </summary>
        void Visible_SUPPRIMER()
        {
            //Contrôles visibles --> action SUPPRIMER

            //COMBO-BOX liste
            COMBO_SelectEmplacement.Visible = true;
            COMBO_SelectEmplacement.Enabled = true;
            LBL_SelectEmplacements.Visible = true;
            PICBX_Biblio.Visible = true;

            //Boutons NOUVEAU / MODIFIER / SUPPRIMER
            BTN_Nouveau.Visible = true;
            BTN_Nouveau.Enabled = true;
            BTN_Supprimer.Visible = false;
            BTN_Modifier.Visible = false;

            //Les zones de saisies
            GRPBX_Donnees_emplacement.Visible = true;
            GRPBX_Donnees_emplacement.Enabled = false;
            GRPBX_Libelle.Visible = true;
            GRPBX_Libelle.Enabled = false;
            LBL_Theme.Visible = false;
            COMBO_Theme.Visible = false;
            NUMRC_Etage.Enabled = false;

            //Boutons RETOUR MENU et DETAILS
            BTN_Retour_Menu.Visible = true;
            BTN_Details.Visible = true;

            //Boutons ENREGISTRER / ANNULER
            BTN_Enregistrer.Visible = false;
            BTN_Annuler.Visible = false;    

        }

        /// <summary>
        /// Visibilité des contrôles désactivation des textbox
        /// </summary>
        void Enable_TXTBX_Code()
        {
            //Désactive les zones de saisies des codes
            GRPBX_Donnees_emplacement.Enabled = false;
            GRPBX_Libelle.Enabled = false;
            TXTBX_CodeBiblio.Enabled = false;
            TXTBX_CodeEmplacement.Enabled = false;
            TXTBX_CodeTheme.Enabled = false;
            NUMRC_Etage.Enabled = false;
            NUMRC_Etage.Enabled = false;
            NUMRC_Etage.Enabled = false;
        }

        /// <summary>
        /// Visibilité datagridview 
        /// </summary>
        void Visible_DATAGRID_Fle()
        {
            //Rend visible le tableau et les flèches suivant et precedent
            DTGRD_Emplacements.Visible = true;
            BTN_Prec.Visible = true;
            BTN_Suiv.Visible = true;
            BTN_MAJ.Visible = true;

            //Le bouton + est masqué par le bouton -
            BTN_Less.Visible = true;
        }

        /// <summary>
        /// Cache datagridview 
        /// </summary>
        void Invisible_DATAGRID_Fle()
        {
            //Cache le tableau et les flèches suivant et precedent
            DTGRD_Emplacements.Visible = false;
            BTN_Prec.Visible = false;
            BTN_Suiv.Visible = false;
            BTN_MAJ.Visible = false;

            //Cache le bouton - ==> bouton + devient visible
            BTN_Less.Visible = false;
        }

        #endregion


        //*********************************************************
        //********************* Procédures  ***********************
        //*********************************************************
        #region Procédures

        /// <summary>
        /// Initialisation / actualisation du combobox
        /// </summary>
        void Init_Empl()
        {
            // Alimentation des noms des emplacements dans la liste Box
            alimenter_combobox();
            // Association du DATAGRIDVIEW à la source de données
            alimenter_Datagrid();
        }

        /// <summary>
        /// Affichage des données l'emplacement COURANT
        /// </summary>
        void Affiche_txtbox()
        {
            //Affichage de l'emplacement COURANT (selectionné dans le combobox)
            TXTBX_CodeBiblio.Text = emp_infos.CodeBiblio; //Code biblio
            TXTBX_CodeEmplacement.Text = emp_infos.CodeEmplacement; //Code emplacement
            TXTBX_CodeTheme.Text = emp_infos.CodeTheme; //Code thème
            NUMRC_Etage.Value = emp_infos.Etage ; //Etage
            NUMRC_Allee.Value = emp_infos.Allee; //Allée
            NUMRC_Rayon.Value = emp_infos.Rayon; //Rayon
        }

        /// <summary>
        /// Efface toutes les zones de saisies sauf le code biblio
        /// </summary>
        void Efface_Textbox()
        {
            TXTBX_CodeEmplacement.Text = "";
            TXTBX_CodeTheme.Text = "";
            NUMRC_Etage.Text = "";
            NUMRC_Allee.Text = "";
            NUMRC_Rayon.Text = "";
        }

        /// <summary>
        /// Récupèration des données des zones de saisies pour constituer un emplacment
        /// </summary>
        /// <returns>Toutes les données d'un emplacement</returns>
        Emplacement Reccupere_données()
        {
            //Affichage de l'emplacment COURANT (celui selectionné dans le combobox)
            Emplacement resultat = new Emplacement();
            resultat.CodeBiblio = TXTBX_CodeBiblio.Text; //Code biblio
            resultat.CodeTheme = TXTBX_CodeTheme.Text; //Code thème
            resultat.Etage = Convert.ToDecimal(NUMRC_Etage.Text); //Etage
            resultat.Allee = Convert.ToDecimal(NUMRC_Allee.Text); //Allée
            resultat.Rayon = Convert.ToDecimal(NUMRC_Rayon.Text); //Rayon
            // Nouveau code emplacment
            TXTBX_CodeEmplacement.Text = resultat.New_Code_Empl();
            resultat.CodeEmplacement = TXTBX_CodeEmplacement.Text; //Code emplacement

            resultat.Libelle = "Etage" + emp_infos.Etage + "-Allée" + emp_infos.Allee + "-Rayon" + emp_infos.Rayon;
            return resultat;
        }

        /// <summary>
        /// Affichage du logo fonction de la bibliothèque sélectionnée à l'ouverture de l'application
        /// </summary>
        void Affiche_logo()
        {
            //if (TXTBX_CodeBiblio.Text == "XX01")
            //{
            //    PICBX_Biblio.Image = new Bitmap(Properties.Resources.centre_culturel_M);
            //}
            //else
            //{
            //    PICBX_Biblio.Image = new Bitmap(Properties.Resources.centre_culturel_M);
            //}
        }

        // COMBOBOX Emplacements
        /// <summary>
        /// Alimentation COMBOBOX principal avec la liste des emplacements
        /// </summary>
        private void alimenter_combobox()
        {
            // Initialisation de la liste des emplacements
            COMBO_SelectEmplacement.DataSource = null;
            COMBO_SelectEmplacement.Items.Clear();

            // Initialisation du COMBO sélectionnez un emplacement
            COMBO_SelectEmplacement.DataSource = ListeEmplacements.Liste_Emplacement(); //Recuperation de la liste des emplacements
            COMBO_SelectEmplacement.DisplayMember = "Libelle"; //Données affichée dans le combobox
            COMBO_SelectEmplacement.ValueMember = "CodeEmplacement"; //Donnée sélectionnée par laquelle sont retrouvées les autres données
            COMBO_SelectEmplacement.SelectedIndex = -1; //Débute par une zone vide
        }

        // DATAGRIDVIEW
        /// <summary>
        /// Alimentation du DATAGRID VIEW
        /// </summary>
        private void alimenter_Datagrid()
        {
            // Association du DATAGRIDVIEW à la source de données
            DTGRD_Emplacements.DataSource = null;
            DTGRD_Emplacements.DataSource = ListeEmplacements.Liste_Emplacement(); //Recuperation de la liste des emplacements
        }

        //COMBOBOX Thèmes
        /// <summary>
        /// Alimentation COMBOBOX principal avec la liste des thèmes
        /// </summary>
        private void alimenter_combo_themes()
        {
            // Initialisation de la liste des emplacments
            COMBO_Theme.DataSource = null;
            COMBO_Theme.Items.Clear();

            // Initialisation du COMBO sélectionnez un emplacment
            ListeThemes = new Themes();
            COMBO_Theme.DataSource = ListeThemes; //Recuperation de la liste des emplacments
            COMBO_Theme.DisplayMember = "LibellerTheme"; //Données affichée dans le combobox
            COMBO_Theme.ValueMember = "CodeTheme"; //Donnée sélectionnée par laquelle sont retrouvées les autres données
            COMBO_Theme.SelectedIndex = -1; //Débute par une zone vide
        }

        #endregion


    }
}
