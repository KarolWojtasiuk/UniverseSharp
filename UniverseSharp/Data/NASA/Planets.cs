using System.Diagnostics.CodeAnalysis;

namespace UniverseSharp.Data.NASA
{
    /// <summary>
    /// Source: https://ssd.jpl.nasa.gov/?planet_phys_par
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class Planets
    {
        /// <summary>
        /// Mercury is the smallest and closest planet to the Sun in the Solar System.
        /// <para/>
        /// <b>Mass</b>: 3.30114e23,
        /// <br/>
        /// <b>Radius</b>: 2.4394e6
        /// </summary>
        public static readonly CelestialBody Mercury = new(3.30114e23m, 2.4394e6m);

        /// <summary>
        /// Venus is the second planet from the Sun.
        /// <para/>
        /// <b>Mass</b>: 4.86747e24,
        /// <br/>
        /// <b>Radius</b>: 6.0518e6
        /// </summary>
        public static readonly CelestialBody Venus = new(4.86747e24m, 6.0518e6m);

        /// <summary>
        /// Earth is the third planet from the Sun and the only astronomical object known to harbor life.
        /// <para/>
        /// <b>Mass</b>: 5.97237e24,
        /// <br/>
        /// <b>Radius</b>: 6.3710084e6
        /// </summary>
        public static readonly CelestialBody Earth = new(5.97237e24m, 6.3710084e6m);

        /// <summary>
        /// Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System.
        /// <para/>
        /// <b>Mass</b>: 6.41712e23,
        /// <br/>
        /// <b>Radius</b>: 3.3895e6
        /// </summary>
        public static readonly CelestialBody Mars = new(6.41712e23m, 3.3895e6m);

        /// <summary>
        /// Jupiter is the fifth planet from the Sun and the largest in the Solar System.
        /// <para/>
        /// <b>Mass</b>: 1.898187e27,
        /// <br/>
        /// <b>Radius</b>: 6.9911e7m
        /// </summary>
        public static readonly CelestialBody Jupiter = new(1.898187e27m, 6.9911e7m);

        /// <summary>
        /// Saturn is the sixth planet from the Sun and the second-largest in the Solar System.
        /// <para/>
        /// <b>Mass</b>: 5.683174e26,
        /// <br/>
        /// <b>Radius</b>: 5.8232e7
        /// </summary>
        public static readonly CelestialBody Saturn = new(5.683174e26m, 5.8232e7m);

        /// <summary>
        /// Uranus is the seventh planet from the Sun.
        /// <para/>
        /// <b>Mass</b>: 8.68127e25,
        /// <br/>
        /// <b>Radius</b>: 2.5362e7
        /// </summary>
        public static readonly CelestialBody Uranus = new(8.68127e25m, 2.5362e7m);

        /// <summary>
        /// Neptune is the eighth and farthest-known Solar planet from the Sun.
        /// <para/>
        /// <b>Mass</b>: 1.024126e26,
        /// <br/>
        /// <b>Radius</b>: 2.4622e7
        /// </summary>
        public static readonly CelestialBody Neptune = new(1.024126e26m, 2.4622e7m);

        /// <summary>
        /// Pluto is a dwarf planet in the Kuiper belt.
        /// <para/>
        /// <b>Mass</b>: 1.3030e22,
        /// <br/>
        /// <b>Radius</b>: 1.1883e6
        /// </summary>
        public static readonly CelestialBody Pluto = new(1.3030e22m, 1.1883e6m);
    }
}