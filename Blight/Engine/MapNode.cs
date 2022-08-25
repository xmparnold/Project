namespace Blight.Engine;

public class MapNode
{
    public int MapNodeId { get; set; }
    public int XIndex { get; set; }
    public int YIndex { get; set; }

    public bool ConnectN { get; set;}
    public bool ConnectS { get; set;}

    public bool ConnectE { get; set;}

    public bool ConnectW { get; set;}

    public MapNode? NConnection { get; set; }
    public MapNode? SConnection { get; set; }

    public MapNode? EConnection { get; set; }

    public MapNode? WConnection { get; set; }


}