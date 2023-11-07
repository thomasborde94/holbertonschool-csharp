using System;

/// <summary>Defines Player class</summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Handles health related events</summary>
    public delegate void CalculateHealth(float amount);
    /// <summary>
    /// Prints damage taken
    /// </summary>
    /// <param name="damage">amount of damage taken</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
            Console.WriteLine($"{name} takes 0 damage!");
        else
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(hp - damage);
    }
    /// <summary>
    /// Prints damage healed
    /// </summary>
    /// <param name="heal">Amount of damage healed</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
            Console.WriteLine($"{name} heals 0 HP!");
        else
            Console.WriteLine($"{name} heals {heal} HP!");
            ValidateHP(hp + heal);
    }

    /// <summary>
    /// sets the new value of the Player’s hp
    /// </summary>
    /// <param name="newHp">new value</param>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }
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
