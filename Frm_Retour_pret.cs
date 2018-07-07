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
    public partial class Frm_Retour_pret : Form
    {
        Emprunts tab = new Emprunts();
        Emprunts ListRetourPrêt;
        Adherents listeAdhrents;
       
        public Frm_Retour_pret()
        {
            InitializeComponent();
        }


        //....................................................................................
        private void Frm_Retour_pret_Load(object sender, EventArgs e)//Démarrage fromulaire
        {
            listeAdhrents = new Adherents();
            listeAdhrents.init();
            // Initialisation de le list Emprunt
            ListRetourPrêt = new Emprunts(); 
            ListRetourPrêt.init();// Chargement de la list Emprunt


            comboBox_Code_Exemplaire.DataSource = ListRetourPrêt;
            comboBox_Code_Exemplaire.DisplayMember = "Code Exemplaire";
            comboBox_Code_Exemplaire.ValueMember = "NumExemplaire";
            comboBox_Code_Exemplaire.Text = "Code Exemplaire";

            //dateTimePicker_Date_Prêt = ListRetourPrêt;
            
            

            button_Lancer_Recherche_Par.Enabled = false;

            comboBox_Code_Exemplaire.Focus();
        }

        //GroupBox Retour Prêt
        #region//GroupBox1//

        #region//Button

        //............................................................................................................
        private void button_Recherche_Par_Adherent_Click(object sender, EventArgs e)//Button Recherche Par Adherent
        {

            groupBox_rechecher_Par_Adhérent.Visible = true;
            groupBox_Retour_Prêt.Visible = false;
            textBox_Recherhe_Avancée_Nom_Adrérent.Text = "Entrez nom Adrérent";
            textBox_Recherhe_Avancée_Nom_Adrérent.Focus();
        }

        //..................................................................................................
        private void button_Valider_Retour_Click(object sender, EventArgs e)//Button Valider Retour Click
        {
            Emprunt Ok = new Emprunt();
            Ok.DateRestitutionEffective = Convert.ToDateTime(dateTimePicker_Date_Retour);

            MessageBox.Show("Le livre est de nouveau disponible");
        }

        //......................................................................................
        private void button_Retour_Menu_Click(object sender, EventArgs e)//Button Retour Menu
        {
            Close();
        }
        #endregion//FinButton

        #endregion//FinGroupeBox1

        //GroupBox rechecher Par Adhérent
        #region//Groupbox2

        #region//Button
        //...................................................................................................
        private void radioButton_Par_Nom_CheckedChanged(object sender, EventArgs e)//RadioButton Par "Nom"
        {
            if (radioButton_Par_Nom.Checked == true)
            {
               
                radioButton_Par_Num.Checked = false;
                textBox_Recherhe_Avancée_Nom_Adrérent.Text = "Entrez nom Adrérent";
                button_Lancer_Recherche_Par.Enabled = true;
            }
            else
            {
                dataGridView_Liste_Adhérent.DataSource = null;
            }

        }

        //...............................................................................................
        private void radioButton_Par_Num_CheckedChanged(object sender, EventArgs e)//RadioButton Par "Num"
        {
            if (radioButton_Par_Num.Checked == true)
            {
                dataGridView_Liste_Adhérent.Enabled = true;
                radioButton_Par_Nom.Checked = false;
                textBox_Recherhe_Avancée_Nom_Adrérent.Text = "Entrez numéro Adrérent";
                button_Lancer_Recherche_Par.Enabled = true;
                textBox_Recherhe_Avancée_Nom_Adrérent.Focus();
            }
            else
            {
                dataGridView_Liste_Adhérent.DataSource = null;
            }
        }

        //........................................................................................................
        private void button_Lancer_Recherche_Par_Click(object sender, EventArgs e)//Button Lancer Recherche Par
        {
            if (radioButton_Par_Nom.Checked == true)
            {
                Adherents a = new Adherents();
                a.Recherche_par_nom(textBox_Recherhe_Avancée_Nom_Adrérent.Text);
                //a.Recherche_par_Prefixe_Nom(textBox_Recherhe_Avancée_Nom_Adrérent.Text);
                dataGridView_Liste_Adhérent.DataSource = listeAdhrents.Recherche_par_nom(textBox_Recherhe_Avancée_Nom_Adrérent.Text);
            }
            if (radioButton_Par_Num.Checked == true)
            {
                Adherents a = new Adherents();
             //   a.Recherche_par_num(textBox_Recherhe_Avancée_Nom_Adrérent.Text);
            //    dataGridView_Liste_Adhérent.DataSource = listeAdhrents.Recherche_par_num(textBox_Recherhe_Avancée_Nom_Adrérent.Text);
            }
            
           // dataGridView_Liste_Adhérent.DataSource = ListRetourPrêt.Recherche_par_num(textBox_Recherhe_Avancée_Nom_Adrérent.Text);
            MessageBox.Show("Recherche en cours veuillez patienter");
        }

        //..........................................................................................................................
        private void button_Valider_Prêt_Recherhe_Avancée_Click(object sender, EventArgs e)//Button Valider Prêt Recherhe Avancée
        {
            groupBox_rechecher_Par_Adhérent.Visible = false;
            groupBox_rechecher_Par_Adhérent.Visible = false;
            groupBox_Retour_Prêt.Visible = true;
         // dataGridView_Liste_Adhérent.SelectedCells = (Convert.ToInt32(comboBox_Code_Exemplaire.SelectedItem as Emprunt).NumAdherent);
        }

        //..............................................................................................................
        private void button_Retour_Recherhe_Avancée_Click(object sender, EventArgs e)//Button Retour Recherhe Avancée
        {
            groupBox_rechecher_Par_Adhérent.Visible = false;
            groupBox_Retour_Prêt.Visible = true;
        }
        #endregion//FinButton

        #region//ComboxBox
        //..................................................................................................................................................
        private void comboBox_Recherhe_Avancée_Nom_Adrérent_Click(object sender, EventArgs e)//ComboBox_comboBox_Recherhe_Avancée "Nom" ou "Num" Adrérent
        {
            button_Lancer_Recherche_Par.Enabled = true;

        }
        #endregion//FinComboBox

        private void label_Date_du_prêt_Click(object sender, EventArgs e)
        {

        }

        #endregion//FinGroupBox2 

        private void textBox_Recherhe_Avancée_Nom_Adrérent_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Recherhe_Avancée_Nom_Adrérent.Text == "")
	            {
                    button_Lancer_Recherche_Par.Enabled = true;
	            }      
             
        }

        private void dataGridView_Liste_Adhérent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string select = dataGridView_Liste_Adhérent.Rows[e.RowIndex].Cells[0].Value.ToString();
            Emprunt emp = tab.Recherche_par_num(select);
            dataGridView_Liste_Adhérent.ClearSelection();
            //Emprunt temp = ListRetourPrêt.Recherche_du_pret(select);
            dataGridView_Liste_Adhérent.DataSource = ListRetourPrêt.Recherche_du_pret(select);
           // string select2 = dataGridView_Liste_Adhérent.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Emprunt em = tab.Recherche_Du_pret(select2);
           // Class_Adherent AdherNum = TabAdher.Recherche_Numero(select);
        }

      

    }
}
