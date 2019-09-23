/* MezzorellaSticks.cs
 * Author: Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Sides
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
        /// initializes the class with ingredients, price, and calories of the side item
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            ingredients.Add("Cheese Product");
            ingredients.Add("Breading");
            ingredients.Add("Vegetable Oil");
        }
    }
}
