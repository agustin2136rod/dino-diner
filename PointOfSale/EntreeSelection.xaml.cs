/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// entree object that will be set in this class
        /// </summary>
        public Entree entree { get; set; }

        /// <summary>
        /// initialize form
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If Brontowurst is selected as the entree, its added to the orderlist and returns to the menucatagory selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
            }
            MenuCategorySelectionPage(sender, args);
        }

        /// <summary>
        /// this method, when called, will return to the MenuCatagory Selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        void MenuCategorySelectionPage(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// If Dino-Nuggets is selected as the entree, its added to the orderlist and returns to the menucatagory selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
            }
            MenuCategorySelectionPage(sender, args);
        }

        /// <summary>
        /// If PBJ is selected as the entree, its added to the orderlist and returns to the menucatagory selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
            }
            MenuCategorySelectionPage(sender, args);
        }

        /// <summary>
        /// If Pterodactyl wings is selected as the entree, its added to the orderlist and returns to the menucatagory selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }
            MenuCategorySelectionPage(sender, args);
        }

        /// <summary>
        /// If steakosaurus burger is selected as the entree, its added to the orderlist and returns to the menucatagory selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree); 
            }
            MenuCategorySelectionPage(sender, args);
        }

        /// <summary>
        /// If TRex King Buger is selected as the entree, its added to the orderlist and returns to the menucatagory selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
            }
            MenuCategorySelectionPage(sender, args);
        }

        /// <summary>
        /// If Velociwrap is selected as the entree, its added to the orderlist and returns to the menucatagory selection page
        /// </summary>
        /// <param name="sender">sender is the object reference</param>
        /// <param name="args">args is the event data</param>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
            }
            MenuCategorySelectionPage(sender, args);
        }
    }
}
