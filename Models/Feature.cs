using DotNetGeoJSON.Models.GeometryModels;

namespace DotNetGeoJSON.Models;

public class Feature
{
    public Feature(Geometry geometry, object properties)
    {
        type = "Feature";
        this.geometry = geometry;
        this.properties = properties;
    }

    public string type { get; set; }
    public Geometry geometry { get; set; }
    public object properties { get; set; }
}