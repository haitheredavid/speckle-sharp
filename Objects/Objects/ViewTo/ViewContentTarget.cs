using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;

namespace Objects.ViewTo
{

  public class ViewContentTarget : ViewContent, IViewName
  {
    public string viewName { get; set; }

    [JsonIgnore]
    public override bool isValid => base.isValid && viewName.Valid();

    public ViewContentTarget()
    { }
  }
}