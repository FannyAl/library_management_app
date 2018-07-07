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
    public partial class Frm_Bibliotheques : Form
    {
        //***************************************************************
        //***************************************************************
        //************   Les "variables" internes à la form  ************
        //***************************************************************
        //***************************************************************


        //Déclaration des attributs
        Bibliotheque bib_infos;
        Bibliotheques ListeBibliothèques;
        String Action = "";


        public Frm_Bibliotheques()
        {
            InitializeComponent();
        }

        //***************************************************************
        //***************************************************************
        //************   Les événements geres dans le form  *************
        //***************************************************************
        //***************************************************************


        //*********************************************************
        //*************** CHARGEMENT du formulaire    *************
        //*********************************************************
        #region CHARGEMENT du formulaire bibliothèque

        //CHARGEMENT DU FORMULAIRE***************************************
        /// <summary>
        /// CHARGEMENT DU FORMULAIRE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Bibliotheques_Load(object sender, EventArgs e)
        {
            // Chargement des Bibliothèques
            ListeBibliothèques = new Bibliotheques();
            // Alimentation du COMBO-BOX et DATAGRID
            Init_Biblio();

            //Gestion visibilité des contrôles
            Visible_CHARGEMENT();
        }

        #endregion


        //*********************************************************
        //************* SELECTION d'une bibliothèque  *************
        //*********************************************************
        #region SELECTION bibliothèque COMBO

        //Sélection COMBOBOX**********************************************
        /// <summary>
        /// Sélection COMBOBOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void COMBO_SelectBiblio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gestion visibilité des contôles
            Visible_SELECTION();
            Enable_TXTBX_Code();

            //Efface tous les symboles erreurs
            errorProvider.SetError(TXTBX_Libelle, "");
            errorProvider.SetError(TXTBX_Adresse, "");
            errorProvider.SetError(TXTBX_CodePostal, "");
            errorProvider.SetError(TXTBX_Ville, "");

            if (COMBO_SelectBiblio.SelectedIndex > -1)
            {
                if (COMBO_SelectBiblio.SelectedValue.GetType() != typeof(Bibliotheque)) //si bibliothèque existe
                {
                    Action = "SELECT";

                    //Transmission des données de la bibliothèque à la variable bib_infos
                    bib_infos = (Bibliotheque)COMBO_SelectBiblio.SelectedItem;
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Nouveau_Click(object sender, EventArgs e)
        {
            //Positionnement ComboBox sur zone neutre
            COMBO_SelectBiblio.SelectedIndex = -1;
            DTGRD_Biblio.ClearSelection();

            //Focus
            TXTBX_Libelle.Focus();

            //Gestion visibilité des contôles
            Visible_NOUVEAU_MODIFIER();

            // Initialisation des zones textes
            Efface_Textbox();
            // Affichage automatique du prochain code bibliothèque
            TXTBX_CodeBiblio.Text = ListeBibliothèques.Code_PROVISOIR().ToString(); //Recupération de la prochaine clé

            Action = "NOUVEAU";
        }

        //Bouton MODIFIER************************************************
        /// <summary>
        /// Bouton MODIFIER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            //Positionnement ComboBox sur zone neutre
            COMBO_SelectBiblio.SelectedIndex = -1;

            //Focus
            TXTBX_Libelle.Focus();

            //Gestion visibilité des contôles
            Visible_NOUVEAU_MODIFIER();

            Action = "MODIF";
        }

        //Bouton SUPPRIMER***********************************************
        /// <summary>
        /// Bouton SUPPRIMER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            //Message d'alerte avant la suppression
            MessageBox.Show("Etes-vous sûr de vouloir supprimer la bibliothèque " + TXTBX_Libelle.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (DialogResult != DialogResult.Yes)
            {
                // Suppression de la couche PERSISTANCE de la bibliothèque courant
                ListeBibliothèques.SUPPRIMER(bib_infos);
                //Réactualisation du datagrid et combo-box
                Init_Biblio();

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
            #region Contrôle de VALIDATION

            //LIBELLE VALIDE
            if (Libelle_Valide(TXTBX_Libelle.Text))
            {
                errorProvider.SetError(TXTBX_Libelle, ""); // Efface le symbole erreur
            }
            else
            {
                errorProvider.SetError(TXTBX_Libelle, "Saisie du libellé invalide."); // Affiche le symbole erreur avec affichage infobulle
                TXTBX_Libelle.Focus();
                return;
            }

            //ADRESSE VALIDE
            if (Adresse_Valide(TXTBX_Adresse.Text))
            {
                errorProvider.SetError(TXTBX_Adresse, "");
            }
            else
            {
                errorProvider.SetError(TXTBX_Adresse, "Saisie de l'adresse invalide.");
                TXTBX_Adresse.Focus();
                return;
            }

            //CODE POSTAL VALIDE
            if (CodePostal_Valide(TXTBX_CodePostal.Text))
            {
                errorProvider.SetError(TXTBX_CodePostal, "");
            }
            else
            {
                errorProvider.SetError(TXTBX_CodePostal, "Saisie du Code invalide.");
                TXTBX_CodePostal.Focus();
                return;
            }

            //VILLE VALIDE
            if (Ville_Valide(TXTBX_Ville.Text))
            {
                errorProvider.SetError(TXTBX_Ville, "");
            }
            else
            {
                errorProvider.SetError(TXTBX_Ville, "Saisie de la Ville invalide.");
                TXTBX_Ville.Focus();
                return;
            }

            #endregion

                if (Action == "NOUVEAU")
                {
                    //Ajout de cette bibliothèque dans la base de données
                    NOUVEAU_Code_Biblio();
                    ListeBibliothèques.AJOUT_new(Reccupere_données());

                    //Message d'information enregistrement réussit
                    MessageBox.Show("Ajout dans la base de donnée réussit.");
                 }
                
            
                else
                {
                    if (Action == "MODIF")
                    {
                        //Message d'alerte avant de rétablir les anciennes saisies
                        MessageBox.Show("Etes-vous sûr de vouloir modifier les informations de cette bibliothèque ?", "Confirmation", MessageBoxButtons.YesNo);

                        if (DialogResult != DialogResult.Yes)
                        {
                            //Modification des données de cette bibliothèque dans la base de données
                            ListeBibliothèques.MAJ_liste_biblio(Reccupere_données());
                            //Message d'information enregistrement réussit
                            MessageBox.Show("Enregitrement des modifications réussit.");
                        }
                    }
                }

            // Alimentation du COMBO-BOX et DataGrid
            Init_Biblio();
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
            MessageBox.Show("Etes-vous sûr de vouloir réinitialiser les informations de cette bibliothèque ?", "Confirmation", MessageBoxButtons.YesNo);
            
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
        #region Actions dans le GROUPBOX données de la bibliothèque

        //Zone de saisie Code Bibliothèque
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

        //Zone de saisie Libellé
        /// <summary>
        /// Zone de saisie LIBELLE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTBX_Libelle_TextChanged(object sender, EventArgs e)
        {
            if (TXTBX_Libelle.Text.Length >= 1)
            {
                //Affiche bouton valider
                BTN_Enregistrer.Visible = true;
            }
        }

        //Zone de saisie Adresse
        /// <summary>
        /// Zone de saisie ADRESSE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTBX_Adresse_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins un caractère
            if (TXTBX_Adresse.Text.Length >= 1)
            {
                //Affiche bouton valider
                BTN_Enregistrer.Visible = true;
            }
        }

        //Zone de saisie Ville
        /// <summary>
        /// Zone de saisie Ville
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTBX_Ville_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins un caractère
            if (TXTBX_Ville.Text.Length >= 1)
            {
                //Affiche bouton valider
                BTN_Enregistrer.Visible = true;
            }
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
            int index = COMBO_SelectBiblio.SelectedIndex;

            try
            {
                bib_infos = ListeBibliothèques.biblio_PRECEDENT(); //Recuperation de la bibliothèque precedente
                Affiche_txtbox();
                COMBO_SelectBiblio.SelectedItem = bib_infos;

                if ((COMBO_SelectBiblio.SelectedIndex == 0))//Si haut de la liste
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
            int index = COMBO_SelectBiblio.SelectedIndex;

            try
            {
                bib_infos = ListeBibliothèques.biblio_SUIVANT(); //Recuperation de l'adherent suivant
                Affiche_txtbox();
                COMBO_SelectBiblio.SelectedItem = bib_infos;

                if (COMBO_SelectBiblio.SelectedIndex == COMBO_SelectBiblio.Items.Count - 1) //Si bas de la liste
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
        /// Bouton Mis A Jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_MAJ_Click(object sender, EventArgs e)
        {
            Init_Biblio();
            Invisible_DATAGRID_Fle();
            Visible_DATAGRID_Fle();
        }

        #endregion


        //*********************************************************
        //*************   Fermeture du formulaire    **************
        //*********************************************************
        /// <summary>
        /// Fermeture du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Bibliotheques_FormClosing(object sender, FormClosingEventArgs e)
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
            COMBO_SelectBiblio.Visible = true;
            COMBO_SelectBiblio.Enabled = true;
            LBL_SelectBiblio.Visible = true;
            PICBX_Biblio.Visible = true;

            //Boutons NOUVEAU / MODIFIER / SUPPRIMER
            BTN_Nouveau.Visible = true;
            BTN_Nouveau.Enabled = true;
            BTN_Modifier.Visible = false;
            BTN_Supprimer.Visible = false;

            //Les zones de saisies
            GRPBX_Données_Bibliothèque.Visible = false;

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
            COMBO_SelectBiblio.Visible = true;
            COMBO_SelectBiblio.Enabled = true;
            LBL_SelectBiblio.Visible = true;
            PICBX_Biblio.Visible = true;

            //Boutons NOUVEAU / MODIFIER / SUPPRIMER
            BTN_Nouveau.Visible = true;
            BTN_Nouveau.Enabled = true;
            BTN_Modifier.Visible = true;
            BTN_Modifier.Enabled = true;
            BTN_Supprimer.Visible = true;
            BTN_Supprimer.Enabled = true;

            //Les zones de saisies
            GRPBX_Données_Bibliothèque.Visible = true;
            GRPBX_Données_Bibliothèque.Enabled = false;
            TXTBX_CodeBiblio.Enabled = false;
            Enable_TXTBX_Code();

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
            COMBO_SelectBiblio.Visible = true;
            COMBO_SelectBiblio.Enabled = false;
            LBL_SelectBiblio.Visible = true;
            PICBX_Biblio.Visible = true;

            //Boutons NOUVEAU / MODIFIER / SUPPRIMER
            BTN_Nouveau.Visible = true;
            BTN_Nouveau.Enabled = false;
            BTN_Modifier.Visible = true;
            BTN_Modifier.Enabled = false;
            BTN_Supprimer.Visible = true;
            BTN_Supprimer.Enabled = false;

            //Les zones de saisies
            GRPBX_Données_Bibliothèque.Visible = true;
            GRPBX_Données_Bibliothèque.Enabled = true;
            Able_TXTBX_Code();
            TXTBX_CodeBiblio.Enabled = false;

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
            COMBO_SelectBiblio.Visible = true;
            COMBO_SelectBiblio.Enabled = true;
            LBL_SelectBiblio.Visible = true;
            PICBX_Biblio.Visible = true;

            //Boutons NOUVEAU / MODIFIER / SUPPRIMER
            BTN_Nouveau.Visible = true;
            BTN_Nouveau.Enabled = true;
            BTN_Supprimer.Visible = false;
            BTN_Modifier.Visible = false;

            //Les zones de saisies
            GRPBX_Données_Bibliothèque.Visible = true;
            GRPBX_Données_Bibliothèque.Enabled = false;
            TXTBX_CodeBiblio.Enabled = false;

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
            GRPBX_Données_Bibliothèque.Enabled = false;
            TXTBX_CodeBiblio.Enabled = false;
            TXTBX_Libelle.Enabled = false;
            TXTBX_Adresse.Enabled = false;
            TXTBX_CodePostal.Enabled = false;
            TXTBX_Ville.Enabled = false;
        }

        /// <summary>
        /// Visibilité des contrôles désactivation des textbox
        /// </summary>
        void Able_TXTBX_Code()
        {
            //Désactive les zones de saisies des codes
            GRPBX_Données_Bibliothèque.Enabled = true;
            TXTBX_CodeBiblio.Enabled = false;
            TXTBX_Libelle.Enabled = true;
            TXTBX_Adresse.Enabled = true;
            TXTBX_CodePostal.Enabled = true;
            TXTBX_Ville.Enabled = true;
        }

        /// <summary>
        /// Visibilité datagridview 
        /// </summary>
        void Visible_DATAGRID_Fle()
        {
            //Rend visible le tableau et les flèches suivant et precedent
            DTGRD_Biblio.Visible = true;
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
            DTGRD_Biblio.Visible = false;
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
        /// Init_Biblio() / Actualisation de la liste des bibliothèques
        /// </summary>
        void Init_Biblio()
        {
            // Alimentation des noms des bibliothèques dans la liste Box
            alimenter_combobox();
            // Association du DATAGRIDVIEW à la source de données
            alimenter_Datagrid();
        }

        // COMBOBOX Bibliothèques
        /// <summary>
        /// Alimentation du COMBO-BOX
        /// </summary>
        private void alimenter_combobox()
        {
            // Initialisation de la liste des bibliothèques
            COMBO_SelectBiblio.DataSource = null;
            COMBO_SelectBiblio.Items.Clear();

            // Initialisation du COMBO sélectionnez une bibliothèque
            COMBO_SelectBiblio.DataSource = ListeBibliothèques.Liste_Bibliotheque(); //Recuperation de la liste des bibliothèques
            COMBO_SelectBiblio.DisplayMember = "Libelle"; //Données affichée dans le combobox
            COMBO_SelectBiblio.ValueMember = "CodeBiblio"; //Donnée sélectionnée par laquelle sont retrouvées les autres données
            COMBO_SelectBiblio.SelectedIndex = -1; //Débute par une zone vide
        }

        // DATAGRIDVIEW Bibliothèques
        /// <summary>
        /// Alimentation du DATAGRID
        /// </summary>
        private void alimenter_Datagrid()
        {
            // Association du DATAGRIDVIEW à la source de données
            DTGRD_Biblio.DataSource = null;
            DTGRD_Biblio.DataSource = ListeBibliothèques.Liste_Bibliotheque(); //Recuperation de la liste des bibliothèques
        }

        /// <summary>
        /// Affiche_txtbox()
        /// </summary>
        void Affiche_txtbox()
        {
            //Affichage de la bibliothèque COURANTE (celle selectionnée dans le combobox)
            TXTBX_CodeBiblio.Text = bib_infos.CodeBiblio; //Code biblio
            TXTBX_Libelle.Text = bib_infos.Libelle; //Libellé
            TXTBX_Adresse.Text = bib_infos.Adresse; //Adresse
            TXTBX_CodePostal.Text = bib_infos.CodePostal.ToString(); //Code Postal
            TXTBX_Ville.Text = bib_infos.Ville; //Ville
        }

        /// <summary>
        /// Efface_Textbox()
        /// </summary>
        void Efface_Textbox()
        {
            TXTBX_CodeBiblio.Text = "";
            TXTBX_Libelle.Text = "";
            TXTBX_Adresse.Text = "";
            TXTBX_CodePostal.Text = "";
            TXTBX_Ville.Text = "";
        }

        /// <summary>
        /// Récupèration des données des zones de saisies pour constituer une bibliothèque
        /// </summary>
        /// <returns>Bibliothèque</returns>
        Bibliotheque Reccupere_données()
        {
            Bibliotheque bib = new Bibliotheque();
            //Génère le code Biblio à partir de l'indice et du labelle
            bib.CodeBiblio = TXTBX_CodeBiblio.Text;
            bib.Libelle = TXTBX_Libelle.Text;
            bib.Adresse = TXTBX_Adresse.Text;
            //bib.CodePostal = Convert.ToInt32(TXTBX_CodePostal.Text);
            //bib.Ville = TXTBX_Ville.Text;

            return bib;
        }

        /// <summary>
        /// Affiche_logo()
        /// </summary>
        void Affiche_logo()
        {
            switch (TXTBX_Libelle.Text)
            {
                case "DEP01" :
                PICBX_Biblio.Image = new Bitmap(Properties.Resources.centre_culturel_M);
                break;

                case "AGR03":
                PICBX_Biblio.Image = new Bitmap(Properties.Resources.centre_culturel_M);
                break;

                case "AMN02":
                PICBX_Biblio.Image = new Bitmap(Properties.Resources.centre_culturel_M);
                break;

                default:
                PICBX_Biblio.Image = new Bitmap(Properties.Resources.centre_culturel_M);
                break;
            }
        }

        //*********************************************************
        //********   Création NOUVEAU Code bibliothèque     *******
        //*********************************************************
        /// <summary>
        /// Création NOUVEAU Code bibliothèque
        /// </summary>
        void NOUVEAU_Code_Biblio()
        {
            //Recherche et suppression du mot bibliothèque
            string Libel = TXTBX_Libelle.Text.ToUpper();
            char[] mot = {'B', 'I', 'L', 'O', 'T', 'H', 'E', 'U', ' '};
            string Libel_valide = Libel.TrimStart(mot);
            Console.WriteLine(Libel_valide);

            //Assemblage du code provisoir
            string code_provisoir = TXTBX_CodeBiblio.Text;
            string debut_Libel = Libel_valide.Substring(0, 3); //Reprendre les 3 permiers caratères du libellé
            TXTBX_CodeBiblio.Text = debut_Libel + "0" + code_provisoir ;
        }

        #endregion

        //*********************************************************
        //****************** Contrôle de saisie  ******************
        //*********************************************************
        #region Contrôles de saisie
        
        //LIBELLE
        /// <summary>
        /// Contrôles de saisie LIBELLE
        /// </summary>
        /// <param name="tlibelle">string</param>
        /// <returns>Résultat fonction IsMatch</returns>
        static bool Libelle_Valide(string tlibelle)
        {
            //Si saisie minimale d'au moins un caractère
            return tlibelle.Length >= 1;
        }

        //ADRESSE
        /// <summary>
        /// Contrôles de saisie ADRESSE
        /// </summary>
        /// <param name="tadresse">string</param>
        /// <returns>Résultat fonction IsMatch</returns>
        static bool Adresse_Valide(string tadresse)
        {
            //Si saisie minimale d'au moins un caractère
            return tadresse.Length >= 1;
        }

        //CODE POSTAL
        /// <summary>
        /// Contrôles de saisie CODE POSTAL
        /// </summary>
        /// <param name="tcp">string</param>
        /// <returns>Résultat fonction IsMatch</returns>
        static bool CodePostal_Valide(string tcp)
        {
            //Saisie de 5 entiers
            return Regex.IsMatch(tcp, @"^[0-9]{5}$");
        }

        //VILLE
        /// <summary>
        /// Contrôles de saisie VILLE
        /// </summary>
        /// <param name="tville">string</param>
        /// <returns>Résultat fonction IsMatch</returns>
        static bool Ville_Valide(string tville)
        {
            //Si saisie minimale d'au moins un caractère
            return Regex.IsMatch(tville, @"^[A-Za-z]+$");
        }

        #endregion


    }
}
