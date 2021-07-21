using System.Text.Json.Serialization;
using HaiThere.Utilities;
using ViewTo.Structure;

namespace Objects.ViewTo
{
  public class PixelDataBase : AViewObjectBase, IPixelData
  {

    /// <summary>
    /// name of view content linked to values 
    /// </summary>
    public string contentName { get; set; }
    /// <summary>
    /// the values of pixels from every point
    /// </summary>
    public uint[] values { get; set; }
    /// <summary>
    /// Measuring the distances of a given pixel
    /// </summary>
    public double[] distances { get; set; }
    
    public uint min { get; set; }
    public uint max { get; set; }
    public uint range { get; set; }

    [JsonIgnore]
    public bool isValid => isSetup && values.Valid();
    [JsonIgnore]
    public bool isSetup => contentName.Valid();

    public PixelDataBase()
    { }
  }
}