using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactia_Nick
{
    public class Star : SpaceObject
    {
        public enum Startype { 
            YellowDwarf,
            White, 
            BlueNeutron, 
            RedGiant 
        }
        public Startype StaType { get; set; }
        public int Temperature { get; set; }
        public List<Planet>? Planets { get; set; }

    }
}
