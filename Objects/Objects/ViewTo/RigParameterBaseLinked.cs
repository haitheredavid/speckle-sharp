using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Core.Models;
using Speckle.Newtonsoft.Json;

namespace Objects.ViewTo
{
  public class RigParameterBaseLinked : RigParameterBase
  {

    [JsonIgnore]
    public override bool isValid => base.isValid && linkedClouds.Valid();

    [DetachProperty]
    public List<ViewCloudBase> linkedClouds { get; set; }
    
    public RigParameterBaseLinked()
    { }
  }
}