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

    public void AddItem(Item item)
    {
        PlayerCharacter.CharacterInventory.AddItem(item);
    }

    public void AddItems(Item[] items)
    {
        foreach (Item item in items)
        {
            AddItem(item);
        }
    }

    public void EnterDungeon(int dungeonIdx)
    {
        DungeonIn = Dungeons[dungeonIdx];
        PlayerLocation = 1;
        DungeonX = Dungeons[dungeonIdx].Map.StartX;
        DungeonY = Dungeons[dungeonIdx].Map.StartY;
    }

    public void EnterTown()
    {
        PlayerLocation - 0;
        DungeonIn = null;
    }

    public void KillMonster(Monster monster)
    {
        int numGuaranteedDrops = monster.DropTable.GuarenteedDrops.Count();
        Item[] drops = new Item[numGuaranteedDrops + 1];
        Item rolledItem = monster.DropTable.Roll();

        // for (int x = 0; x < numGuaranteedDrops; x++)
        // {
        //     drops[x] = monster.DropTable.GuarenteedDrops[x];
        // }
        int index = 0;

        while (index < numGuaranteedDrops)
        {
            drops[index] = monster.DropTable.GuarenteedDrops[index];
            index++;
        }
        drops[index] = monster.DropTable.Roll();
        AddItems(drops);
    }

    public void AddGold(int amount)
    {
        PlayerCharacter.Gold += amount;
    }

    public void SpendGold(int amount)
    {
        PlayerCharacter.Gold -= amount;
    }


}