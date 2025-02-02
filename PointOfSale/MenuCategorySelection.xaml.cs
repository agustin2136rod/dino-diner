﻿/* MenuCategorySelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// initialize form
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// navigates to the combo selection form
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// navigates to the entree selection form
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// navigates to the side selection form
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
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
