using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioClasse
{
    public class Match
    {
        private int Home, Away;
        private int p1;
        private int p2;

        public Match(int p1, int p2)
        {

            this.p1 = p1;
            this.p2 = p2;
        }

        public Club Away (int Away)
     
        {

            this.Away = Away;

        }
  
        public int AwayGoals 
        { 
            get
            {
                throw new NotImplementedException();
            }
        }
        public Club Home(int Home)
        { 
            this.Home = Home;
           
        }
        

        public int HomeGoals
        {
            get
            {
                throw new NotImplementedException();

            }
        }

        public bool IsAwayForfait
        { 
            get
             { 
                throw new NotImplementedException();
             }
        }
        public bool IsDraw
        {
            get
             { 
                throw new NotImplementedException();
             }
        }
        public bool IsHomeForfait 
        { 
            get
             { 
                throw new NotImplementedException();
             }
        }



        public int GetGoals(bool home)
        {
            throw new NotImplementedException();
        }
    }
    
}
