#pragma warning disable CS8618

namespace Blight.Engine;

public class ShopSlot
{
    public int ShopSlotId { get; set; }
    public int SlotNumber { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public int Amount { get; set; }
    
}