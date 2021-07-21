using Speckle.Core.Models;

namespace Objects.ViewTo
{
  public enum ViewerDirection
  {

    Up,
    Down,
    Left,
    Right,
    Front,
    Back

  }
  public class Viewer
  {

    public Viewer(ViewerDirection direction)
    {
      Direction = direction;
    }

    public ViewerDirection Direction { get; }
  }

}