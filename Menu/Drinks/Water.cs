/* Water.cs
 * Author: Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
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

        /// <summary>
        /// overrides the ToString method and returns menu item as a string along with size
        /// </summary>
        /// <returns></returns>string menu item with size
        public override string ToString()
        {
            switch (size)
            {
                case Size.Small:
                    return $"Small Water";
                case Size.Medium:
                    return $"Medium Water";
                case Size.Large:
                    return $"Large Water";
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
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
