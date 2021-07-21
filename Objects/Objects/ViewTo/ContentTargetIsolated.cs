using System.Collections.Generic;
using Speckle.Core.Models;

namespace Objects.ViewTo
{
  public class IsolatedTargetContent : TargetContent
  {
    [DetachProperty]
    public List<IBaseBundle> bundles { get; set; }
  }
}