/* Water.cs
 * Author: Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// this class implements the drink water in dino diner that inherits from drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// bool to add lemon to the water
        /// </summary>
        private bool lemon;

        /// <summary>
        /// property that will add lemon to the drink if bool is true
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// construtor for water that initializes the drink to small
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
            this.Lemon = false;
        }

        /// <summary>
        /// adds lemon to the drink
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// size of the drink
        /// </summary>
        protected Size size;

        /// <summary>
        /// sets the price, calories, and size of the drink 
        /// </summary>
        public override Size Size
        {

            set
            {
                size = value;
                Price = 0.10;
                Calories = 0;
            }
            get
            { return size; }
        }

        /// <summary>
        /// ingredients of the drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }


    }
}
