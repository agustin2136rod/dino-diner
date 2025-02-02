﻿/* SteakosaurusBurger.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class implements the menu item SteakosaurusBurger in Dino-Diner. The burger is created
    /// </summary>
    public class SteakosaurusBurger : Entree
    {

        

        /// <summary>
        /// user has option to have a bun
        /// </summary>
        private bool Bun = true;

        /// <summary>
        /// user has the option to put pickles on the burger
        /// </summary>
        private bool Pickle= true;

        /// <summary>
        /// user has the option to put ketchup on the burger
        /// </summary>
        private bool Ketchup = true;

        /// <summary>
        /// user has the option to put mustard on the burger
        /// </summary>
        private bool Mustard = true;

       

        /// <summary>
        /// List of ingredients to the burger that is depicted by what the user wants on the burger except 
        /// for the Steakburger pattie that comes with the menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// constructor for the Steakosaurus burger that sets the price and calories of the menu item 
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// user chooses not to have the bun
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// user chooses not to have pickles
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// user chooses not to have ketchup on the burger
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// user chooses not to have mustard on the burger
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// overrides the ToString method and returns menu item as a string 
        /// </summary>
        /// <returns></returns>string menu item 
        public override string ToString()
        {
            return $"Steakosaurus Burger";
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
                if (!Bun) special.Add("Hold Bun");
                return special.ToArray();
            }
        }
    }
}
