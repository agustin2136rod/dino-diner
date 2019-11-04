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

        public CustomizeBrontowurst(Brontowurst wurst)
        {
            InitializeComponent();
            braut = wurst;
        }

        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            braut = (Brontowurst)combo.Entree;
        }



        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            braut.HoldBun();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            braut.HoldOnion();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            braut.HoldPeppers();
        }

        /// <summary>
        /// this method will take us back to 
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
