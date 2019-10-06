/* Sodasaurus.cs
 * Author: Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
        /// initializes the drink to size small
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
            this.Price = 1.50;
            this.Calories = 112;
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

        /// <summary>
        /// overrides the ToString method and returns menu item as a string with size
        /// </summary>
        /// <returns></returns>string menu item with size
        public override string ToString()
        {
            if (Flavor == SodasaurusFlavor.Cola)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Cola Sodasaurus";
                    case Size.Medium:
                        return $"Medium Cola Sodasaurus";
                    case Size.Large:
                        return $"Large Cola Sodasaurus";
                }
            }

            else if (Flavor == SodasaurusFlavor.Orange)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Orange Sodasaurus";
                    case Size.Medium:
                        return $"Medium Orange Sodasaurus";
                    case Size.Large:
                        return $"Large Orange Sodasaurus";
                }
            }

            else if (Flavor == SodasaurusFlavor.Vanilla)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Vanilla Sodasaurus";
                    case Size.Medium:
                        return $"Medium Vanilla Sodasaurus";
                    case Size.Large:
                        return $"Large Vanilla Sodasaurus";
                }
            }

            else if (Flavor == SodasaurusFlavor.Chocolate)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Chocolate Sodasaurus";
                    case Size.Medium:
                        return $"Medium Chocolate Sodasaurus";
                    case Size.Large:
                        return $"Large Chocolate Sodasaurus";
                }
            }

            else if (Flavor == SodasaurusFlavor.RootBeer)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small RootBeer Sodasaurus";
                    case Size.Medium:
                        return $"Medium RootBeer Sodasaurus";
                    case Size.Large:
                        return $"Large RootBeer Sodasaurus";
                }
            }

            else if (Flavor == SodasaurusFlavor.Cherry)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Cherry Sodasaurus";
                    case Size.Medium:
                        return $"Medium Cherry Sodasaurus";
                    case Size.Large:
                        return $"Large Cherry Sodasaurus";
                }
            }

            else if (Flavor == SodasaurusFlavor.Lime)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Lime Sodasaurus";
                    case Size.Medium:
                        return $"Medium Lime Sodasaurus";
                    case Size.Large:
                        return $"Large Lime Sodasaurus";
                }
            }
            return base.ToString();
        }
    }
}
