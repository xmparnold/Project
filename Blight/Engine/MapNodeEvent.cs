#pragma warning disable CS8618
namespace Blight.Engine;

public class MapNodeEvent
{
    public int MapNodeEventId { get; set; }
    public string EventTitle { get; set; }
    public bool GiveItem { get; set; }
    public Item? Item { get; set; }
    public bool GiveBuff { get; set; }
    public bool GiveDebuff { get; set; }
    public bool Teleport { get; set; }
    public int? TelportX { get; set; }
    public int? TeleportY { get; set; }
    public Map? TelportMap { get; set; }
    public MapNode TeleportMapNode { get; set; }
    public bool StartFight { get; set; }
    public bool FindGold { get; set; }
    public bool UnlockedChest { get; set; }
    public bool LockedChest { get; set; }
    public bool Obstacle { get; set; }
    public bool Trap { get; set; }
    public bool ResourceToHarvest { get; set; }
}