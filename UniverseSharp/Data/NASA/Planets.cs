namespace UniverseSharp.Data.NASA
{
    /// <summary>
    /// Source: https://ssd.jpl.nasa.gov/?planet_phys_par
    /// </summary>
    public static class Planets
    {
        public static readonly CelestialBody Mercury = new(3.30114e23m, 2.4394e6m);
        public static readonly CelestialBody Venus = new(4.86747e24m, 6.0518e6m);
        public static readonly CelestialBody Earth = new(5.97237e24m, 6.3710084e6m);
        public static readonly CelestialBody Mars = new(6.41712e23m, 3.3895e6m);
        public static readonly CelestialBody Jupiter = new(1.898187e27m, 6.9911e7m);
        public static readonly CelestialBody Saturn = new(5.683174e26m, 5.8232e7m);
        public static readonly CelestialBody Uranus = new(8.68127e25m, 2.5362e7m);
        public static readonly CelestialBody Neptune = new(1.024126e26m, 2.4622e7m);
        public static readonly CelestialBody Pluto = new(1.3030e22m, 1.1883e6m);
    }
}