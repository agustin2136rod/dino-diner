/* 
 * Agustin Rodriguez 
 * Dino-Diner
 * TRexKingBurger.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class is implementing the TRexKingBurger on the menu at DinoDiner
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// the user has the option of whether or not to have a bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// The user has the option of whether or not to have lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// The user has the option of whether or not to have tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// The user has the option of whether or not to have onion
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// The user has the option of whether or not to have pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// The user has the option of whether or not to have ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// The user has the option of whether or not to have mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// The user has the option of whether or not to have mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// This Gets the price of the TRexKingBurger
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// calories of the burger are gotten when initialized 
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This list contains all of the ingredients of the TRexKingBurger
        /// each ingredient with the exception of three steadburger patties are optional
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (tomato) ingredients.Add("Tomato");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Initializes the price and calories of the menu item TRexKingBurger
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// If the user decides to not include a bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// If the user decides to not include lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// If the user decides to not include tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// If the user decides to not include pickles
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// If the user decides to not include ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// If the user decides to not include mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// If the user decides to not include mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

        /// <summary>
        /// If the user decides to not include onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
