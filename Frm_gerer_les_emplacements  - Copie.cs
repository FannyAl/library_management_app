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
    public partial class Frm_gerer_les_emplacements : Form
    {
        public Frm_gerer_les_emplacements()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enregistrement réussit !");
            B_enregistrer.Enabled = false;
            B_Effacer.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gp_données_emplacement.Visible = true;
            B_Retour_menu.Visible = true;
            B_Supprimer.Visible = true;
            B_détails.Visible = true;
            B_modifier.Visible = true;
            Label_Thème.Visible = false;
            comboBox_Thème.Visible = false;
            DG_emplacements.Visible = false;
            B_less.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gp_données_emplacement.Visible = true;
            Label_Thème.Visible = true;
            comboBox_Thème.Visible = true;
            B_Retour_menu.Visible = true;
            B_détails.Visible = true;
            DG_emplacements.Visible = false;
            B_less.Visible = false;
            B_Supprimer.Visible = false;
            B_modifier.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gp_données_emplacement.Visible = true;
            B_Retour_menu.Visible = true;
            B_détails.Visible = true;
            B_Effacer.Visible = true;
            Label_Thème.Visible = false;
            comboBox_Thème.Visible = false;
            DG_emplacements.Visible = false;
            B_less.Visible = false;
            MessageBox.Show("Saisissez directement vos modifications dans les zones de saisies.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etes-vous sûr de vouloir supprimer cet emplacement ?", "Confirmation", MessageBoxButtons.YesNo);
            B_Supprimer.Visible = false;
            B_modifier.Visible = false;
            B_enregistrer.Enabled = false;
            B_Effacer.Enabled = false;
        }


        private void textBox_Libellé_TextChanged(object sender, EventArgs e)
        {
            B_enregistrer.Visible = true;
            B_Effacer.Visible = true;
            B_enregistrer.Enabled = true;
            B_Effacer.Enabled = true;
        }

        private void B_Effacer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etes-vous sûr de vouloir réinitialiser les informations de cet emplacement ?", "Confirmation", MessageBoxButtons.YesNo);
            B_enregistrer.Enabled = false;
            B_Effacer.Enabled = false;
        }

        private void B_détails_Click(object sender, EventArgs e)
        {
            DG_emplacements.Visible = true;
            B_less.Visible = true;
        }

        private void B_Retour_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etes-vous sûr de vouloir quitter cette fenêtre ?", "Confirmation", MessageBoxButtons.YesNo);
            Close();
        }

        private void B_less_Click(object sender, EventArgs e)
        {
            DG_emplacements.Visible = false;
            B_less.Visible = false;
        }

        private void DG_emplacements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gp_données_emplacement.Visible = true;
        }
    }
}
