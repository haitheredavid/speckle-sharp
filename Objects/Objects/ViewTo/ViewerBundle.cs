using System.Collections.Generic;

namespace Objects.ViewTo
{
  public class ViewerBundle : ViewObjectBase, IBaseBundle
  {
    public List<Viewer> viewers => new List<Viewer>
      {new Viewer(ViewerDirection.Front)};
  }
}