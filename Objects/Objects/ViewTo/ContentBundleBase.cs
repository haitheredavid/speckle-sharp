using System.Collections.Generic;
using System.Text.Json.Serialization;
using HaiThere;
using HaiThere.Utilities;
using Speckle.Core.Models;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class RigParameterBase : ViewObjBase, IRigParameters<ViewerBundleBase, ViewerLayoutBase>
  {
    public bool isolate { get; set; }

    [DetachProperty]
    public List<ViewerBundleBase> bundles { get; set; }

    [JsonIgnore]
    public bool isValid => bundles.Valid();

    public RigParameterBase()
    { }
  }

  public class ContentBundleBase : ViewObjBase, IValidator
  {

    [DetachProperty]
    public List<TargetContentBase> targets { get; set; }

    [DetachProperty]
    public List<BlockerContentBase> blockers { get; set; }

    [DetachProperty]
    public List<DesignContentBase> designs { get; set; }

    public bool isValid => targets.Valid() && blockers.Valid();

    public ContentBundleBase()
    { }
  }
}