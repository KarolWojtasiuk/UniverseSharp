# UniverseSharp 
![Build badge](https://github.com/KarolWojtasiuk/UniverseSharp/workflows/.NET/badge.svg?branch=master)

Library to facilitate physical calculations e.g. calculating cosmic velocity from given mass and radius.  
Project in early development stage.

## Usage

### Installing

Library is currently in an early development stage so NuGet package is not available yet.

### Example usage

```csharp
var myPlanet = new CelestialBody(radius: 4.5e6m, mass: 2.5e24m);
Console.WriteLine(myPlanet.FirstCosmicVelocity); // 6089.18896259775 m/s
Console.WriteLine(myPlanet.SecondCosmicVelocity); // 8611.41361475829 m/s
Console.WriteLine(myPlanet.Volume); // 381703507411159485000.0 m³
Console.WriteLine(myPlanet.Density); // 6549.5861354689506103422990912 kg/m³
Console.WriteLine(myPlanet.GravitationalAccelerationOnSurface); // 8.239604938271604938271604938 m/s
Console.WriteLine(myPlanet.CalculateGravitationalAcceleration(height: 5.0e6m)); // 6.67408 m/s
```

### IntelliSense documentation support

![Docs Support](https://i.imgur.com/35fD0Rn.png)

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing
purposes.

### Prerequisites

> [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)

### Installing

Clone this repository to your computer.
> git clone https://github.com/KarolWojtasiuk/UniverseSharp.git

Then go to the repository directory.
> cd UniverseSharp

Finally build library.
> dotnet build UniverseSharp

## Running the tests

Tests for this application is provided by xUnit. .NET Core contains a Test Runner, so you don't have to download
anything.

Just run this command.
> dotnet test UniverseSharp.Tests

## Built With

* [xUnit](https://github.com/xunit/xunit) - Testing framework
