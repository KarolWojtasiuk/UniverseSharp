using System;
using System.Numerics;
using Xunit;

namespace UniverseSharp.Tests
{
    public class CelestialBodyTests
    {
        [Theory]
        [InlineData(1e122, 1e21, false)]
        [InlineData(0.0000001, 0.0000001, false)]
        [InlineData(1e-22, 1e-2, false)]
        [InlineData(-1e2, 1e2, true)]
        [InlineData(1e2, 0, true)]
        public void RadiusAndMassTest(BigFloat mass, BigFloat radius, bool shouldThrow)
        {
            var createObjectAction = new Func<CelestialBody>(() => new CelestialBody(mass, radius));
            if (shouldThrow)
            {
                Assert.ThrowsAny<Exception>(createObjectAction);
            }
            else
            {
                Assert.NotNull(createObjectAction());
            }
        }

        [Theory]
        [InlineData(6e23, 5e6, 2829, 2831)]
        [InlineData(1e50, 1e30, 81694, 81696)]
        [InlineData(1e20, 1e8, 8.1, 8.3)]
        [InlineData(1e11, 7, 0.9, 1)]
        [InlineData(1, 1, 0, 0.00001)]
        public void FirstCosmicVelocityTest(BigFloat mass, BigFloat radius, BigFloat expectedLow, BigFloat expectedHigh)
        {
            var body = new CelestialBody(mass, radius);
            Assert.InRange(body.FirstCosmicVelocity, expectedLow, expectedHigh);
        }

        [Theory]
        [InlineData(6e23, 5e6, 4001, 4003)]
        [InlineData(1e50, 1e30, 115533, 115535)]
        [InlineData(1e20, 1e8, 11.5, 11.6)]
        [InlineData(1e11, 7, 1.3, 1.4)]
        [InlineData(1, 1, 0, 0.0001)]
        public void SecondCosmicVelocityTest(BigFloat mass, BigFloat radius, BigFloat expectedLow,
            BigFloat expectedHigh)
        {
            var body = new CelestialBody(mass, radius);
            Assert.InRange(body.SecondCosmicVelocity, expectedLow, expectedHigh);
        }

        [Theory]
        [InlineData(5e6, 5.2e20, 5.3e20)]
        [InlineData(1e30, 4.1e90, 4.2e90)]
        [InlineData(1e8, 4.1e24, 4.2e24)]
        [InlineData(7, 1435, 1437)]
        [InlineData(1, 4.1, 4.3)]
        public void VolumeTest(BigFloat radius, BigFloat expectedLow, BigFloat expectedHigh)
        {
            var body = new CelestialBody(1, radius);
            Assert.InRange(body.Volume, expectedLow, expectedHigh);
        }

        [Theory]
        [InlineData(6e23, 5e6, 1145, 1146)]
        [InlineData(1e50, 1e30, 2.3e-41, 3.4e-41)]
        [InlineData(1e20, 1e8, 2.3e-5, 2.4e-5)]
        [InlineData(1e11, 7, 6.9e7, 7e7)]
        [InlineData(1, 1, 0.2, 0.3)]
        public void DensityTest(BigFloat mass, BigFloat radius, BigFloat expectedLow, BigFloat expectedHigh)
        {
            var body = new CelestialBody(mass, radius);
            Assert.InRange(body.Density, expectedLow, expectedHigh);
        }

        [Theory]
        [InlineData(6e23, 1e5, 4004, 4005)]
        [InlineData(1e50, 1e20, 0.66, 0.67)]
        [InlineData(1e20, 5e2, 26696, 26697)]
        [InlineData(1e11, 2, 1.6, 1.7)]
        [InlineData(1, -1, 0, 0, true)]
        public void GravitationalAccelerationTest(BigFloat mass, BigFloat height, BigFloat expectedLow,
            BigFloat expectedHigh, bool shouldThrow = false)
        {
            var body = new CelestialBody(mass, 1);
            if (shouldThrow)
            {
                Assert.ThrowsAny<Exception>(() => body.CalculateGravitationalAcceleration(height));
            }
            else
            {
                Assert.InRange(body.CalculateGravitationalAcceleration(height), expectedLow,
                    expectedHigh);
            }
        }

        [Theory]
        [InlineData(6e23, 5e6, 1.6, 1.7)]
        [InlineData(1e50, 1e30, 6e-21, 7e-21)]
        [InlineData(1e20, 1e8, 6e-7, 7e-7)]
        [InlineData(1e11, 7, 0.13, 0.14)]
        [InlineData(1, 1, 6e-11, 7e-11)]
        public void GravitationalAccelerationOnSurfaceTest(BigFloat mass, BigFloat radius, BigFloat expectedLow,
            BigFloat expectedHigh)
        {
            var body = new CelestialBody(mass, radius);
            Assert.InRange(body.GravitationalAccelerationOnSurface, expectedLow, expectedHigh);
        }
    }
}