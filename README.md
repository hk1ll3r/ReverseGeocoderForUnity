# ReverseGeocoderForUnity
Reverse Geocoder for Unity allows you to look up world coordinates (latitude, longitude) and get the country / US state the query point falls into. The code is offline and performs no network calls.

The code is based off [Wibci.CountryReverseGeocode](https://github.com/InquisitorJax/Wibci.CountryReverseGeocode).

The library can be used with custom data. For example you could gather data for provinces of countries other than the US and use it with this library. The sample .json files for US and world countries are included in this package.

### Why not use [Wibci.CountryReverseGeocode](https://github.com/InquisitorJax/Wibci.CountryReverseGeocode) directly?
- Less code: That project is a general C# project, with all the NUnit tests and a gen project. Not suitable for inclusion in a Unity project. This project is way smaller and contians the minimal set of files from the original package. It reduces the binary build file of your game.

- Basic Unity integration: This package adds a thin MonoBehavoiur wrapper around the main service class for use with Unity. The showcase project (this) includes a sample Unity scene that performs reverse Geocode queries. 

- This package also gets around [a build problem](https://issuetracker.unity3d.com/issues/il2cpp-build-hangs-while-building-a-project-with-a-large-array-of-strings) in Unity  by removing the large class data initializers and loading the data at runtime from .json files.

## Installation

:warning: This package has a dependency on [Newtonsoft.json for Unity](https://github.com/jilleJr/Newtonsoft.Json-for-Unity). Install that first.

### Install via [Git URLs](https://docs.unity3d.com/Manual/upm-git.html)

Add this git URL in Unity's package manager.
```
https://github.com/hk1ll3r/ReverseGeocoderForUnity
```

### Install via Traditional .unitypackage File
Releases contain the `ReverseGeocoderForUnity.unitypackage`.

### Install via [OpenUPM](https://openupm.com/)
TODO

### Install via Unity Asset Store
This package is available on Unity Asset Store: (http://u3d.as/1WT5).

## License
This package is licensed under The MIT License (MIT)

Copyright © 2020 Hoss Shah (hk1ll3r)
https://github.com/hk1ll3r/ReverseGeocoderForUnity

See full copyrights in LICENSE.md inside repository
