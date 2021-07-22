using System.Collections.Generic;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class ViewerLayoutBaseCube : ViewerLayoutBase
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

    public ViewerLayoutBaseCube()
    { }

  }
}