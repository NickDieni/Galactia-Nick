using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactia_Nick
{
    public sealed class Moon : Planet
    {
        public Planet? Orbiting { get; set; }
        public double Distance(Moon moon)
        {
            if (Orbiting == null || Orbiting.Positionn == null || Positionn == null) return -1;
            else return Math.Sqrt(Math.Pow(Orbiting.Positionn.X - Positionn.X, 2) + Math.Pow(Orbiting.Positionn.Y - Positionn.Y, 2));
        }
    }
}
