using System.Collections.Generic;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class ViewerLayoutBaseOrtho : ViewerLayoutBase
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerLayoutBaseOrtho()
    { }
  }
}