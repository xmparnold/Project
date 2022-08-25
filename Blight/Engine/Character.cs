#pragma warning disable CS8618

namespace Blight.Engine;

public class Character
{
    public int CharacterId { get; set; }
    public int CharacterClassId { get; set; }
    public CharacterClass Class { get; set; }
    public int Level { get; set; }
    public int StatPoints { get; set; }
    public int Experience { get; set; }
    public int CraftingLevel { get; set; }
    public int CraftingExperience { get; set; }
    public int Gold { get; set; }
    public List<Ability> Abilities { get; set; } = new List<Ability>();
    public List<Ability> CurrentAbilities { get; set; } = new List<Ability>();
    public List<PassiveAbility> PassiveAbilities { get; set; } = new List<PassiveAbility>();
    public List<PassiveAbility> CurrentPassiveAbilities { get; set; } = new List<PassiveAbility>();
    public Inventory CharacterInventory { get; set; }
    public int Health { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public int Strength { get; set; }
    public int Defense { get; set; }
    public int Stamina { get; set; }

}