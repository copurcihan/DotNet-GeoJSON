namespace DotNetGeoJSON.Models.GeometryModels;

public class LineStrings : Geometry
{
    public LineStrings(List<Point> points) : base("LineString")
    {
        for (var i = 0; i < points.Count; i++) coordinates.Add(points[i].coordinates);
    }

    public List<List<double>> coordinates { get; set; } = new();

    public void AddPoint(Point point)
    {
        coordinates.Add(point.coordinates);
    }

    public override bool IsValid()
    {
        if (coordinates.Count >= 2)
            return coordinates.All(t => t.Count >= 2);
        return false;
    }
}