using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;

namespace Objects.ViewTo
{
  public class ResultCloud : ViewCloud
  {
    public List<PixelData> data { get; set; }

    [JsonIgnore]
    public virtual bool isValid => base.isValid && data.Valid();

    public ResultCloud()
    { }
  }
}