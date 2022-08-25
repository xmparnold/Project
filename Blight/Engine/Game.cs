#pragma warning disable CS8618
using Blight.Engine.Data.Dungeons;
using Blight.Engine.Data.Maps;

namespace Blight.Engine;
public class Game
{
    public int? GameId { get; set; }

    // 0 = in Town, 1 = in Dungeon
    public int PlayerLocation { get; set; } = 0;
    public Dungeon? DungeonIn { get; set; }
    public int? DungeonX { get; set; }
    public int? DungeonY { get; set; }
    public int PlayerId { get; set; }
    public Player GamePlayer { get; set; }
    public int CharacterId { get; set; }
    public Character PlayerCharacter { get; set; }
    public List<Dungeon> Dungeons { get; set; } = new List<Dungeon>();

    public bool CanGoNorth 
    {
        get 
        {   
            if (DungeonIn != null)
            {
                return DungeonIn.Map.CanGoNorth(DungeonIn.Map.CurrentNode);
            }
            else
            {
                return false;
            }
        } 
    }

    public bool CanGoSouth
    {
        get
        {
            if (DungeonIn != null)
            {
                return DungeonIn.Map.CanGoNorth(DungeonIn.Map.CurrentNode);
            }
            else
            {
                return false;
            }
        }
    }

    public bool CanGoEast
    {
        get
        {
            if (DungeonIn != null)
            {
                return DungeonIn.Map.CanGoEast(DungeonIn.Map.CurrentNode);
            }
            else
            {
                return false;
            }
        }
    }

    public bool CanGoWest
    {
        get
        {
            if (DungeonIn != null)
            {
                return DungeonIn.Map.CanGoWest(DungeonIn.Map.CurrentNode);
            }
            else
            {
                return false;
            }
        }
    }



    public Game()
    {
        TestDungeon testDungeon = new TestDungeon();
        Dungeons.Add(testDungeon.Dungeon);

    }

    public void MoveEast()
    {
        if (PlayerLocation == 1)
        {
            if (DungeonIn != null)
            {
                DungeonIn.Map.MoveEast(DungeonIn.Map.PlayerX, DungeonIn.Map.PlayerY);
                DungeonX = DungeonIn.Map.PlayerX;
                DungeonY = DungeonIn.Map.PlayerY;
            }
        }
    }

    public void MoveWest()
    {
        if (PlayerLocation == 1)
        {
            if (DungeonIn != null)
            {
                DungeonIn.Map.MoveWest(DungeonIn.Map.PlayerX, DungeonIn.Map.PlayerY);
                DungeonX = DungeonIn.Map.PlayerX;
                DungeonY = DungeonIn.Map.PlayerY;
            }
        }
    }

    public void MoveNorth()
    {
        if (PlayerLocation == 1)
        {
            if (DungeonIn != null)
            {
                DungeonIn.Map.MoveNorth(DungeonIn.Map.PlayerX, DungeonIn.Map.PlayerY);
                DungeonX = DungeonIn.Map.PlayerX;
                DungeonY = DungeonIn.Map.PlayerY;
            }
        }
    }

    public void MoveSouth()
    {
        if (PlayerLocation == 1)
        {
            if (DungeonIn != null)
            {
                DungeonIn.Map.MoveSouth(DungeonIn.Map.PlayerX, DungeonIn.Map.PlayerY);
                DungeonX = DungeonIn.Map.PlayerX;
                DungeonY = DungeonIn.Map.PlayerY;
            }
        }
    }


}