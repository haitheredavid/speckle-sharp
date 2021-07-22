using System.Collections.Generic;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class ViewerLayoutBaseHorizontal : ViewerLayoutBase
  {
    public List<Viewer> viewers => new List<Viewer>
    {
      new Viewer(ViewerDirection.Front),
      new Viewer(ViewerDirection.Right),
      new Viewer(ViewerDirection.Back),
      new Viewer(ViewerDirection.Left)
    };
    
    public ViewerLayoutBaseHorizontal()
    { }
  }
}