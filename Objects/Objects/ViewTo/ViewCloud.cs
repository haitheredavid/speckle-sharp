using System.Collections.Generic;
using System.Linq;
using Objects.Geometry;
using Speckle.Core.Models;
using Speckle.Newtonsoft.Json;

namespace Objects.ViewTo
{

  public class ViewCloud : ViewObjectBase, IViewObjValidator
  {

    [DetachProperty]
    public Pointcloud cloud { get; set; }
    
    [DetachProperty]
    public List<string> cloudMetaData { get; set; }

    [JsonIgnore]
    public int count => cloud?.points?.Count % 3 ?? 0;
  
    [JsonIgnore]
    public bool isValid => cloud != null;

    public List<CloudPointBase> Points
    {
      get { return cloud?.GetPoints().Select(p => Utils.ToView(p)).ToList(); }
      set
      {
        var cp = new List<double>();
        cloudMetaData = new List<string>();
        foreach (var point in value)
        {
          cp.Add(point.x);
          cp.Add(point.y);
          cp.Add(point.z);
          cloudMetaData.Add(point.meta);
        }
        cloud.points = cp;
      }
    }

    public ViewCloud()
    { }
  }
}