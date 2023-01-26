namespace DotNetGeoJSON.Models.GeometryModels;

public class Point : Geometry
{
    public Point(double longitude, double latitude) : base("Point")
    {
        coordinates = new List<double>();
        coordinates.Add(longitude);
        coordinates.Add(latitude);
    }

    public List<double> coordinates { get; set; }

    public override bool IsValid()
    {
        return coordinates.Count >= 2;
    }
}