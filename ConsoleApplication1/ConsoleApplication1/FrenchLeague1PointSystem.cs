using BiblioClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FrenchLeague1PointSystem : PointSystem
    {
        public class PointTotal : ITotal
        {
            private int goalaverage;
            private int points;

            public int CompareTo(object obj)
            {
                return -this.points.CompareTo(((PointTotal)obj).points);
            }
            public void Increment(ITotal point)
            {
                this.points += ((PointTotal)point).points;
            }

            public PointTotal(Match m, bool home)
            {
                this.points = (m.AwayGoals - m.HomeGoals);
                this.goalaverage += this.points;
            }
        }

     
        public sealed class Singleton
        {
            private static Singleton instance = null;
            private static readonly object padlock = new object();
            private FrenchLeague1PointSystem theInstance;
           
            
           

            private Singleton()
            {
                int instance;
                {
                   

                this.theInstance = new instance();
                      
                }
            }

            public override string ToString()
            {
                return base.ToString();
            }
            public static Singleton Instance
            {
                get
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                        return instance;
                    }
                }
            }
        }

                
    }
}
