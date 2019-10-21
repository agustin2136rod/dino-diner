/* Drink.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the base class for Drinks in Dino-Diner
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// implement interface for INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// an event handler to notify if a field/property is changed
        /// </summary>
        /// <param name="propertyName">name of the property changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// ingredients in each drink
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Ice in the drink
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// no ice in the drink
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// same as the ToString() implementation of the order item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// any special food instructions for food prep
        /// </summary>
        public abstract string[] Special { get; }
    }
}
