namespace DotNetGeoJSON.Models.GeometryModels;

public class Polygon : Geometry
{
    public Polygon(LineStrings lineRing) : base("Polygon")
    {
        coordinates.Add(lineRing.coordinates);
    }

    public List<List<List<double>>> coordinates { get; set; } = new();

    public void AddLinearRing(LineStrings lineRing)
    {
        coordinates.Add(lineRing.coordinates);
    }

    public override bool IsValid()
    {
        if (coordinates.Count < 1 || !coordinates.All(t => t.Count >= 3)) return false;
        {
            if (coordinates.All(t1 => t1.All(t => t.Count >= 2)))
                return coordinates.All(t => t[0][0] == t[t.Count - 1][0] && t[0][1] == t[t.Count - 1][1]);

            return true;
        }
    }
}