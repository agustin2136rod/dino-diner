/* IOrderItem.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface implemented for Milestone 5 that deals with description, special, and price
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// gets description of the order item and matches the ToString() implementation
        /// </summary>
        string Description { get; }

        /// <summary>
        /// for any special instructions for the food perp
        /// </summary>
        string[] Special { get;}
    }
}
