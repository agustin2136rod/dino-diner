/* TRexKingBurger.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class is implementing the TRexKingBurger on the menu at DinoDiner
    /// the burger is constructed in this class
    /// </summary>
    public class TRexKingBurger : Entree
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
        /// This list contains all of the ingredients of the TRexKingBurger
        /// each ingredient with the exception of three steadburger patties are optional per the user
        /// </summary>
        public override List<string> Ingredients
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// If the user decides to not include lettuce
        /// sets it false
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// If the user decides to not include tomato
        /// sets it false
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// If the user decides to not include pickles
        /// sets it false
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// If the user decides to not include ketchup
        /// sets it false
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// If the user decides to not include mustard
        /// sets it false
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// If the user decides to not include mayo
        /// sets it false
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// If the user decides to not include onion
        /// sets it false
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
            return $"T-Rex King Burger";
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
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Tomato) special.Add("Hold Tomato");
                if (!Onion) special.Add("Hold Onion");
                if (!Mayo) special.Add("Hold Mayo");
                if (!Bun) special.Add("Hold Bun");
                return special.ToArray();
            }
        }
    }
}
