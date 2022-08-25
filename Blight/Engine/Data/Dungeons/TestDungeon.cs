using Blight.Engine;
using Blight.Engine.Data.Maps;

namespace Blight.Engine.Data.Dungeons;
public class TestDungeon
{
    public Dungeon Dungeon { get; set; }
    public TestDungeon()
    {
        TestMap testMap = new TestMap();
        Dungeon newDungeon = new Dungeon("TestDungeon", testMap.Map);
        Dungeon = newDungeon;
    }
}