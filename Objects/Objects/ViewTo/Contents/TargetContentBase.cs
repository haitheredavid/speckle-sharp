using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Core.Models;
using Speckle.Newtonsoft.Json;
using ViewTo.Structure;

namespace Objects.ViewTo
{

  public class TargetContentBase : ViewContentBase, IViewName
  {
    public string viewName { get; set; }
    public bool isolate { set; get; }

    [DetachProperty]
    public List<ViewerBundleBase> bundles { get; set; }

    [JsonIgnore]
    public override bool isValid => base.isValid && viewName.Valid();

    public TargetContentBase()
    { }
  }
}