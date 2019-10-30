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

        TRexKingBurger burger;

        public CustomizeTRexKingBurger(TRexKingBurger b)
        {
            InitializeComponent();
            burger = b;
        }

        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            burger.HoldMayo();
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            burger.HoldLettuce();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            burger.HoldOnion();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            burger.HoldTomato();
        }

        /// <summary>
        /// this method will take us back to the previous page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the data content</param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
