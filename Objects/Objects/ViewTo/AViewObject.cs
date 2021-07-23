using Speckle.Core.Models;
using ViewTo.Structure;

namespace Objects.ViewTo
{

  /// <summary>
  /// this is a bit excessive but the is meant to help with organization down the road...
  /// </summary>
  public interface IViewObjBase : IViewObj
  { }

  /// <summary>
  /// simple parent view object for base type
  /// </summary>
  public abstract class ViewObjBase : Base, IViewObjBase
  {

    public ViewObjBase()
    { }

  }
}