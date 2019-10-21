/* Order.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class represents a new customer order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// represents the items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// calculates the total price from the prices of all order items
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double cost = 0;
                foreach(IOrderItem i in Items)
                {
                    cost += i.Price;
                }
                if (cost < 0)
                {
                    return 0;
                }
                return cost;
            }
        }

        /// <summary>
        /// sales tax in the location of the restaurant
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.065;

        /// <summary>
        /// amount of sales tax to be paid
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// total cost of order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }


    }
}
