/* Sodasaurus.cs
 * Author: Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// this class implements the sodasaurus drink in dinodiner that inherents from drink base class
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// flavor of the soda
        /// </summary>
        private SodasaurusFlavor flavor;
        
        /// <summary>
        /// size of the drink
        /// </summary>
        protected Size size;

        /// <summary>
        /// property that gets the flavor of the soda
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// property that gets the price of the soda that is default small
        /// </summary>
        public double Price { get; set; } = 1.5;

        /// <summary>
        /// initializes the drink to size small
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// property that sets the price, size, and calories of the drink
        /// </summary>
        public override Size Size
        {
            
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get
            { return size; }
        }

        /// <summary>
        /// ingredients of the soda
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }
    }
}
