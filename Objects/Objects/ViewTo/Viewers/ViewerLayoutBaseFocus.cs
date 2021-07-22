using System.Collections.Generic;
using Objects.Geometry;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class ViewerLayoutBaseFocus : ViewerLayoutBase
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public Point focusPoint { get; set; }

    public ViewerLayoutBaseFocus()
    { }
  }
}