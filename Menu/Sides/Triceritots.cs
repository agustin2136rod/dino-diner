/* Triceritots.cs
 * Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class implements the side item Triceritots in DinoDiner. The class inherits from Side
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// size object of the food item
        /// </summary>
        protected Size size;

     
        /// <summary>
        /// gets and sets the size, price and calories of the side item depending on what value is brought in
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break; 
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
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
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// initializes the class with size, ingredients, and calories
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;

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
                    return $"Small Triceritots";
                case Size.Medium:
                    return $"Medium Triceritots";
                case Size.Large:
                    return $"Large Triceritots";
            }
            return base.ToString();
        }
    }
}
