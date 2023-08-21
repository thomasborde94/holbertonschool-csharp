using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie
    /// </summary>
    public class Zombie
    {
        /// <summary>The zombie's health</summary>
        public int health;

        /// <summary>
        /// Creates a Zombie object with health 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Creates a zombie with specified health
        /// </summary>
        /// <param name="value">Zombie's health</param>
        /// <exception cref="ArgumentException">Health was less than 0</exception>
        public Zombie(int value)
        {
            if (value >= 0)
                health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }

        /// <summary>
        /// Gets the health of the Zombie object
        /// </summary>
        /// <returns>Value of health of the Zombie object</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
