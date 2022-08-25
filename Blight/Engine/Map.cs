namespace Blight.Engine;

public class Map
{
    public int MapId { get; set; }
    public int PlayerX { get; set; }
    public int PlayerY { get; set; }
    public bool PlayerOnMap { get; set; }
    //The direction is based on numbers. 0 = North, 1 = East, 2 = South, 3 = West
    public int DirectionFacing { get; set; } = 2;

    public bool HasStartPoint { get; set; }
    public int StartX { get; set; }
    public int StartY { get; set; }

    public MapNode[,] MapCells { get; set; } = new MapNode[10,10];
    public MapNode CurrentNode { get; set; } = new MapNode();
    public List<MapConnection> Connections { get; set; } = new List<MapConnection>();

    public Map(int mapId)
    {
        MapId = mapId;
    }

    public Map(int mapId, int startX, int startY)
    {
        MapId = mapId;
        StartX = startX;
        StartY = startY;
        HasStartPoint = true;
    }


    public void AssignIndex()
    {
        for (int x = 0; x <= 10; x++)
        {
             for (int y = 0; y <= 10; y++)
             {
                MapCells[x,y].XIndex = x;
                MapCells[x,y].YIndex = y;
             }
        }
    }

    public void SetCurrentNode()
    {
        CurrentNode = MapCells[PlayerX, PlayerY];
    }

    public void GoToStart()
    {
        if (HasStartPoint)
        {
            PlayerX = StartX;
            PlayerY = StartY;
            SetCurrentNode();
        }
        else
        {
            Console.WriteLine("Error, Map " + MapId + " has not start point");
        }
    }

    public void Teleport(int x, int y)
    {
        PlayerX = x;
        PlayerY = y;
        SetCurrentNode();
    }

    public void AssignNodeConnections()
    {
        for (int x = 0; x <= 10; x++)
        {
            for (int y = 0; y <= 10; y++)
             {
                if (MapCells[x,y].ConnectN)
                {
                    MapCells[x,y].NConnection = MapCells[x-1,y];
                    MapCells[x-1,y].SConnection = MapCells[x,y];
                }
                if (MapCells[x,y].ConnectS)
                {
                    MapCells[x,y].SConnection = MapCells[x+1,y];
                    MapCells[x+1,y].NConnection = MapCells[x,y];
                }
                if (MapCells[x,y].ConnectE)
                {
                    MapCells[x,y].EConnection = MapCells[x,y+1];
                    MapCells[x,y+1].WConnection = MapCells[x,y];
                }
                if (MapCells[x,y].ConnectW)
                {
                    MapCells[x,y].WConnection = MapCells[x,y-1];
                    MapCells[x,y-1].EConnection = MapCells[x,y];
                }
             }
        }
    }

    public bool CanGoNorth(MapNode cell)
    {
        if (cell.ConnectN && cell.NConnection != null)
        {
            return true;
        }
        return false;
    }

    public bool CanGoSouth(MapNode cell)
    {
        if (cell.ConnectS && cell.SConnection != null)
        {
            return true;
        }
        return false;
    }

    public bool CanGoEast(MapNode cell)
    {
        if (cell.ConnectE && cell.EConnection != null)
        {
            return true;
        }
        return false;
    }

    public bool CanGoWest(MapNode cell)
    {
        if (cell.ConnectW && cell.WConnection != null)
        {
            return true;
        }
        return false;
    }

    public void MoveNorth(int x, int y)
    {
        if (CanGoNorth(MapCells[x,y]))
        {
            PlayerX -= 1;
        }
    }

    public void MoveSouth(int x, int y)
    {
        if (CanGoSouth(MapCells[x,y]))
        {
            PlayerX += 1;
        }
    }

    public void MoveEast(int x, int y)
    {
        if (CanGoEast(MapCells[x,y]))
        {
            PlayerY += 1;
        }
    }

    public void MoveWest(int x, int y)
    {
        if(CanGoWest(MapCells[x,y]))
        {
            PlayerY -= 1;
        }
    }
}