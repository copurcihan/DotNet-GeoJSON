using System.Text.Json.Serialization;

namespace DotNetGeoJSON.Models.GeometryModels;

[JsonDerivedType(typeof(Point))]
[JsonDerivedType(typeof(LineStrings))]
[JsonDerivedType(typeof(Polygon))]
public abstract class Geometry
{
    public Geometry(string type)
    {
        this.type = type;
    }

    public string type { get; set; }


    public abstract bool IsValid();
}