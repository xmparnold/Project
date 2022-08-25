#pragma warning disable CS8618

namespace Blight.Engine;

public class Dungeon
{
    public string DungeonName { get; set; }
    public Map Map { get; set; }

    public Dungeon(string name)
    {
        DungeonName = name;
    }

    public Dungeon(string name, Map map)
    {
        DungeonName = name;
        Map = map;
    }
}