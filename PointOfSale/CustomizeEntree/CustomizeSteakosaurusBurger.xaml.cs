/* CustomizeSteakosaurusBurger.xaml.cs
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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        /// <summary>
        /// steakosaurus burger backing variable
        /// </summary>
        SteakosaurusBurger burger;

        /// <summary>
        /// combo backing variable
        /// </summary>
        CretaceousCombo combo;

        /// <summary>
        /// constructor if dealing with entree steakosaurus
        /// </summary>
        /// <param name="b">entree steakosaurus burger</param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger b)
        {
            InitializeComponent();
            burger = b;
        }

        /// <summary>
        /// constructor if dealing with combo selection
        /// </summary>
        /// <param name="combo">combo that is brought in</param>
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            burger = (SteakosaurusBurger)combo.Entree;
        }

        /// <summary>
        /// this method will take us back to the previous page or to customize combo page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the data content</param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                NavigationService.GoBack();
            }            
        }

        /// <summary>
        /// this method will hold the bun for Steakosaurus burger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }

        /// <summary>
        /// this method will hold the pickle for Steakosaurus burger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }

        /// <summary>
        /// this method will hold the ketchup for Steakosaurus burger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }

        /// <summary>
        /// this method will hold the mustard for Steakosaurus burger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }
    }
}
