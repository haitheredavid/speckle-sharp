using System;
using System.Collections.Generic;

namespace Objects.ViewTo
{
  public static partial class Utils
  {
    
    public static uint[] Values(int valueCount, Random rnd = null)
    {
      if (rnd == null)
        rnd = new Random();

      var values = new uint[valueCount];
      for (var j = 0; j < values.Length; j++)
      {
        var bytes = new byte[4];
        rnd.NextBytes(bytes);
        values[j] = BitConverter.ToUInt32(bytes, 0);
      }
      return values;
    }
    
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