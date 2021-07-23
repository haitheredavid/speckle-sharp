using HaiThere;
using Speckle.Core.Models;
using Speckle.Newtonsoft.Json;

namespace Objects.ViewTo
{

  public abstract class ViewContentBase : ViewObjBase, IValidator
  {
    [DetachProperty]
    public Base content { get; set; }

    [JsonIgnore]
    public virtual bool isValid => content != null;
    
    public ViewContentBase()
    { }
  }
}