using System.Collections.Generic;
using Speckle.Core.Models;

namespace Objects.ViewTo
{
  public class RigParametersLinked : RigParameters
  {
    
    [DetachProperty]
    public List<ViewCloud> linkedClouds { get; set; }
    
    public RigParametersLinked()
    { }
  }
}