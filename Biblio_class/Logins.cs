using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_class
{
    public class Logins : List<Login>
    {
        public void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Add(new Login("id" + i, "pass" + i, i % 3));
            }
        }

        public int Authentifier(string id, string pass)
        {
            int resultat = -1;
            Login log = this.Find(l => l.Id == id && l.Mdp == pass);
            if (log == null)
            {
                resultat = -1;
            }
            else resultat = log.Niveau;
            return resultat;
        }

    }
}
