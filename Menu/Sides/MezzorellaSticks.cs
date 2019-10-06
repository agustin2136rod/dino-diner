/* MezzorellaSticks.cs
 * Author: Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class implements the MezzorellaSticks side item in DinoDiner. The class inherits from Side
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// size object for the menu item
        /// </summary>
        protected Size size;

        

        /// <summary>
        /// gets and sets the size, price, and calories for the side item depending on what value is brought in
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
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
                List<string> ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
                return ingredients;
            }
        }


        /// <summary>
        /// initializes the class with ingredients, price, and calories of the side item
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;

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
                    return $"Small Mezzorella Sticks";
                case Size.Medium:
                    return $"Medium Mezzorella Sticks";
                case Size.Large:
                    return $"Large Mezzorella Sticks";
            }
            return base.ToString();
        }
    }
}
