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
        public CelestialBody(BigFloat mass, BigFloat radius)
        {
            Mass = mass;
            Radius = radius;
        }


        private BigFloat _mass;
        private BigFloat _radius;


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
        /// Represents first cosmic velocity.
        /// <para/>
        /// Unit: m/s
        /// </summary>
        public BigFloat FirstCosmicVelocity => BigFloat.Sqrt(Universe.GravitationalConstant * Mass / Radius);

        /// <summary>
        /// Represents second cosmic velocity. Also known as escape velocity.
        /// <para/>
        /// Unit: m/s
        /// </summary>
        public BigFloat SecondCosmicVelocity => BigFloat.Sqrt(2 * Universe.GravitationalConstant * Mass / Radius);

        /// <summary>
        /// Represents body volume.
        /// <para/>
        /// Unit: m³
        /// </summary>
        public BigFloat Volume => 4m / 3m * (decimal) Math.PI * BigFloat.Pow(Radius, 3);

        /// <summary>
        /// Represents body density.
        /// <para/>
        /// Unit: kg/m³
        /// </summary>
        public BigFloat Density => Mass / Volume;

        /// <summary>
        /// Represents gravitational acceleration on surface of the body.
        /// <para/>
        /// Unit: m/s²
        /// </summary>
        public BigFloat GravitationalAccelerationOnSurface => CalculateGravitationalAcceleration(Radius);


        /// <summary>
        /// Returns gravitational acceleration at a given height from the center of the body.
        /// <para/>
        /// Unit: m/s²
        /// </summary>
        /// <param name="height">Height in meters from center of the body.</param>
        public BigFloat CalculateGravitationalAcceleration(BigFloat height)
        {
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height), "Value must be greater than 0.");
            }

            return Universe.GravitationalConstant * Mass / BigFloat.Pow(height, 2);
        }
    }
}