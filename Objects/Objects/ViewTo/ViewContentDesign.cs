using System.Text.Json.Serialization;
using HaiThere.Utilities;

namespace Objects.ViewTo
{
  public class ViewContentDesign : ViewContent, IViewName
  {
    public string viewName { get; set; }
    [JsonIgnore]
    public override bool isValid => base.isValid && viewName.Valid();
    
    public ViewContentDesign()
    { }
  }
}