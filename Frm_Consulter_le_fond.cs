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

namespace WindowsFormsApplication1
{
    public partial class Frm_Consulter_le_fond : Form
    {
        public Frm_Consulter_le_fond()
        {
            InitializeComponent();
        }
        Exemplaires TabExemp = new Exemplaires();

        private void cmbbox_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpbox_leslivres.Visible = true;
        }

        private void cmbbox_theme_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            grpbox_leslivres.Visible = true;
        }

        private void cmbbox_livre_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpbox_liste_exemplaire.Visible = true;
            grpbox_actions.Visible = true;

            datagb_exemplaires.DataSource = null;
            datagb_exemplaires.DataSource = TabExemp;
        }

        private void cmbbox_livre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            grpbox_liste_exemplaire.Visible = true;
            grpbox_actions.Visible = true;
        }
        
        private void btn_imprimer_Click_1(object sender, EventArgs e)
        {
            Printer printer = new Printer();
            string test = "FOFANA\nBANGALY";
            printer.printText(test);
        }

        private void btn_retour_menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Consulter_le_fond_Load(object sender, EventArgs e)
        {

        }
    }
}
