/* OrderList.xaml.cs
 * Author: Agustin Rodriguez
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /// <summary>
        /// Navigation service to move between pages
        /// </summary>
        public NavigationService NavigationService { get; set; }

        /// <summary>
        /// constructor that initializes the page
        /// </summary>
        public OrderList()
        {
            InitializeComponent();
        }

      

       
        /// <summary>
        /// To go to a new side selection page 
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="args">contains the data</param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
        }

        /// <summary>
        /// To remove an item from the order listbox
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="args">contains the data</param>
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }
    }
}
