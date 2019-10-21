/* Side.cs
 * Edited by: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
  
    /// <summary>
    /// abstract class that is not changeable. Deals with ingredients, price, and calories. Gets and sets them all
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        public abstract List<string> Ingredients {get;} 

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

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
