#pragma warning disable CS8618

namespace Blight.Engine;

public class Shop
{
    public int ShopId { get; set; }
    public string ShopName { get; set; }
    public List<ShopSlot> Items { get; set; }
    public bool CanSellTo { get; set; }
}