using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class ResultCloudBase : ViewCloudBase, IResultCloud<PixelDataBase>
  {
    public List<PixelDataBase> data { get; set; }

    [JsonIgnore]
    public override bool isValid => base.isValid && data.Valid();

    public ResultCloudBase()
    { }
  }
}