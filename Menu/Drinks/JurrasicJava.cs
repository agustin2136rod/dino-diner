﻿/* JurrasicJava.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class implements the coffee at dinodiner that inherits from Drink base class
    /// </summary>
    public class JurrasicJava : Drink
    {

        

        /// <summary>
        /// whether or not you need room for cream
        /// </summary>
        private bool roomForCream;


        /// <summary>
        /// property that will set room for cream in cofffee
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
            }
        }

        /// <summary>
        /// if you want coffee decaf
        /// </summary>
        private bool decaf;

        /// <summary>
        /// property that keeps coffee decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;

            }
        }

        /// <summary>
        /// size for the drink
        /// </summary>
        protected Size size;

        /// <summary>
        /// initializes the drink as a small and no room for cream or decaf
        /// </summary>
        public JurrasicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
            this.roomForCream = false;
            this.decaf = false;
        }

        /// <summary>
        /// this method will leave room for cream in coffee
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// this method adds ice to the coffee
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// this method makes coffee decaf
        /// </summary>
        public void DecafCoffee()
        {
            Decaf = true;
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// Sets size, price, and calories for the coffee. If sweetener is added the calories are doubled
        /// </summary>
        public override Size Size
        {

            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
            }
            get
            { return size; }
        }

        /// <summary>
        /// ingredients in the coffee
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
                return ingredients;
            }
        }

        /// <summary>
        /// overrides the ToString method and returns menu item as a string with size
        /// </summary>
        /// <returns></returns>string menu item with size
        public override string ToString()
        {
            if (Decaf)
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Decaf Jurassic Java";
                    case Size.Medium:
                        return $"Medium Decaf Jurassic Java";
                    case Size.Large:
                        return $"Large Decaf Jurassic Java";
                }
            }
            else
            {
                switch (size)
                {
                    case Size.Small:
                        return $"Small Jurassic Java";
                    case Size.Medium:
                        return $"Medium Jurassic Java";
                    case Size.Large:
                        return $"Large Jurassic Java";
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
                if (Ice) special.Add("Add Ice");
                if (roomForCream) special.Add("Leave Room For Cream");
                return special.ToArray();
            }
        }

    }
}
