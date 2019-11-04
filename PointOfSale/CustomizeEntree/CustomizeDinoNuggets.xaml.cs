/* CustomizeDinoNuggets.xaml.cs
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// dino nuggets object backing variable
        /// </summary>
        DinoNuggets nuggets;

        /// <summary>
        /// combo backing variable
        /// </summary>
        CretaceousCombo combo;

        /// <summary>
        /// constructor for entree nuggets
        /// </summary>
        /// <param name="nuggs">entree nuggets brought in</param>
        public CustomizeDinoNuggets(DinoNuggets nuggs)
        {
            InitializeComponent();
            nuggets = nuggs;
        }

        /// <summary>
        /// constructor if dealing with a combo selection
        /// </summary>
        /// <param name="combo">combo brought in</param>
        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            nuggets = (DinoNuggets)combo.Entree;
        }


        /// <summary>
        /// this method will take us back to the previous page or to customizecombo selection
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the data content</param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo == null)
            {
                NavigationService.GoBack();
            }
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        /// <summary>
        /// this method adds a nugget to the order
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the data content</param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nuggets.AddNugget();
        }
    }
}
