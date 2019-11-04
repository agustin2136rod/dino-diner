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

        DinoNuggets nuggets;

        CretaceousCombo combo;

        public CustomizeDinoNuggets(DinoNuggets nuggs)
        {
            InitializeComponent();
            nuggets = nuggs;
        }

        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            nuggets = (DinoNuggets)combo.Entree;
        }


        /// <summary>
        /// this method will take us back to the previous page
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
        /// this method will take us back to the previous page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the data content</param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nuggets.AddNugget();
        }
    }
}
