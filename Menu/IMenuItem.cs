/* IMenuItem.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{ 
    /// <summary>
    /// interface for the menu items
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// property that gets the price of a menu item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// property that gets the calories of a menu item 
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// property that gets ingredients of the menu items
        /// </summary>
        List<string> Ingredients { get; } 
    }
}
