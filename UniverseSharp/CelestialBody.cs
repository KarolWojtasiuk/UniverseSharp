using System;
using System.Numerics;

namespace UniverseSharp
{
    /// <summary>
    /// Base class for all celestial bodies.
    /// </summary>
    public class CelestialBody
    {
        /// <summary>
        /// Creates a new celestial body.
        /// </summary>
        /// <param name="radius">Radius in meters.</param>
        /// <param name="mass">Mass in kilograms.</param>
        public CelestialBody(BigFloat radius, BigFloat mass)
        {
            Radius = radius;
            Mass = mass;
        }


        private BigFloat _radius;
        private BigFloat _mass;


        /// <summary>
        /// Represents celestial body radius.
        /// <para/>
        /// Unit: m
        /// </summary>
        public BigFloat Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Radius));
                }

                _radius = value;
            }
        }

        /// <summary>
        /// Represents celestial body mass.
        /// <para/>
        /// Unit: kg
        /// </summary>
        public BigFloat Mass
        {
            get => _mass;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Mass));
                }

                _mass = value;
            }
        }
    }
}