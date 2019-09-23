/* PterodactylWings.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class implements the making of the menu item Pterodactyl wings in Dino-Diner
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Gets the price of the wings and sets it to the variable price 
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets the calories of the menu item and assigns it to the variable calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The ingredients list for the menu item is chicken and wing sauce
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// This constructor sets the price and the calories for the given menu item
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        
    }
}
