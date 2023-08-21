using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The zombie's health
        /// </summary>
        public int health;

/// <summary>
/// Initializes a new instance of Zombie
/// </summary>
/// <param name="aHealth">The zombie's health</param>
        public Zombie(int aHealth = 0)
        {
            health = aHealth;
        }
    }
}
