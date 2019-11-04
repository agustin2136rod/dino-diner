﻿/* CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {

        CretaceousCombo combo;
        Order order = new Order();

        /// <summary>
        /// initialize form
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            Side.Content = this.combo.Side.ToString();
            Drink.Content = this.combo.Drink.ToString();
        }

        /// <summary>
        /// does not use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// navigates to the side selection form
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        /// <summary>
        /// navigates to the drink selection form
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
