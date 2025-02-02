﻿/* Fryceritops.cs
 * Author: Agustin Rodriguez
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class implements the side fryceritops in DinoDiner and Inherits from Side
    /// </summary>
    public class Fryceritops : Side
    {

        

        /// <summary>
        /// size object for the class
        /// </summary>
        protected Size size;

        
        
        /// <summary>
        /// gets and sets the size, price, and calories for the side item depending on what value it is.
        /// </summary>
        public override Size Size
        {
            
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// overrides the ingredients property for the specific ingredients for this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// initializes the ingredients, price, and calories for the side item
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            
        }

        /// <summary>
        /// overrides the ToString method and returns menu item as a string with size
        /// </summary>
        /// <returns></returns>string menu item and the size 
        public override string ToString()
        {
            switch (size)
            {
                case Size.Small:
                    return $"Small Fryceritops";
                case Size.Medium:
                    return $"Medium Fryceritops";
                case Size.Large:
                    return $"Large Fryceritops";
            }
            return base.ToString();
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
                return special.ToArray();
            }
        }
    }
}
