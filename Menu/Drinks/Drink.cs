/* Drink.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// this is the base class for Drinks in Dino-Diner
    /// </summary>
    public abstract class Drink
    {

        /// <summary>
        /// ingredients in each drink
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Ice in the drink
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// no ice in the drink
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
