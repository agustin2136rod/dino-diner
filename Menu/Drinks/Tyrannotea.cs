/* Tyrannotea.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// This class represents the drink Tyrannotea that inherits from Drink base class
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// whether or not tea is sweet
        /// </summary>
        private bool sweet;

        /// <summary>
        /// property that deals with sweet for the tea
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                this.Size = this.Size;
            }
        }

        /// <summary>
        /// size of the drink
        /// </summary>
        protected Size size;

        /// <summary>
        /// property for lemon that is initialized to false
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// constructor that initializes the drink to small
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            this.Size = Size.Small;

        }

        /// <summary>
        /// price of the drink
        /// </summary>
        public double Price { get; set; } = 0.99;

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
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
                if (Sweet)
                {
                    Calories *= 2;
                }
            }
            get
            { return size; }

        }

       
        /// <summary>
        /// add lemon to the drink
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// ingredients of the drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {
                    "Water", "Tea"
                };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        
    }


}
