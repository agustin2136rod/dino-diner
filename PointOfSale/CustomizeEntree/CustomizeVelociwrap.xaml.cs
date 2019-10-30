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
    /// Interaction logic for CustomizeVelociwrap.xaml
    /// </summary>
    public partial class CustomizeVelociwrap : Page
    {

        VelociWrap wrap;

        public CustomizeVelociwrap(VelociWrap veloci)
        {
            InitializeComponent();
            wrap = veloci;
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }

        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
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
