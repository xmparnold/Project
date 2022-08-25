namespace Blight.Engine;

public class MapConnection
{
    public int MapConnectionId { get; set; }
    public Map? MapA { get; set; }
    public Map? MapB { get; set; }
    public MapNode? MapAConnectingNode { get; set; }
    public MapNode? MapBConnectingNode { get; set; }
}