/* FlavorSelection.xaml.cs
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
using DDFlavor = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// sodasaurus object for this class when choosing the flavor
        /// </summary>
        Sodasaurus tempsoda = new Sodasaurus();

        /// <summary>
        /// flavor property that will be set in this class
        /// </summary>
        public DDFlavor flavor { get; set; }

        /// <summary>
        /// combo backing variable dealt with in this class
        /// </summary>
        CretaceousCombo combo;

        /// <summary>
        /// initialize form
        /// </summary>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            tempsoda = soda;
            
        }

        /// <summary>
        /// combo selection form thatll allow drink flavor to be changed in the order for combo
        /// </summary>
        public FlavorSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            tempsoda = (Sodasaurus)combo.Drink;
        }


        /// <summary>
        /// If cherry is selected as the flavor, then the description is updated and returns to drink selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectCherry(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                tempsoda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                if (combo != null)
                {
                    combo.Drink = tempsoda;
                }
            }
            ReturnToDrinks(sender, args);
        }

        /// <summary>
        /// If chocolate is selected as the flavor, then the description is updated and returns to drink selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectChocolate(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                tempsoda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                if (combo != null)
                {
                    combo.Drink = tempsoda;
                }
            }
            ReturnToDrinks(sender, args);
        }

        /// <summary>
        /// If cola is selected as the flavor, then the description is updated and returns to drink selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectCola(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                tempsoda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                if (combo != null)
                {
                    combo.Drink = tempsoda;
                }
            }
            ReturnToDrinks(sender, args);
        }

        /// <summary>
        /// If Lime is selected as the flavor, then the description is updated and returns to drink selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectLime(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                tempsoda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                if (combo != null)
                {
                    combo.Drink = tempsoda;
                }
            }
            ReturnToDrinks(sender, args);
        }

        /// <summary>
        /// If RootBeer is selected as the flavor, then the description is updated and returns to drink selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectRootBeer(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                tempsoda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                if (combo != null)
                {
                    combo.Drink = tempsoda;
                }
            }
            ReturnToDrinks(sender, args);
        }

        /// <summary>
        /// If Orange is selected as the flavor, then the description is updated and returns to drink selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectOrange(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                tempsoda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                if (combo != null)
                {
                    combo.Drink = tempsoda;
                }
            }
            ReturnToDrinks(sender, args);
        }

        /// <summary>
        /// If Vanilla is selected as the flavor, then the description is updated and returns to drink selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectVanilla(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                tempsoda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
                if (combo != null)
                {
                    combo.Drink = tempsoda;
                }
            }
            ReturnToDrinks(sender, args);
        }

        /// <summary>
        /// this method will return to the drink selection page and will pass in the soda object with the selected flavor or combo object with combo drink
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        void ReturnToDrinks(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new DrinkSelection(combo));
            }
           else
            {
                NavigationService.Navigate(new DrinkSelection(tempsoda));
            }
        }
    }
}
