/* PterodactylWings.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class implements the making of the menu item Pterodactyl wings in Dino-Diner
    /// </summary>
    public class PterodactylWings : Entree
    {


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

        /// <summary>
        /// overrides the ToString method and returns menu item as a string 
        /// </summary>
        /// <returns></returns>string menu item 
        public override string ToString()
        {
            return $"Pterodactyl Wings";
        }


    }
}
