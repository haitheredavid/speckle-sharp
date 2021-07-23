using System.Collections.Generic;
using HaiThere.Utilities;
using Speckle.Newtonsoft.Json;
using ViewTo.Objects;

namespace Objects.ViewTo
{

  public class ViewStudyBase : ViewObjBase, IViewStudy<ViewObjBase>
  {

    public string viewName { get; set; }
    public List<ViewObjBase> objs { get; set; }

    [JsonIgnore]
    public bool isValid => viewName.Valid();

    public ViewStudyBase()
    { }
  }
}