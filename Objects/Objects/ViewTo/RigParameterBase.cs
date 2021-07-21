using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;
using ViewTo.Structure;

namespace Objects.ViewTo
{

  public class RigParameterBase : AViewObjectBase, IRigParam<ViewerBundleBase>
  {
    public List<ViewerBundleBase> bundles { get; set; }
    [JsonIgnore]
    public virtual bool isValid => bundles.Valid() && bundles.Valid();

    public RigParameterBase()
    { }
  }
}