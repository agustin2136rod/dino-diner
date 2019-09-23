/* MeteorMacAndCheese.cs
 * Author: Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Sides
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
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
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
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            ingredients.Add("Macaroni Noodles");
            ingredients.Add("Cheese Product");
            ingredients.Add("Pork Sausage");
        }
    }
}
