using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactia_Nick
{
    public abstract class SpaceObject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Position? Positionn { get; set; }
        public override string ToString()
        {
            if (Positionn == null) return string.Empty;
            else return $"({Positionn.X},{Positionn.Y})";
        }
        public class Position
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Position() { }
            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
