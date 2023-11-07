using System;

/// <summary>Defines Player class</summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Player constructor
    /// </summary>
    /// <param name="name">name of the player</param>
    /// <param name="maxHp">max Hp of the player</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp > 0)
            this.maxHp = maxHp;
        else
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
        this.name = name;
    }

    /// <summary>Prints health of the player</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
