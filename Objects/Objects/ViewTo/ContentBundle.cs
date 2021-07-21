using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Core.Models;

namespace Objects.ViewTo
{
  public class ContentBundle : AViewObjectBase, IViewObjValidator
  {
    
    [DetachProperty]
    public List<ViewContentTarget> targets { get; set; }
    
    [DetachProperty]
    public List<ViewContentBlocker> blockers { get; set; }

    [DetachProperty]
    public List<ViewContentDesign> designs { get; set; }

    public bool isValid => targets.Valid() && blockers.Valid();

    

  }
}