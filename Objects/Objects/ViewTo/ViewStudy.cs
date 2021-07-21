using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;
using ViewTo.Objects;

namespace Objects.ViewTo
{

  public class ViewStudy : AViewObjectBase, IViewStudy<IViewObjBase>
  {

    public string viewName { get; set; }
    public List<IViewObjBase> objs { get; set; }

    [JsonIgnore]
    public bool isValid => viewName.Valid();

    public ViewStudy()
    { }
  }
}