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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void BTN_Seconnecter_Click(object sender, EventArgs e)
        {
            // Controler l'existence du login et recuperer son niveau de droit
            // 0 ==> Si Adherent
            // 1 ==> Si Agent
            // 2 ==> Si Gestionnaire
            // Cas Gestionnaire
            // Chargement des LOGINS
            Logins ListLogins = new Logins();
            ListLogins.Init();
            int niv = ListLogins.Authentifier(TXTBX_identifiant.Text, TXTBX_motDePasse.Text);

            if (niv == 2)
            {
                (this.MdiParent as Frm_Menu).Menu_GESTIONNAIRE();
            }

            // Cas adherent
            if (niv == 0)
            {
                (this.MdiParent as Frm_Menu).Menu_ADHERENT();
            }
            // Cas Agent
            if (niv == 1)
            {
                (this.MdiParent as Frm_Menu).Menu_AGENT();
            }

            if (niv == -1)
            {
                MessageBox.Show("Identifiant incorrect");
            }
            else
            {
                // Fermeture du formulaire de login
                MessageBox.Show("Bienvenue sur l'application du Centre Culturel des Marmusots !");
                Close();
            }

            
        }
    }
}
