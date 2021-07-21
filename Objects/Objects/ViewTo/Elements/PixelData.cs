namespace Objects.ViewTo
{
  public class PixelData : AViewObjectBase
  {
    
    public uint[] values { get; set; }
    public double[] distances { get; set; }
    public string contentName { get; set; }

    public PixelData()
    { }
  }
}