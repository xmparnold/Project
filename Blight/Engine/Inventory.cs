#pragma warning disable CS8618

namespace Blight.Engine;

public class Inventory
{
    public int InventoryId { get; set; }
    public int CharacterId { get; set; }
    public int InventorySize { get; set;} = 25;
    public List<InventorySlot> Items { get; set; } = new List<InventorySlot>();
    
    public void DropItem(InventorySlot itemSlot, int amount)
    {
        if (amount >= itemSlot.Amount)
        {
            Items.Remove(itemSlot);
        }
        else
        {
            Items[itemSlot.SlotNumber].Amount = Items[itemSlot.SlotNumber].Amount - amount;
        }
    }

    public void AddInventorySpots(int number)
    {
        InventorySize = InventorySize + number;
    }

    public void RemoveInventorySpots(int number)
    {
        if (number > InventorySize)
        {
            Console.WriteLine("Error: Not enough spots in inventory currently to remove that many.");
        }
        else
        {
            InventorySize = InventorySize - number;
        }
    }

    public void AddItem(InventorySlot item)
    {
        if (Items.Count >= InventorySize)
        {
            Console.WriteLine("Error: Not enough space in inventory to add any items.");
        }
        else
        {
            Items.Add(item);
            AssignInventorySlotNumbers();
        }
    }

    public void AssignInventorySlotNumbers()
    {
        for (int x = 0; x < Items.Count(); x++)
        {
            Items[x].SlotNumber = x;
        }
    }

    public void SwapItems(InventorySlot slot1, InventorySlot slot2)
    {
        if (slot1 != null && slot2 != null)
        {
            InventorySlot temp = slot1;
            Items[slot1.SlotNumber] = slot2;
            Items[slot2.SlotNumber] = slot1;
            AssignInventorySlotNumbers();


        }
    }


}