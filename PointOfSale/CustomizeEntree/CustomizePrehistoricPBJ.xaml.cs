/* CustomizePrehistoricPBJ.xaml.cs
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// private instance of PBJ that we manipulate in this class
        /// </summary>
        private PrehistoricPBJ pbj;

        /// <summary>
        /// combo backing variable
        /// </summary>
        CretaceousCombo combo;

        /// <summary>
        /// constructor for this class that sets the pbj to the one brought in as a parameter
        /// </summary>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pBJ)
        {
            InitializeComponent();
            pbj = pBJ;
        }

        /// <summary>
        /// constructor for this class that deals with combos being brought in
        /// </summary>
        public CustomizePrehistoricPBJ(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            pbj = (PrehistoricPBJ)combo.Entree;
        }

        /// <summary>
        /// this method will modify the special for PBJ and hold peanut butter 
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the data content</param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        /// <summary>
        /// this method will modify the special for PBJ and hold Jelly
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the data content</param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        /// <summary>
        /// this method will take us back to customize combo or go back
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
