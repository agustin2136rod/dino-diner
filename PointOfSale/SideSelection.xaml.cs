/* SideSelection.xaml.cs
 * Author: Agustin Rodriguez
 */
using DinoDiner.Menu;
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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {

        /// <summary>
        /// side object that is used throughout this class
        /// </summary>
        public Side side { get; set; }

        CretaceousCombo combo;

        /// <summary>
        /// whenever returning to the side selection page, this constructor will bring in a side object that is initialized to the side object in this class
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            side = combo.Side;
        }

        /// <summary>
        /// constructor for this class
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// if the user selects fryceritops as a side, it is added to the order list
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="args">contains the data</param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (combo != null)
                {
                    side = new Fryceritops();
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    side = new Fryceritops();
                    order.Add(side);
                }                
            }
        }

        /// <summary>
        /// if the user selects triceritots as a side, it is added to the order list
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="args">contains the data</param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    side = new Triceritots();
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    side = new Triceritots();
                    order.Add(side);
                }                
            }
        }

        /// <summary>
        /// if the user selects Meteor Mac and Cheese as a side, it is added to the order list
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="args">contains the data</param>
        private void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    side = new MeteorMacAndCheese();
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    side = new MeteorMacAndCheese();
                    order.Add(side);
                }
            }
        }
                

        /// <summary>
        /// if the user selects mezzorella sticks as a side, it is added to the order list
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="args">contains the data</param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    side = new MezzorellaSticks();
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    side = new MezzorellaSticks();
                    order.Add(side);
                }                
            }
        }

        /// <summary>
        /// Whenever a side is selected, the user has the option to change the size from small to medium/large
        /// and it will update the description of the menu item
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="args">contains the data</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                if (combo == null)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                    ReturnToMenuCatagorySelection(sender, args);
                }                
            }
        }

        /// <summary>
        /// this method will return to the menu catagory selection page 
        /// </summary>
        /// <param name="sender">control object</param>
        /// <param name="args">contains the data</param>
        void ReturnToMenuCatagorySelection(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
