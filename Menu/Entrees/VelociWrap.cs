/* VelociWrap.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
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
        /// gets the price and assigns it to the price variable 
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// gets the value of calories and assigns it to the variable calories 
        /// </summary>
        public uint Calories { get; set; }

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
    }
}
