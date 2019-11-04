/* CustomizeVelociwrap.xaml.cs
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
    /// Interaction logic for CustomizeVelociwrap.xaml
    /// </summary>
    public partial class CustomizeVelociwrap : Page
    {
        /// <summary>
        /// velociwrap backing variable
        /// </summary>
        VelociWrap wrap;

        /// <summary>
        /// combo backing variable dealt with in this class
        /// </summary>
        CretaceousCombo combo;

        /// <summary>
        /// constructor that deals with only entree
        /// </summary>
        /// <param name="veloci">velociwrap entree brought in</param>
        public CustomizeVelociwrap(VelociWrap veloci)
        {
            InitializeComponent();
            wrap = veloci;
        }

        /// <summary>
        /// constructor that deals wtih combo selection
        /// </summary>
        /// <param name="combo">combo brought in</param>
        public CustomizeVelociwrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            wrap = (VelociWrap)combo.Entree;
        }

        /// <summary>
        /// this method will hold lettuce for the VelociWrap
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }

        /// <summary>
        /// this method will hold dressing for the VelociWrap
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }

        /// <summary>
        /// this method will hold cheese for the VelociWrap
        /// </summary>
        /// <param name="sender">object reference</param>
        /// <param name="args">event data</param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
        }

        /// <summary>
        /// this method will take us back to the previous page or take us to customize combo page
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
