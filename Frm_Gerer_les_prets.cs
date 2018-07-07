using Biblio_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_Gerer_les_prets : Form
    {
       //..........................
        //Initialisation_Des_List... 
        //..........................

        Adherents ListAdherents;
        Exemplaires ListExemplaires;
        Emprunts ListEmprunts;
        
        public Frm_Gerer_les_prets()
        {
            InitializeComponent();
        }


        //........................................................................................
        private void Frm_Gerer_les_prets_Load(object sender, EventArgs e)//Démarrage fromulaire
        {
            
            ListEmprunts = new Emprunts();
            ListEmprunts.init();

            //.................
            //ListExemplaire... 
            //.................

            ListExemplaires = new Exemplaires();
            ListExemplaires.init();

            ListAdherents = new Adherents();
            ListAdherents.init();

            //...........................
            //comboBox_Code_Exemplaire...
            //...........................
           
            comboBox_Code_Exemplaire.DataSource = ListExemplaires;

            comboBox_Code_Exemplaire.DisplayMember = "Numéro Exemplaire";
            comboBox_Code_Exemplaire.ValueMember = "NumeroExemplaire";
            comboBox_Code_Exemplaire.Text = "Code exemplaire";

            //............................................
            //ComboBox Recherhe Avancée Code Exemplaire...
            //............................................
            comboBox_Recherhe_Avancée_Code_Exemplaire.DataSource = ListExemplaires;

            comboBox_Recherhe_Avancée_Code_Exemplaire.DisplayMember = "Numéro Exemplaire";
            comboBox_Recherhe_Avancée_Code_Exemplaire.ValueMember = "NumeroExemplaire";
            comboBox_Recherhe_Avancée_Code_Exemplaire.Text = "Code exemplaire";
            
            

            //.................
            //ListeAdherents... 
            //.................


            

            //........................
            //comboBox_Num_Adhérent...
            //........................

            comboBox_Num_Adhérent.DataSource = ListAdherents;

            comboBox_Num_Adhérent.DisplayMember = "Num";
            comboBox_Num_Adhérent.ValueMember = "NumeroAdherent";
            comboBox_Num_Adhérent.Text = "Num";

            //........................
            //comboBox_Nom_Adhérent...
            //........................

            comboBox_Nom_Adhérent.DataSource = ListAdherents;

            comboBox_Nom_Adhérent.DisplayMember = "nom";
            comboBox_Nom_Adhérent.ValueMember = "Nom";
            comboBox_Nom_Adhérent.Text = "Nom";
        }


        //.....................//
        //GroupBox Ajouter Prêt//
        //.....................//
        
        #region//GroupeBox1

        #region//Botton

        //........................................................................................
        private void Recherche_Nom_Adherent(object sender, EventArgs e)//Recherche_Nom_Adherent
        {

            groupBox_recherche_Avancée.Visible = true;
            groupBox_Ajouter_Prêt.Visible = false;
            //comboBox_Nom_Adhérent.Focus();
            comboBox_Nom_Adhérent.Text = "Nom";

          
        }

        //........................................................................................
        private void button_Valider_Prêt_Click(object sender, EventArgs e)//Button Valider Prêt
        {
            Biblio_class.Emprunt Ok = new Emprunt();
            Ok.NumAdherent = comboBox_Num_Adhérent.Text;
            Ok.NumExemplaire = Convert.ToInt32((comboBox_Code_Exemplaire.SelectedItem as Exemplaire).NumeroExemplaire);
            Ok.DateJ = DateTime.Now;
            Ok.DateRestitutionEffective = new DateTime(9999, 12, 31);
            ListEmprunts.Ajoute(Ok);
            MessageBox.Show("le prêt c'est bien enregistrer ");
            comboBox_Code_Exemplaire.Text = "";
        }

        //......................................................................................
        private void button_Retour_Menu_Click(object sender, EventArgs e)//Button Retour Menu
        {
            Close();
        }

        #endregion//FinButton

        #region//ComboBox

        //................................................................................
        private void comboBox_Num_Adhérent_KeyPress(object sender, KeyPressEventArgs e)//ComboBox Num Adhérent " KeyPress "
        {
            if ((!char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        //..........................................................................................................................
        private void comboBox_Code_Exemplaire_KeyPress(object sender, KeyPressEventArgs e)//ComboBox Code Exemplaire " KeyPress "
        {
            if ((!char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
       
        #endregion//FinComBox

        #endregion//FinGrouBox1


        //...........................//
        //GrouoeBox Recherche Avancée//
        //...........................//
        
        #region//GroupeBox2

        #region//Button

        //............................................................................................
        private void button_Precedent_Click(object sender, EventArgs e)//Button Precedent " Click "
        {
            groupBox_recherche_Avancée.Visible = false;
            groupBox_Ajouter_Prêt.Visible = true;
            comboBox_Num_Adhérent.Focus();
        }

        //.......................................................................................................................
        private void button_Valider_Prêt_GroupBox2_Click(object sender, EventArgs e)//Button Valider Prêt GroupBox2 " Click " 
        {
            Biblio_class.Emprunt Ok = new Emprunt();
            //Ok.NumAdherent = (comboBox_Nom_Adhérent.SelectedItem as Adherent).NumeroAdherent.ToString();
            //Ok.NumExemplaire = Convert.ToInt32((comboBox_Recherhe_Avancée_Code_Exemplaire.SelectedItem as Exemplaire).CodeExemplaire);
            Ok.NumAdherent = "demo1";
            Ok.NumExemplaire = 1500;
            Ok.DateJ = DateTime.Now;

            ListEmprunts.Ajoute(Ok);
            MessageBox.Show("le prêt c'est bien enregistrer ");
        }
       
        //...................................................................................................................
        private void button_Retour_Menu_GroupBox2_Click(object sender, EventArgs e)//Button Retou Menu GroupBox2 " Click "
        {
            Close();
        }
        
        #endregion//FinButton

        #region//ComboBox

        //.....................................................................................................................
        private void comboBox_Nom_Adhérent_KeyPress(object sender, KeyPressEventArgs e)//ComboBox Nom Adhérent " KeyPressz "
        {
            if ((!char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;

            }
        }

        //............................................................................................................................................................
        private void comboBox_Recherhe_Avancée_Code_Exemplaire_KeyPress(object sender, KeyPressEventArgs e)//ComboBox Recherhe Avancée Code Exemplaire " KeyPress "
        {
            if ((!char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        #endregion

        #endregion//FinGroupBox2

    }
}

