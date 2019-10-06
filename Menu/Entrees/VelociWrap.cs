/* VelociWrap.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class implements the menu item velociwrap and it is constructed here
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// user has the option to include dressing
        /// </summary>
        private bool Dressing = true;

        /// <summary>
        /// user has the option to include lettuce
        /// </summary>
        private bool Lettuce = true;

        /// <summary>
        /// user has the option to include cheese
        /// </summary>
        private bool Cheese = true;


        /// <summary>
        /// list of ingredients included on the Wrap that are optional with the exception of 
        /// the flour tortilla and the chicken breast
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// constructor that initializes the price and calories of the wrap
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// if the user chooses not to include dressing
        /// takes it off
        /// </summary>
        public void HoldDressing()
        {
            this.Dressing = false;
        }

        /// <summary>
        /// if the user chooses not to include lettuce
        /// takes it off
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        /// <summary>
        /// if the user chooses not to include cheese
        /// takes it off
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
        }

        /// <summary>
        /// overrides the ToString method and returns menu item as a string 
        /// </summary>
        /// <returns></returns>string menu item 
        public override string ToString()
        {
            return $"Veloci-Wrap";
        }
    }
}
