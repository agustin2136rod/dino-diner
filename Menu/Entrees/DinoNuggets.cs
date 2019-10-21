/* DinoNuggets.cs
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
    /// This class implements the menu item DinoNuggets at Dino-Diner
    /// </summary>
    public class DinoNuggets : Entree
    {
    
        /// <summary>
        /// counter variable for the nuggets
        /// </summary>
        private int Count = 6;

        

        /// <summary>
        /// Contains the list of ingredients (chicken nuggets) 
        /// Menu item comes with 6 
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < Count; i++) {
                     ingredients.Add("Chicken Nugget");
                    
                }
                return ingredients;
            }

        }

        /// <summary>
        /// Initializes DinoNuggets with the price and calories of the menu item
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// The user has the option to add nuggets
        /// if the user adds nuggets, the price and calories are updated with each nugget added
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.Count++;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
        }

        /// <summary>
        /// overrides the ToString method and returns menu item as a string 
        /// </summary>
        /// <returns></returns>string menu item 
        public override string ToString()
        {
            return $"Dino-Nuggets";
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
                if (Count > 6)
                {
                    int temp = Count - 6;
                    special.Add(temp + " Extra Nuggets");
                } 
                return special.ToArray();
            }
        }
    }
}
