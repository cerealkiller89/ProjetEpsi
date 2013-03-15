using BiblioClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PointSystem
    {
        public ITotal InitialPoints;
        public class ITotal : IComparable
        {

        }

        public ITotal initialPoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITotal GetPointsFromMatch(Match m, bool isHome)
        {
          

        }

       
    }
}
