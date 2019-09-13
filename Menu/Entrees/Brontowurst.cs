/*
 * Agustin Rodriguez 
 * Dino-Diner
 * Brontowurst.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class implements the Brontowurst menu item at Dino-Diner
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// The user has the option of whether or not to include a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// The user has the option of whether or not to include peppers
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// The user has the option of whether or not to include onions
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// gets the price of the menu item
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// gets and assigns the calories of the menu item 
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This list contains all of the ingredients the user can can with the exception of the brautwurst which is not an optional ingredient
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Initializes the price and calories of the menu item 
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// this method will withhold the bun from being put on the brautwurst if the user chooses so
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// this method will withhold the peppers from being put on the brautwurst if the user chooses so
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// this method will withhold the onions from being put on the brautwurst if the user chooses so
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
