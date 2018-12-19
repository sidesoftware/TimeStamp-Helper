# TimeStamp-Helper

Provides extension methods for working with byte arrays with emphasis on working with TimeStamp data types from SQL Server. This is specifically useful when comparing timestamp column values such as looking for the changes after a particular timestamp value.

### Installing

TimeStamp-Helper can be installed in several different ways.

Install using Package Manager

```
PM> Install-Package Side.TimeStamp.Helper.Standard -Version 1.0.0
```

Install using .NET CLI

```
> dotnet add package Side.TimeStamp.Helper.Standard --version 1.0.0
```

Install using Paket CLI

```
> paket add Side.TimeStamp.Helper.Standard --version 1.0.0
```

## Sample

OK, here is the scenario. In SQL Server, when using a TimeStamp column, SQL will automatically update the value with each new record.
Once we have that data in our application, sometimes it is necessary to determin which record is newer. There are several methods but 
two main ones we are interested in are Min an Max.

In the example below, we will take an array of byte array's and determine which one is the greatest.

``` csharp
// Initialize byte array
IEnumerable<byte[]> timestamps = new List<byte[]>
{
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 26 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 33 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 36 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 38 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 40 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 44 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 45 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 48 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 55 },
    new byte[] { 0, 0, 0, 0, 35, 240, 161, 67 }
};
```

Now all we need to do is call Min or Max on the timestamps variable and extract the value.

``` csharp
// Get the max timestamp in the byte array
var max = Timestamps.Max();

// Get the min timestamp in the byte array
var min = Timestamps.Min();
``` 

The return value is a byte array. Using some of the other extension methods, we can convert the value if we need to.

``` csharp
// Convert to hex
var maxHex = max.ToHexString();
var minHex = min.ToHexString();

// Convert to base64
var maxBase64 = max.ToBase64String();
var minBase64 = min.ToBase64String();

// Convert to Int64
var maxInt64 = max.ToInt64();
var minInt64 = min.ToInt64();
```

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/sidesoftware/TimeStamp-Helper/tags). 

## Authors

* [Jake Ashcraft](https://github.com/jakeashcraft)

See also the list of [contributors](https://github.com/sidesoftware/TimeStamp-Helper/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
