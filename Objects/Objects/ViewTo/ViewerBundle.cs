using System.Collections.Generic;
using Objects.Geometry;

namespace Objects.ViewTo
{
  public class ViewerBundleHorizontal : ViewerBundle
  {
    public List<Viewer> viewers => new List<Viewer>
    {
      new Viewer(ViewerDirection.Front),
      new Viewer(ViewerDirection.Right),
      new Viewer(ViewerDirection.Back),
      new Viewer(ViewerDirection.Left)
    };
    
    public ViewerBundleHorizontal()
    { }
  }

  public class ViewerBundleCube : ViewerBundle
  {
    public override List<Viewer> viewers => new List<Viewer>
    {
      new Viewer(ViewerDirection.Front),
      new Viewer(ViewerDirection.Right),
      new Viewer(ViewerDirection.Back),
      new Viewer(ViewerDirection.Left),
      new Viewer(ViewerDirection.Up),
      new Viewer(ViewerDirection.Down)
    };

    public ViewerBundleCube()
    { }

  }

  public class ViewerBundleFocus : ViewerBundle
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public Point focusPoint { get; set; }

    public ViewerBundleFocus()
    { }
  }

  public class ViewerBundleNormal : ViewerBundle
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerBundleNormal()
    { }
  }

  public class ViewerBundleOrtho : ViewerBundle
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerBundleOrtho()
    { }
  }

  public class ViewerBundle : AViewObjectBase
  {
    public virtual List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerBundle()
    { }
  }
}