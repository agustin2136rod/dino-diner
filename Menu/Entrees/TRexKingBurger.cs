/* TRexKingBurger.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class is implementing the TRexKingBurger on the menu at DinoDiner
    /// the burger is constructed in this class
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// the user has the option of whether or not to have a bun
        /// </summary>
        private bool Bun = true;

        /// <summary>
        /// The user has the option of whether or not to have lettuce
        /// </summary>
        private bool Lettuce = true;

        /// <summary>
        /// The user has the option of whether or not to have tomato
        /// </summary>
        private bool Tomato = true;

        /// <summary>
        /// The user has the option of whether or not to have onion
        /// </summary>
        private bool Onion = true;

        /// <summary>
        /// The user has the option of whether or not to have pickle
        /// </summary>
        private bool Pickle = true;

        /// <summary>
        /// The user has the option of whether or not to have ketchup
        /// </summary>
        private bool Ketchup = true;

        /// <summary>
        /// The user has the option of whether or not to have mustard
        /// </summary>
        private bool Mustard = true;

        /// <summary>
        /// The user has the option of whether or not to have mayo
        /// </summary>
        private bool Mayo = true;

        /// <summary>
        /// This Gets the price of the TRexKingBurger and assigns it to the price variable
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// calories of the burger are gotten when initialized and set to the calories variable
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This list contains all of the ingredients of the TRexKingBurger
        /// each ingredient with the exception of three steadburger patties are optional per the user
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Onion) ingredients.Add("Onion");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Tomato) ingredients.Add("Tomato");
                if (Mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// constructor that initializes the price and calories of the menu item TRexKingBurger
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// If the user decides to not include a bun 
        /// sets it false
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }

        /// <summary>
        /// If the user decides to not include lettuce
        /// sets it false
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        /// <summary>
        /// If the user decides to not include tomato
        /// sets it false
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
        }

        /// <summary>
        /// If the user decides to not include pickles
        /// sets it false
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }

        /// <summary>
        /// If the user decides to not include ketchup
        /// sets it false
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }

        /// <summary>
        /// If the user decides to not include mustard
        /// sets it false
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }

        /// <summary>
        /// If the user decides to not include mayo
        /// sets it false
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
        }

        /// <summary>
        /// If the user decides to not include onion
        /// sets it false
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
        }
    }
}
