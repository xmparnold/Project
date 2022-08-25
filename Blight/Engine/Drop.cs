#pragma warning disable CS8618
namespace Blight.Engine;

public class Drop
{
    public int DropId { get; set; }
    public bool ItemDrop { get; set; }
    public bool GoldDrop { get; set; }
    public int ItemId { get; set; }
    public Item? Item { get; set; }
    public int Amount { get; set; }
    public int GoldAmount { get; set; }
    public double DropChance { get; set; }
}