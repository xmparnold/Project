#pragma warning disable CS8618

namespace Blight.Engine;

public class Monster
{
    //public int MonsterId { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackRating { get; set; }
    public int Strength { get; set; }
    public int Defense { get; set; }
    public DropTable DropTable { get; set; }

    public Monster(string name, int health, int attackRating, int strength, int defense)
    {
        DropTable = new DropTable(name + "DropTable");
        Name = name;
        Health = health;
        AttackRating = attackRating;
        Strength = strength;
        Defense = defense;

    }

    public Monster(string name, int health, int attackRating, int strength, int defense, DropTable drops)
    {
        DropTable = drops;
        Name = name;
        Health = health;
        AttackRating = attackRating;
        Strength = strength;
        Defense = defense;

    }


    

}