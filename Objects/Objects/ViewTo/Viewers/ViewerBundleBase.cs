using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;
using ViewTo.Structure;

namespace Objects.ViewTo
{

  public class ViewerBundleBase : ViewObjBase, IViewerBundle<ViewerLayoutBase>
  {
    public List<ViewerLayoutBase> layouts { get; set; }
    [JsonIgnore]
    public virtual bool isValid => layouts.Valid() && layouts.Valid();

    public ViewerBundleBase()
    { }
  }
}