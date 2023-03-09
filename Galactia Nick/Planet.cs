using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactia_Nick
{
    public class Planet : SpaceObject
    {
        public enum PlanetType
        {
            Terrestial,
            Giant,
            Dwarf,
            Gas_Giant
        }
        public PlanetType PlanType { get; set; }
        public List<Moon>? MoonList { get; set; }
        public double Diameter { get; set; } 
        public double RotationPeriod { get; set; } 
        public double RevolutionPeriod { get; set; } 
        public double Distance(Star star)
        {
            if (star == null || star.Positionn == null || Positionn == null) return -1;
            return Math.Sqrt(Math.Pow(star.Positionn.X - Positionn.X, 2) + Math.Pow(star.Positionn.Y - Positionn.Y, 2));
        }
    }
}
