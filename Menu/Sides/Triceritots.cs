/* Triceritots.cs
 * Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
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
        /// initializes the class with size, ingredients, and calories
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            ingredients.Add("Potato");
            ingredients.Add("Vegetable Oil");
            ingredients.Add("Salt");
        }
    }
}
