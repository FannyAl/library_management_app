using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Biblio_class
{
     public class Info_generale
    {
        #region //Atribut de la class  Info_generale

        private int _nbreMaxiLivreEmprunt;

        private int _dureeMaxiEmprunt;
        #endregion


        #region // Proprietes

        //................................
        [DisplayName("Nombre de livre Emprunter")]
        public int NbreMaxiLivreEmprunt
        {
            get { return _nbreMaxiLivreEmprunt; }
            set { _nbreMaxiLivreEmprunt = value; }
        }

        //............................
        [DisplayName("Duree Max de l'emprunt")]
        public int DureeMaxiEmprunt
        {
            get { return _dureeMaxiEmprunt; }
            set { _dureeMaxiEmprunt = value; }
        }
        #endregion


        #region // Les Constructeur de la class Info_generale

        //.......................
        public Info_generale()
        {
            _nbreMaxiLivreEmprunt = 3;
            _dureeMaxiEmprunt = 30;

        }
        #endregion


        #region // Les méthodes

        //............................................
        public int Affiche_nbre_Maxi_LivreEmprunt()
        {
            return _nbreMaxiLivreEmprunt;

        }

        //........................................
        public int Affiche_duree_Maxi_Emprunt()
        {
            return _dureeMaxiEmprunt;

        }
        #endregion
    }
}
