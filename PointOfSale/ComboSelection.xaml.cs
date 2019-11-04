/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {

        CretaceousCombo combo;

        

        /// <summary>
        /// initialize form
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// if Brontowurst button is clicked it takes us to the customize combo page
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void CustomBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst wurst = new Brontowurst();
                combo = new CretaceousCombo(wurst);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeBrontowurst(combo));
            }   
        }

        /// <summary>
        /// if Dino-Nuggets button is clicked it takes us to the customize combo page
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void CustomNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nuggets = new DinoNuggets();
                combo = new CretaceousCombo(nuggets);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeDinoNuggets(combo));
            }  
        }

        /// <summary>
        /// if Steakosaurus burger button is clicked it takes us to the customize combo page
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void CustomSteakosaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo));
            }                
        }

        /// <summary>
        /// if TRex King Burger button is clicked it takes us to the customize combo page
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void CustomTRexBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger burger = new TRexKingBurger();
                combo = new CretaceousCombo(burger);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeTRexKingBurger(combo));
            }                
        }

        /// <summary>
        /// if PBJ button is clicked it takes us to the customize combo page
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void CustomPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                combo = new CretaceousCombo(pbj);
                order.Add(combo);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(combo));
            }                
        }

        /// <summary>
        /// if pterodactyl wings button is clicked it takes us to the customize combo page
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void CustomWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                combo = new CretaceousCombo(wings);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }                
        }

        /// <summary>
        /// if Velociwrap button is clicked it takes us to the customize combo page
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void CustomWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                combo = new CretaceousCombo(wrap);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeVelociwrap(combo));
            }                
        }










    }
}
