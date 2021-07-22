using System.Collections.Generic;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class ViewerLayoutBaseNormal : ViewerLayoutBase
  {
    public override List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};

    public ViewerLayoutBaseNormal()
    { }
  }
}