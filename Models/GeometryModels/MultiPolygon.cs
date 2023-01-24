namespace DotNetGeoJSON.Models.GeometryModels;

public class MultiPolygon : Geometry
{
    public MultiPolygon(Polygon polygon) : base("MultiPolygon")
    {
        coordinates.Add(polygon.coordinates);
    }

    public List<List<List<List<double>>>> coordinates { get; set; } = new();

    public void AddPolygon(Polygon polygon)
    {
        coordinates.Add(polygon.coordinates);
    }

    public override bool IsValid()
    {
        if (coordinates.Count >= 1 && coordinates.All(t => t.Count >= 1) &&
            coordinates.All(t1 => t1.All(t => t.Count >= 3)))
            if (coordinates.All(t2 => t2.All(t1 => t1.All(t => t.Count == 2))))
            {
                foreach (var t in coordinates)
                    if (t.Any(t1 => t1[0][0] != t1[t.Count - 1][0] ||
                                    t1[0][1] != t1[t.Count - 1][1]))
                        return false;
                return true;
            }

        return false;
    }
}