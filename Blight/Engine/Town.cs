#pragma warning disable CS8618

namespace Blight.Engine;

public class Town
{
    public int TownId { get; set; }
    public string TownName { get; set; }
    public List<Player> PlayersInTown { get; set; }
    public List<Shop> Shops { get; set; }
    
}