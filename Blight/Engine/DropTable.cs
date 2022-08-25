#pragma warning disable CS8618
namespace Blight.Engine;

public class DropTable
{
    //public int DropTableId { get; set; }
    public string? DropTableName { get; set; }
    public List<Drop> Drops { get; set; } = new List<Drop>();
    public List<Drop> GuarenteedDrops { get; set; } = new List<Drop>();

    public DropTable(string dropTableName)
    {
        DropTableName = dropTableName;
    }
    public DropTable(int dropTableId, string dropTableName)
    {
        //DropTableId = dropTableId;
        DropTableName = dropTableName;
    }

    public int? Roll()
    {
        Random rand = new Random();
        int roll = rand.Next(0, Drops.Count());
        Item? itemRolled = Drops[roll].Item;

        double chance = Drops[roll].DropChance;

        int chanceRoll = rand.Next(0,101);
        double chanceRollPerc = chanceRoll/100;

        if (chanceRollPerc <= chance && itemRolled != null)
        {
            return itemRolled.ItemId;
        }
        else
        {
            return null;
        }
        
    }

    public void AddDrop(Drop drop)
    {
        if (drop != null)
        {
            Drops.Add(drop);
        }
    }

    public void RemoveDropByIndex(int idx)
    {
        Drops.Remove(Drops[idx]);
    }

    public void RemoveDrop(Drop drop)
    {
        Drops.Remove(drop);
    }




}