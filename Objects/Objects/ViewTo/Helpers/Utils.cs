using Objects.Geometry;

namespace Objects.ViewTo
{
  public static partial class Utils
  {

    public static CloudPointBase ToView(this Point p)
    {
      return new CloudPointBase
        {x = p.x, y = p.y, z = p.z, bbox = p.bbox};
    }
  }
}