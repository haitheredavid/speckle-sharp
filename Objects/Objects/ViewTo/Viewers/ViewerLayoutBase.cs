using System.Collections.Generic;
using ViewTo.Structure;

namespace Objects.ViewTo
{

  public class ViewerLayoutBase : AViewObjectBase, IViewerLayout
  {
    public virtual List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerLayoutBase()
    { }
  }
}