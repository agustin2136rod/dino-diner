﻿/* MainWindow.xaml.cs
 * Author: Agustin Rodriguez
 */
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// constructor for the class
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            OrderUI.Navigate(new MenuCategorySelection());
            Order.NavigationService = OrderUI.NavigationService;
            /*
            if (order != null)
            {
                order.Items.Add(new PrehistoricPBJ());
                order.Items.Add(new Sodasaurus());
                order.Items.Add(new Fryceritops());
                SteakosaurusBurger sb = new SteakosaurusBurger();
                sb.HoldPickle();
                sb.HoldBun();
                order.Items.Add(sb);
            }
            */
        }

        /// <summary>
        /// this method will pass on data content if its a page that its being passed to
        /// </summary>
        private void PassDataContentToPage()
        {
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// When the load has completed, the passdatacontenttopage method is called
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// if any data context is changed, this method will update and notify through the PassDataContentToPage method
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }

        public void OnReturnToCatagorySelection(object sender, RoutedEventArgs args)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
