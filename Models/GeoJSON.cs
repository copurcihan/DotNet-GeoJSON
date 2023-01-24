namespace DotNetGeoJSON.Models;

public class GeoJSON
{
    public GeoJSON()
    {
        type = "FeatureCollection";
        features = new List<Feature?>();
    }

    public string type { get; set; }
    public List<Feature?> features { get; set; }

    public Feature? GetAsFeature()
    {
        return features is { Count: > 0 } ? features[0] : null;
    }

    public bool IsValid()
    {
        for (var i = 0; i < features.Count; i++)
            if (!features[i]!.geometry.IsValid())
                return false;
        return true;
    }
}