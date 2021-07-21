using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;
using ViewTo.Structure;

namespace Objects.ViewTo
{

  public class ViewContentTarget : ViewContentBase, IViewName
  {
    public string viewName { get; set; }

    [JsonIgnore]
    public override bool isValid => base.isValid && viewName.Valid();

    public ViewContentTarget()
    { }
  }
}