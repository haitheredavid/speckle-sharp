using System.Collections.Generic;

namespace Objects.ViewTo
{

  public interface IViewStudy : IViewName, IViewObjValidator
  {
    List<IViewObjBase> objects { get; set; }
  }

}