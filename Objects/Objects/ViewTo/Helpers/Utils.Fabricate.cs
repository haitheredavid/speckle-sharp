using System;
using System.Collections.Generic;

namespace Objects.ViewTo
{
  public static partial class Utils
  {
    public static List<CloudPointBase> CloudPoints(int count)
    {
      var rnd = new Random();
      var points = new List<CloudPointBase>();
      for (var i = 0; i < count; i++)
        points.Add(new CloudPointBase
        {
          x = rnd.NextDouble(), y = rnd.NextDouble(), z = rnd.NextDouble(), meta = "FunSpace"
        });

      return points;
    }
  }
}