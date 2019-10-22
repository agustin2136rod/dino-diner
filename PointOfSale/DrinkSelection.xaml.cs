/* DrinkSelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// initializes the xaml DrinkSelection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }


        /// <summary>
        /// event handler for water that deals with adding lemon
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            SpecialButtons.Children.Clear();
            Button lemon = new Button();
            lemon.Height = 100;
            lemon.Width = 100;
            lemon.Content = "AddLemon";
            SpecialButtons.Children.Add(lemon);
        }

        /// <summary>
        /// event handler for the tyrannotea drink item that asks if we want to make it sweet and if we want to add lemon
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            SpecialButtons.Children.Clear();
            Button tt = new Button();
            tt.Height = 100;
            tt.Width = 100;
            tt.Content = "Sweet";
            SpecialButtons.Children.Add(tt);

            Button lemon = new Button();
            lemon.Height = 100;
            lemon.Width = 100;
            lemon.Content = "AddLemon";
            SpecialButtons.Children.Add(lemon);
        }

        /// <summary>
        /// event handler for the JurassicJava that deals with making the coffee decaf
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void SelectJava(object sender, RoutedEventArgs args)
        {
            SpecialButtons.Children.Clear();
            Button jj = new Button();
            jj.Height = 100;
            jj.Width = 100;
            jj.Content = "Decaf";
            SpecialButtons.Children.Add(jj);
        }

        /// <summary>
        /// when the sodasaurus button is clicked, there is a new button that pops up displaying flavor
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            SpecialButtons.Children.Clear();
            Button soda = new Button();
            soda.Height = 100;
            soda.Width = 100;
            soda.Content = "Flavor";
            SpecialButtons.Children.Add(soda);
            soda.Click += new RoutedEventHandler(SelectFlavor);
        }

        /// <summary>
        /// when the button "flavor" is clicked this method will take us to the flavor selection xaml
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }


    }    
}
