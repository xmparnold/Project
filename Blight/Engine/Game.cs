#pragma warning disable CS8618

namespace Blight.Engine;
public class Game
{
    public int GameId { get; set; }

    // 0 = in Town, 1 = in Dungeon
    public int PlayerLocation { get; set; } = 0;
    public Dungeon? DungeonIn { get; set; }
    public int? DungeonX { get; set; }
    public int? DungeonY { get; set; }
    public int PlayerId { get; set; }
    public Player GamePlayer { get; set; }
    public int CharacterId { get; set; }
    public Character PlayerCharacter { get; set; }
    public List<Dungeon> Dungeons { get; set; }


}