using System.Collections.Generic;
using Objects.Geometry;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class ViewerBundleBaseHorizontal : ViewerBundleBase
  {
    public List<Viewer> viewers => new List<Viewer>
    {
      new Viewer(ViewerDirection.Front),
      new Viewer(ViewerDirection.Right),
      new Viewer(ViewerDirection.Back),
      new Viewer(ViewerDirection.Left)
    };
    
    public ViewerBundleBaseHorizontal()
    { }
  }

  public class ViewerBundleBaseCube : ViewerBundleBase
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

    public ViewerBundleBaseCube()
    { }

  }

  public class ViewerBundleBaseFocus : ViewerBundleBase
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public Point focusPoint { get; set; }

    public ViewerBundleBaseFocus()
    { }
  }

  public class ViewerBundleBaseNormal : ViewerBundleBase
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerBundleBaseNormal()
    { }
  }

  public class ViewerBundleBaseOrtho : ViewerBundleBase
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerBundleBaseOrtho()
    { }
  }

  public class ViewerBundleBase : AViewObjectBase, IViewerBundle
  {
    public virtual List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerBundleBase()
    { }
  }
}