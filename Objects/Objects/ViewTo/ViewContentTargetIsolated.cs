using System.Collections.Generic;
using System.Linq;
using Speckle.Core.Models;
using Speckle.Newtonsoft.Json;

namespace Objects.ViewTo
{

  public class ViewContentTargetIsolated : ViewContentTarget
  {
    [DetachProperty]
    public List<RigParameters> @params { get; set; }
   
    [JsonIgnore]
    public override bool isValid => base.isValid && @params != null && @params.Any();

    public ViewContentTargetIsolated()
    { }
  }
}