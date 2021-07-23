using System.Collections.Generic;
using ViewTo.Structure;

namespace Objects.ViewTo
{

  public class ViewerLayoutBase : ViewObjBase, IViewerLayout
  {
    public virtual List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerLayoutBase()
    { }
  }
}