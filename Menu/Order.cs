/* Order.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class represents a new customer order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// represents the items added to the order
        /// </summary>
        private List<IOrderItem> items;

        /// <summary>
        /// array that holds order items
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

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
        /// variable that holds the sales tax rate
        /// </summary>
        private double salesTaxRate;

        /// <summary>
        /// sales tax in the location of the restaurant
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            set
            {
                if (value < 0) return;
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

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

        /// <summary>
        /// property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// constructor for this class
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
            
        }

        /// <summary>
        /// method to add an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// method to remove items from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// this method will update the propertychangedeventargs for items, subtotal cost, sales tax cost, and total cost
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
