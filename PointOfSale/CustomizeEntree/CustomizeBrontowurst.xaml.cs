/* CustomizeBrontowurst.xaml.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// braut private variable
        /// </summary>
        Brontowurst braut;

        /// <summary>
        /// if we are dealing with customize combo
        /// </summary>
        CretaceousCombo combo;

        /// <summary>
        /// constructor if not dealing with combo
        /// </summary>
        /// <param name="wurst">entree item brought in</param>
        public CustomizeBrontowurst(Brontowurst wurst)
        {
            InitializeComponent();
            braut = wurst;
        }

        /// <summary>
        /// constructor if dealing with a combo
        /// </summary>
        /// <param name="combo">combo brought in</param>
        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            braut = (Brontowurst)combo.Entree;
        }


        /// <summary>
        /// hold bun for brontowurst
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            braut.HoldBun();
        }

        /// <summary>
        /// hold onion for brontowurst
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            braut.HoldOnion();
        }

        /// <summary>
        /// hold peppers for brontowurst
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            braut.HoldPeppers();
        }

        /// <summary>
        /// this method will take us back to either customize combo page or go back to entree selection
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
