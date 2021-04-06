using System;
using System.Numerics;
using Xunit;
using Xunit.Abstractions;

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
    }
}