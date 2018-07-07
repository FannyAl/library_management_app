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
    public partial class Frm_gerer_les_bibliotheques : Form
    {
        public Frm_gerer_les_bibliotheques()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etes-vous sûr de vouloir supprimer cette bibliothèque ?", "Confirmation", MessageBoxButtons.YesNo);
            B_supprimer.Visible = false;
            B_Modifier.Visible = false;
            B_Enregistrer.Enabled = false;
            B_Effacer.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enregitrement dans la base de donnée réussit.");
            B_Enregistrer.Enabled = false;
            B_Effacer.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etes-vous sûr de vouloir réinitialiser les informations de cette bibliothèque ?", "Confirmation", MessageBoxButtons.YesNo);
            B_Enregistrer.Enabled = false;
            B_Effacer.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GB_Données_Bibliothèque.Visible = true;
            B_Modifier.Visible = true;
            B_supprimer.Visible = true;
            B_Retour_Menu.Visible = true;
            B_détails.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void B_Nouveau_Click(object sender, EventArgs e)
        {
            GB_Données_Bibliothèque.Visible = true;
            B_Retour_Menu.Visible = true;
            B_détails.Visible = true;
            B_Modifier.Visible = false;
            B_supprimer.Visible = false;
        }

        private void B_Modifier_Click(object sender, EventArgs e)
        {
            GB_Données_Bibliothèque.Visible = true;
            B_supprimer.Visible = true;
            B_Retour_Menu.Visible = true;
            B_détails.Visible = true;
            B_Effacer.Visible = true;
            MessageBox.Show("Saisissez directement vos modifications dans les zones de saisies.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            B_Enregistrer.Visible = true;
            B_Effacer.Visible = true;
            B_Enregistrer.Enabled = true;
            B_Effacer.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            B_Enregistrer.Visible = true;
            B_Effacer.Visible = true;
            B_Enregistrer.Enabled = true;
            B_Effacer.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            B_Enregistrer.Visible = true;
            B_Effacer.Visible = true;
            B_Enregistrer.Enabled = true;
            B_Effacer.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            B_Enregistrer.Visible = true;
            B_Effacer.Visible = true;
            B_Enregistrer.Enabled = true;
            B_Effacer.Enabled = true;
        }

        private void B_Retour_Menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etes-vous sûr de vouloir quitter cette fenêtre ?", "Confirmation", MessageBoxButtons.YesNo);
            Close();
        }

        private void B_détails_Click(object sender, EventArgs e)
        {
            DG_Bibliothèque.Visible = true;
            B_less.Visible = true;
        }

        private void B_less_Click(object sender, EventArgs e)
        {
            DG_Bibliothèque.Visible = false;
            B_less.Visible = false;
        }

        private void DG_Bibliothèque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GB_Données_Bibliothèque.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_gerer_les_bibliotheques_Load(object sender, EventArgs e)
        {

        }
    }
}
