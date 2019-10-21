/* Entree.cs
 * Edited by: Agustin Rodriguez 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{

    /// <summary>
    /// non changeable class that deals with price, calories and ingredients
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// same as the ToString() implementation of the order item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// any special food instructions for food prep
        /// </summary>
        public abstract string[] Special { get; }
    }
}
