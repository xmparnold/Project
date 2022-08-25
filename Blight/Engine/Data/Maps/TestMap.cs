using Blight.Engine;

namespace Blight.Engine.Data.Maps;

public class TestMap
{
    public Map Map { get; set; }

    public TestMap()
    {
        Map newMap = new Map(0,1);
        newMap.MapCells[0,1].ConnectE = true;
        newMap.MapCells[0,2].ConnectW = true;
        newMap.MapCells[0,2].ConnectE = true;
        newMap.MapCells[0,3].ConnectW = true;
        newMap.MapCells[0,3].ConnectE = true;
        newMap.MapCells[0,4].ConnectW = true;
        newMap.MapCells[0,4].ConnectS = true;
        newMap.MapCells[1,4].ConnectN = true;
        newMap.MapCells[1,4].ConnectW = true;
        newMap.PlayerOnMap = true;
        newMap.DirectionFacing = 2;
        newMap.CurrentNode = newMap.MapCells[0,1];
        newMap.AssignIndex();
        newMap.AssignNodeConnections();
        Map = newMap;
    }
}