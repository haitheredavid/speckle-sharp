using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;

namespace Objects.ViewTo
{


  public class ViewStudy : AViewObjectBase, IViewName, IViewObjValidator
  {

    public string viewName { get; set; }

    public List<IViewObjBase> objects { get; set; }

    [JsonIgnore]
    public  bool isValid => viewName.Valid();

    public ViewStudy()
    { }
  }
}