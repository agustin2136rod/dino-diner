/* Tyrannotea.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
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
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
                if (Sweet)
                {
                    Calories *= 2;
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Description");
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
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

        /// <summary>
        /// overrides the ToString method and returns menu item as a string with size
        /// </summary>
        /// <returns></returns>string menu item with size
        public override string ToString()
        {
            if (Sweet)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Sweet Tyrannotea";
                    case Size.Medium:
                        return $"Medium Sweet Tyrannotea";
                    case Size.Large:
                        return $"Large Sweet Tyrannotea";
                }
            }
            else
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Tyrannotea";
                    case Size.Medium:
                        return $"Medium Tyrannotea";
                    case Size.Large:
                        return $"Large Tyrannotea";
                }
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
