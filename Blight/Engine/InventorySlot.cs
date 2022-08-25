#pragma warning disable CS8618

namespace Blight.Engine;

public class InventorySlot
{
    public int SlotNumber { get; set; }
    public int ItemId { get; set; }
    public Item? item { get; set; }
    public int Amount { get; set; }

}