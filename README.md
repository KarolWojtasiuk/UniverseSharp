# UniverseSharp

![Build badge](https://github.com/KarolWojtasiuk/UniverseSharp/workflows/.NET/badge.svg?branch=master)

Library to facilitate physical calculations e.g. calculating cosmic velocity from given mass and radius.  
Project in early development stage.

## Usage

### Installing

Library is currently in an early development stage so NuGet package is not available yet.

### Example usage

```csharp
var myPlanet = new CelestialBody(radius: 4.5e6, mass: 2.5e24);
Console.WriteLine(myPlanet.FirstCosmicVelocity); //6089.1889625977403445034075310210229350530234828174250100542213675545
Console.WriteLine(myPlanet.SecondCosmicVelocity); //8611.413614758283000983304784383634439906931315731627144823861947177
Console.WriteLine(myPlanet.CalculateGravitationalAcceleration(height: 7e6)); //3.405142857142857451352755872914285714285
Console.WriteLine(myPlanet.Density); //6549.5861354689512037149341403096574845835444909202854993444150023369513416475003
```

You can also import `UniverseSharp.Data.NASA` namespace and use predefined objects.
```csharp
Console.WriteLine(Planets.Earth.FirstCosmicVelocity); //7909.79026300202504910263375122164
Console.WriteLine(Planets.Earth.GravitationalAccelerationOnSurface); //9.82023222645293258

Console.WriteLine(Planets.Jupiter.Volume); //1431281810739355898836057.6446305537758196646
Console.WriteLine(Planets.Jupiter.Density); //1326.214715898230640321948098163419896463003

Console.WriteLine(Planets.Mars.SecondCosmicVelocity); //5027.04720184840644701259976144380
Console.WriteLine(Planets.Mars.Radius); // 3389500
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
* [BigFloat](https://github.com/FaustVX/BigFloat) - Arbitrary precision float number support
