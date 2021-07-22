using System.Text.Json.Serialization;
using HaiThere.Utilities;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class ViewContentDesign : ViewContentBase, IViewName
  {
    public string viewName { get; set; }
    [JsonIgnore]
    public override bool isValid => base.isValid && viewName.Valid();
    
    public ViewContentDesign()
    { }
  }
}