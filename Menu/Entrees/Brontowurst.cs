/* Brontowurst.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class implements the Brontowurst menu item at Dino-Diner
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// The user has the option of whether or not to include a bun
        /// </summary>
        private bool Bun = true;

        /// <summary>
        /// The user has the option of whether or not to include peppers
        /// </summary>
        private bool Peppers = true;

        /// <summary>
        /// The user has the option of whether or not to include onions
        /// </summary>
        private bool Onion = true;

        

        /// <summary>
        /// This list contains all of the ingredients the user can can with the exception of the brautwurst which is not an optional ingredient
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
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
            this.Bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// this method will withhold the peppers from being put on the brautwurst if the user chooses so
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// this method will withhold the onions from being put on the brautwurst if the user chooses so
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// overrides the ToString method and returns menu item as a string 
        /// </summary>
        /// <returns></returns>string menu item 
        public override string ToString()
        {
            return $"Brontowurst";
        }

        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// gets special instructions for food prep
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Onion) special.Add("Hold Onion");
                if (!Peppers) special.Add("Hold Peppers");
                if (!Bun) special.Add("Hold Bun");
                return special.ToArray();
            }
        }
    }
}
