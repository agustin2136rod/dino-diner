/* MeteorMacAndCheese.cs
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
    /// this class implements the MeteorMacAndCheese side item in DinoDiner. The class inherits from Side
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// size object for the side item
        /// </summary>
        protected Size size;



        /// <summary>
        /// gets and sets the size, calories, and price of the menu item depending on what value is brought in
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch(size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
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
        /// overrides the ingredients property and sets the ingredients equal to those specific to this menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
                return ingredients;
            }
        }


        /// <summary>
        /// initializes the class with ingredients, price, and calories of the side item
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;

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
                    return $"Small Meteor Mac and Cheese";
                case Size.Medium:
                    return $"Medium Meteor Mac and Cheese";
                case Size.Large:
                    return $"Large Meteor Mac and Cheese";
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
