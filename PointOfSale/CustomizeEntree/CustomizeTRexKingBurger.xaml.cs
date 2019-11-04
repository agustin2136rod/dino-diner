/* CustomizeTRexKingBurger.xaml.cs
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// burger backing variable
        /// </summary>
        TRexKingBurger burger;

        /// <summary>
        /// combo backing variable dealt with in this class
        /// </summary>
        CretaceousCombo combo;

        /// <summary>
        /// constructor if only dealing with entree
        /// </summary>
        /// <param name="b">TRexKingBurger brought in</param>
        public CustomizeTRexKingBurger(TRexKingBurger b)
        {
            InitializeComponent();
            burger = b;
        }

        /// <summary>
        /// constructor if dealing with a combo
        /// </summary>
        /// <param name="combo">combo brought in</param>
        public CustomizeTRexKingBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            burger = (TRexKingBurger)combo.Entree;
        }

        /// <summary>
        /// this method will hold mayo for the TRexKingBurger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            burger.HoldMayo();
        }

        /// <summary>
        /// this method will hold bun for the TRexKingBurger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }

        /// <summary>
        /// this method will hold ketchup for the TRexKingBurger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }

        /// <summary>
        /// this method will hold mustard for the TRexKingBurger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }

        /// <summary>
        /// this method will hold pickle for the TRexKingBurger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }

        /// <summary>
        /// this method will hold lettuce for the TRexKingBurger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            burger.HoldLettuce();
        }

        /// <summary>
        /// this method will hold onion for the TRexKingBurger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            burger.HoldOnion();
        }

        /// <summary>
        /// this method will hold tomato for the TRexKingBurger
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            burger.HoldTomato();
        }

        /// <summary>
        /// this method will take us back to the previous page or to the customize combo page
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
    }
}
