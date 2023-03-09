using System.Numerics;
using static Galactia_Nick.Planet;
using static Galactia_Nick.Star;

namespace Galactia_Nick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create star
            Star sun = new Star
            {
                Id = 1,
                Name = "Sun",
                StaType = Startype.YellowDwarf,
                Temperature = 5778,
                Positionn = new SpaceObject.Position(0, 0)
            };

            // Created planets
            Planet mercury = new Planet
            {
                Id = 2,
                Name = "Mercury",
                PlanType = PlanetType.Terrestial,
                Diameter = 5000,
                RotationPeriod = 1407.6,
                RevolutionPeriod = 87.97,
                Positionn = new SpaceObject.Position(57910000, 0)
            };

            Planet venus = new Planet
            {
                Id = 3,
                Name = "Venus",
                PlanType = PlanetType.Terrestial,
                Diameter = 12104,
                RotationPeriod = -5832.5,
                RevolutionPeriod = 224.7,
                Positionn = new SpaceObject.Position(108200000, 0)
            };

            Planet earth = new Planet
            {
                Id = 4,
                Name = "Earth",
                PlanType = PlanetType.Terrestial,
                Diameter = 12742,
                RotationPeriod = 23.9,
                RevolutionPeriod = 365.24,
                Positionn = new SpaceObject.Position(149600000, 0)
            };

            Planet mars = new Planet
            {
                Id = 5,
                Name = "Mars",
                PlanType = PlanetType.Terrestial,
                Diameter = 6792,
                RotationPeriod = 24.6,
                RevolutionPeriod = 687,
                Positionn = new SpaceObject.Position(227940000, 0)
            };

            Planet jupiter = new Planet
            {
                Id = 6,
                Name = "Jupiter",
                PlanType = PlanetType.Giant,
                Diameter = 139822,
                RotationPeriod = 9.9,
                RevolutionPeriod = 4331,
                Positionn = new SpaceObject.Position(778330000, 0)
            };

            Planet saturn = new Planet
            {
                Id = 7,
                Name = "Saturn",
                PlanType = PlanetType.Gas_Giant,
                Diameter = 116460,
                RotationPeriod = 10.7,
                RevolutionPeriod = 10747,
                Positionn = new SpaceObject.Position(1429400000, 0)
            };

            Planet uranus = new Planet
            {
                Id = 8,
                Name = "Uranus",
                PlanType = PlanetType.Giant,
                Diameter = 50724,
                RotationPeriod = -17.2,
                RevolutionPeriod = 30589,
                Positionn = new SpaceObject.Position(287090000, 0)
            };

            Planet neptune = new Planet
            {
                Id = 9,
                Name = "Neptune",
                PlanType = PlanetType.Giant,
                Diameter = 49244,
                RotationPeriod = 16.1,
                RevolutionPeriod = 59800,
                Positionn = new SpaceObject.Position(450430000, 0)
            };

            sun.Planets = new List<Planet> { mercury, venus, earth, mars, jupiter, saturn, uranus, neptune };

            Moon luna = new Moon
            {
                Id = 10,
                Name = "Luna",
                Orbiting = earth,
                Diameter = 3474,
                RotationPeriod = 27.3,
                RevolutionPeriod = 27.3,
                Positionn = new SpaceObject.Position { X = -0.00257, Y = 0.00257 }
            };
            Moon titan = new Moon
            {
                Id = 11,
                Name = "Titan",
                Orbiting = saturn,
                Diameter = 5150,
                RotationPeriod = 382.68,
                RevolutionPeriod = 15.95,
                Positionn = new SpaceObject.Position { X = -0.0082, Y = -0.022 }
            };
            Moon phobos = new Moon
            {
                Id = 12,
                Name = "Phobos",
                Orbiting = mars,
                Diameter = 22.2,
                RotationPeriod = 7.65,
                RevolutionPeriod = 0.318,
                Positionn = new SpaceObject.Position { X = -0.00004, Y = -0.0001 }
            };

            Moon europa = new Moon
            {
                Id = 13,
                Name = "Europa",
                Orbiting = jupiter,
                Diameter = 3122,
                RotationPeriod = 85.22,
                RevolutionPeriod = 3.55,
                Positionn = new SpaceObject.Position { X = -0.0046, Y = 0.002 }
            };

            Moon deimos = new Moon
            {
                Id = 14,
                Name = "Deimos",
                Orbiting = mars,
                Diameter = 12.4,
                RotationPeriod = 30.35,
                RevolutionPeriod = 1.26,
                Positionn = new SpaceObject.Position { X = 0.00003, Y = -0.0003 }
            };

            Moon ganymedes = new Moon
            {
                Id = 15,
                Name = "Ganymedes",
                Orbiting = jupiter,
                Diameter = 5268,
                RotationPeriod = 171.7,
                RevolutionPeriod = 7.16,
                Positionn = new SpaceObject.Position { X = 0.007, Y = -0.006 }
            };

            Moon io = new Moon
            {
                Id = 16,
                Name = "Io",
                Orbiting = jupiter,
                Diameter = 3642,
                RotationPeriod = 42.46,
                RevolutionPeriod = 1.77,
                Positionn = new SpaceObject.Position { X = -0.004, Y = 0.001 }
            };

            Moon mimas = new Moon
            {
                Id = 17,
                Name = "Mimas",
                Orbiting = saturn,
                Diameter = 396,
                RotationPeriod = 22.61,
                RevolutionPeriod = 0.942,
                Positionn = new SpaceObject.Position { X = 0.0012, Y = -0.0012 }
            };

            // Add moons to respective planets
            earth.MoonList.Add(luna);
            saturn.MoonList.Add(titan);
            mars.MoonList.Add(phobos);
            jupiter.MoonList.Add(europa);
            mars.MoonList.Add(deimos);
            jupiter.MoonList.Add(ganymedes);
            jupiter.MoonList.Add(io);
            saturn.MoonList.Add(mimas);

            Console.WriteLine("Planets and their moons");
            foreach (var planet in Planets)
            {
                Console.WriteLine($"{planet.Name} ({planet.PlanType}) - Distance from Sun: {planet.Distance(sun)}");
                if (planet.MoonList.Count > 0)
                {
                    Console.WriteLine($"  Moons:");
                    foreach (Moon moon in planet.MoonList)

                        Console.WriteLine($"    {moon.Name} - Distance from {planet.Name}: {moon.Distance((Moon)planet)}");
                }
            }
        }
    }
}
