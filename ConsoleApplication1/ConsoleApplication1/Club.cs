using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioClasse
{
    public class Club
    {

        private string Home, Away;
        private string prochaine, statu;
        private int gagner, perdu, resultat;
        

        public void Club(string Home, string Away)
        {

            this.Home = Home;
            this.Away = Away;
            throw new NotImplementedException();
            
        }

        
        public override string ToString(string prochaine, int gagner, int perdu, int resultat, string statu)
        {

            this.prochaine = prochaine;
            this.gagner = gagner;
            this.perdu = perdu;
            this.statu = statu;
            this.resultat = (gagner - perdu);
            if (resultat > 0)
                statu = "gagnante";
            else
                statu = "perdante";
            throw new ArgumentOutOfRangeException();
            
            
        }

    }
}
