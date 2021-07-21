using Objects.Geometry;
using Objects.Primitive;

namespace Objects
{
  #region Generic interfaces.

  public interface IHasBoundingBox
  {
    Box bbox { get; }
  }

  public interface IHasArea
  {
    double area { get; set; }
  }

  public interface IHasVolume
  {
    double volume { get; set; }
  }

  public interface ICurve
  {
    double length { get; set; }
    Interval domain { get; set; }
  }

  #endregion

  #region Built elements

  public interface IDisplayMesh
  {
    Mesh displayMesh { get; set; }
  }



  #endregion
}
