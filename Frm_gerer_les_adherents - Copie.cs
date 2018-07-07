using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblio_class;
using System.Data.Common;
using Couche_DAO;

namespace WindowsFormsApplication1 // A FINIR !!!!!!
{
    public partial class Frm_Gerer_les_adherents : Form
    {
        Adherents tabAdherent = new Adherents(); // créer une instance pour utiliser une methode de classe dans un formulaire. SI STATIC, ON UTILISE ALORS LA CLASSE
        Adherents ListAdh;

        int choix = 0; // 1 = "Nouveau" ; 2 = "Modifier" ; 3 = "Supprimer"
        int choixRDButton = 0; // 1 = "Tous les adherents" ; 2 = "Par numéro" ; 3 = "Par nom"

        public Frm_Gerer_les_adherents()
        {
            InitializeComponent();
        }

        private void Frm_Gerer_les_adherents_Load(object sender, EventArgs e)
        {
            ListAdh = new Adherents();
            ListAdh.init();
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            #region Evenements simple (Visible, Checked, Text, Enabled ...)
            grpbox_actions.Visible = false;
            grpbox_recherche.Visible = true;
            grpbox_infos.Visible = true;
            grpbox_enreg_effacer.Visible = true;
            btn_abondon.Visible = true;

            rdbtn_tous_les_adh.Checked = false;
            rdbtn_par_num_adh.Checked = false;
            rdbtn_par_nom.Checked = false;

            txtbox_rechercher.Text = "";
            txtbox_numadherent.Enabled = true;

            grpbox_infos.Enabled = true;
            grpbox_recherche.Enabled = false;
            grpbox_enreg_effacer.Enabled = true;

            txtbox_nom.Focus();

            choix = 1;

            #endregion
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            #region Evenements simple (Visible, Checked, Text, Enabled ...)
            txtbox_nom.Focus();

            grpbox_recherche.Visible = true;
            grpbox_infos.Visible = true;
            grpbox_enreg_effacer.Visible = true;
            grpbox_actions.Visible = false;
            btn_abondon.Visible = true;

            rdbtn_tous_les_adh.Checked = false;
            rdbtn_par_num_adh.Checked = false;
            rdbtn_par_nom.Checked = false;

            txtbox_rechercher.Text = "";
            txtbox_numadherent.Enabled = false;


            grpbox_infos.Enabled = true;
            grpbox_recherche.Enabled = true;
            grpbox_enreg_effacer.Enabled = true;

            choix = 2;

            #endregion
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            #region Evenements simple (Visible, Checked, Text, Enabled ...)
            grpbox_actions.Visible = false;
            grpbox_recherche.Visible = true;
            grpbox_infos.Visible = true;
            grpbox_enreg_effacer.Visible = true;
            btn_abondon.Visible = true;

            txtbox_rechercher.Text = "";
            txtbox_numadherent.Enabled = false;

            grpbox_infos.Enabled = false;
            grpbox_recherche.Enabled = true;
            grpbox_enreg_effacer.Enabled = true;

            choix = 3;

            #endregion
        }

        private void btn_abondon_Click(object sender, EventArgs e)
        {
            #region Evenement simple (Visible, Checked, Text, Enabled ...)
            txtbox_numadherent.Enabled = true;

            btn_abondon.Visible = false;
            grpbox_actions.Visible = true;
            grpbox_enreg_effacer.Visible = false;
            grpbox_infos.Visible = true;
            grpbox_recherche.Visible = true;
            txtbox_rechercher.Visible = false;
            btn_rechercher.Visible = false;

            rdbtn_tous_les_adh.Checked = false;
            rdbtn_par_num_adh.Checked = false;
            rdbtn_par_nom.Checked = false;

            btn_nouveau.Enabled = true;
            btn_modifier.Enabled = true;
            btn_supprimer.Enabled = true;
            grpbox_infos.Enabled = false;
            grpbox_recherche.Enabled = true;
            datagridview_adherents.Enabled = false;

            // on efface tout le contenu des textbox, avant de retourner à l'état initiale.
            txtbox_adr_mail.Text = "";
            txtbox_adresse.Text = "";
            txtbox_codepostal.Text = "";
            txtbox_motdepasse.Text = "";
            txtbox_nom.Text = "";
            txtbox_numadherent.Text = "";
            txtbox_prenom.Text = "";
            txtbox_rechercher.Text = "";
            txtbox_telephone.Text = "";
            txtbox_ville.Text = "";
            DTPicker_perime_le.Value = DateTime.Now;
            txtbox_rechercher.Text = ""; //  à revoir l'utilité
            

            btn_nouveau.Focus();

            choix = 0;
            choixRDButton = 0;

            #endregion
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            // On charge la liste des adherents
            ListAdh = new Adherents();
            datagridview_adherents.DataSource = null; // On on est déjà passé ==> annuler l'association du DATAGRID

            //if (rdbtn_tous_les_adh.Checked)
            //{
            //    datagridview_adherents.DataSource = ListAdh;
            //}
            try
            {
                while (txtbox_rechercher.Text.Length < 3)
                {
                    if (rdbtn_par_num_adh.Checked)
                    {
                        datagridview_adherents.Visible = true;
                        datagridview_adherents.Enabled = true;
                        datagridview_adherents.DataSource = ListAdh.Recherche_par_num(Convert.ToInt32(txtbox_rechercher.Text));
                    }
                    else
                    {
                        if (rdbtn_par_nom.Checked)
                        {
                            datagridview_adherents.Visible = true;
                            datagridview_adherents.Enabled = true;
                            datagridview_adherents.DataSource = ListAdh.Recherche_par_nom(txtbox_rechercher.Text);
                        }
                        else
                        {
                            MessageBox.Show("INSERER UN VALEUR");
                        }
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void bnt_effacer_Click(object sender, EventArgs e)
        {
            #region Evenements simple (chaines vides partout)
            txtbox_adr_mail.Text = "";
            txtbox_adresse.Text = "";
            txtbox_codepostal.Text = "";
            txtbox_motdepasse.Text = "";
            txtbox_nom.Text = "";
            txtbox_numadherent.Text = "";
            txtbox_prenom.Text = "";
            txtbox_rechercher.Text = "";
            txtbox_telephone.Text = "";
            txtbox_ville.Text = "";
            DTPicker_perime_le.Value = DateTime.Now;
            txtbox_rechercher.Text = ""; //  à revoir l'utilité
            #endregion
        }

        private void rdbtn_tous_les_adh_CheckedChanged(object sender, EventArgs e)
        {
            #region Evenement simple (Visible, Checked, Text, Enabled ...)
            txtbox_rechercher.Visible = false;
            btn_rechercher.Visible = false;

            txtbox_rechercher.Text = "";

            btn_modifier.Enabled = true;
            btn_supprimer.Enabled = true;
            datagridview_adherents.Enabled = true;

            if (rdbtn_tous_les_adh.Checked)
            {
                datagridview_adherents.DataSource = ListAdh;
            }
            else
            {
                datagridview_adherents.DataSource = null;
            }

            choixRDButton = 1;
            #endregion
        }

        private void rdbtn_par_num_adh_CheckedChanged(object sender, EventArgs e)
        {
            #region Evenement simple (Visible, Checked, Text, Enabled ...)
            txtbox_rechercher.Visible = true;
            btn_rechercher.Visible = true;

            btn_modifier.Enabled = true;
            btn_supprimer.Enabled = true;
            datagridview_adherents.Enabled = true;
            grpbox_infos.Enabled = false;

            choixRDButton = 2;
            #endregion
        }

        private void rdbtn_par_nom_CheckedChanged(object sender, EventArgs e)
        {
            #region Evenement simple (Visible, Checked, Text, Enabled ...)
            txtbox_rechercher.Visible = true;
            btn_rechercher.Visible = true;

            btn_modifier.Enabled = true;
            btn_supprimer.Enabled = true;

            grpbox_infos.Enabled = false;
            grpbox_infos.Enabled = false;

            choixRDButton = 3;
            #endregion
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            //    tabAdherent.Ajoute(txtbox_numadherent.Text, txtbox_nom.Text, txtbox_prenom.Text, Convert.ToInt32(numerUpD_numderue.Text), txtbox_adresse.Text, Convert.ToInt32(txtbox_codepostal.Text), txtbox_ville.Text, txtbox_telephone.Text, txtbox_adr_mail.Text, DTPicker_perime_le.Value, txtbox_motdepasse.Text);

            /* Si le bouton Nouveau à été cliqué */
            if (choix == 1)
            {
                try
                {
                    if (txtbox_numadherent.Text.Length < 3 || txtbox_nom.Text.Length < 3 ||
                        txtbox_prenom.Text.Length < 3 || numerUpD_numderue.Text.Length < 1 ||
                        txtbox_adresse.Text.Length < 3 || txtbox_codepostal.Text.Length < 2 ||
                        txtbox_ville.Text.Length < 2 || txtbox_telephone.Text.Length < 10 ||
                        txtbox_adr_mail.Text.Length < 6 || txtbox_motdepasse.Text.Length < 3)
                    {
                        MessageBox.Show("ACTION NON EFFECTUER !\nUn ou plusieurs sont ne sont pas correctement remplir ou vide.");
                        return;
                    }
                    else
                    {
                        Adherent a = new Adherent
                        {
                            NumeroAdherent = txtbox_numadherent.Text,
                            Nom = txtbox_nom.Text,
                            Prenom = txtbox_prenom.Text,
                            NumeroDeRue = Convert.ToInt32(numerUpD_numderue.Text),
                            NomDeRue = txtbox_adresse.Text,
                            CodePostal = Convert.ToInt32(txtbox_codepostal.Text),
                            Ville = txtbox_ville.Text,
                            Telephone = txtbox_telephone.Text,
                            Mail = txtbox_adr_mail.Text,
                            PerimeLe = DTPicker_perime_le.Value,
                            Password = txtbox_motdepasse.Text
                        };
                        Adherents Adh = new Adherents();
                        Adh.Add(a);
                        MessageBox.Show("ADHERENT AJOUTER !");
                        return; 
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERREUR !");
                }
            }

            /* Si le bouton Modifier à été cliqué */
            if (choix == 2)
            {
                try
                {
                    if (txtbox_numadherent.Text.Length < 3 || txtbox_nom.Text.Length < 3 ||
                        txtbox_prenom.Text.Length < 3 || numerUpD_numderue.Text.Length < 1 ||
                        txtbox_adresse.Text.Length < 3 || txtbox_codepostal.Text.Length < 2 ||
                        txtbox_ville.Text.Length < 2 || txtbox_telephone.Text.Length < 10 ||
                        txtbox_adr_mail.Text.Length < 6 || txtbox_motdepasse.Text.Length < 3)
                    {
                        MessageBox.Show("ACTION NON EFFECTUER !\nUn ou plusieurs sont ne sont pas correctement remplir ou vide.");
                        return;
                    }
                    else
                    {
                        Adherent a = new Adherent
                        {
                            NumeroAdherent = txtbox_numadherent.Text,
                            Nom = txtbox_nom.Text,
                            Prenom = txtbox_prenom.Text,
                            NumeroDeRue = Convert.ToInt32(numerUpD_numderue.Text),
                            NomDeRue = txtbox_adresse.Text,
                            CodePostal = Convert.ToInt32(txtbox_codepostal.Text),
                            Ville = txtbox_ville.Text,
                            Telephone = txtbox_telephone.Text,
                            Mail = txtbox_adr_mail.Text,
                            PerimeLe = DTPicker_perime_le.Value,
                            Password = txtbox_motdepasse.Text
                        };
                        Adherents Adh = new Adherents();
                        Adh.Add(a);
                        MessageBox.Show("ADHERENT MODIFIER !");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERREUR !");
                }
            }

            /* Si le bouton Supprimer à été cliqué */
            if (choix == 3)
            {
                try
                {
                    Adherent a = new Adherent();
                    Adherents Adh = new Adherents();
                    Adh.Remove(a);
                    MessageBox.Show("ADHERENT SUPPRIMER !");
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("ERREUR !");
                }
            }
        }

        private void txtbox_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* ne permet seulement l'entrer de lettre  */
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) || Char.IsNumber(e.KeyChar) || txtbox_nom.Text.Length == 50)
            {
                e.Handled = true;
            }
        }

        private void txtbox_codepostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* ne permet seulement l'entrer de nombre */
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtbox_numadherent_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* ne permet seulement l'entrer de nombre */
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtbox_telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* ne permet seulement l'entrer de nombre */
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtbox_prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* ne permet seulement l'entrer de lettre  */
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) || Char.IsNumber(e.KeyChar) || txtbox_nom.Text.Length == 50)
            {
                e.Handled = true;
            }
        }

        private void txtbox_adresse_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* ne permet seulement l'entrer de lettre  */
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) || Char.IsNumber(e.KeyChar) || txtbox_nom.Text.Length == 50)
            {
                e.Handled = true;
            }
        }

        private void txtbox_ville_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* ne permet seulement l'entrer de lettre  */
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) || Char.IsNumber(e.KeyChar) || txtbox_nom.Text.Length == 50)
            {
                e.Handled = true;
            }
        }

        private void datagridview_adherents_SelectionChanged(object sender, EventArgs e)
        {
            grpbox_infos.Enabled = true;
        }
    }
}