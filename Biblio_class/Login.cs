using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class
{
        public class Login
        {
            public string Id { get; set; }
            public string Mdp { get; set; }
            public int Niveau { get; set; }

            #region les constructeurs
            public Login()
            {
                Id = "Inconnu";
                Mdp = "Inconnu";
                Niveau = -1;
            }

            public Login(string id, string pass, int niv)
            {
                Id = id;
                Mdp = pass;
                Niveau = niv;
            }
            #endregion les constructeurs
        }


}
