/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// drink object used in this class
        /// </summary>
        public Drink drink { get; set; }

        /// <summary>
        /// Water object used in this class
        /// </summary>
        Water water = new Water();

        /// <summary>
        /// soda object used in this class
        /// </summary>
        Sodasaurus soda = new Sodasaurus();

        /// <summary>
        /// tea object used in this class
        /// </summary>
        Tyrannotea tea = new Tyrannotea();

        /// <summary>
        /// jurassic java object used in this class
        /// </summary>
        JurrasicJava jj = new JurrasicJava();

        /// <summary>
        /// button for lemon property
        /// </summary>
        Button lemon;

        /// <summary>
        /// button for sweet property
        /// </summary>
        Button sweet;

        /// <summary>
        /// radiobutton for decaf property
        /// </summary>
        RadioButton decaf;

        /// <summary>
        /// order object for the orderlist
        /// </summary>
        Order order;

        /// <summary>
        /// initializes the xaml DrinkSelection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// whenever the sodasaurus flavor is selected, this constructor will set the sodasaurus and the flavor to the drink
        /// </summary>
        /// <param name="drink">drink object used in this class</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }


        /// <summary>
        /// event handler for water that deals with adding lemon
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void SelectWater(object sender, RoutedEventArgs args)
        {
            order = DataContext as Order;
            drink = new Water();
            water = (Water)drink;
            lemon = new Button();
            SpecialButtons.Children.Clear();
            lemon.Height = 100;
            lemon.Width = 100;
            lemon.Content = "AddLemon";
            SpecialButtons.Children.Add(lemon);
            
            lemon.Click += new RoutedEventHandler(OnAddLemonWater);
            order.Add(water);
            
        }

        /// <summary>
        /// event handler that deals with when the lemon button is clicked, the special for water changes to add lemon
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void OnAddLemonWater(object sender, RoutedEventArgs args)
        {
            water.AddLemon();
        }

        /// <summary>
        /// event handler that deals with when the lemon button is clicked, the special for tea changes to add lemon
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void OnAddLemonTea(object sender, RoutedEventArgs args)
        {
            tea.AddLemon();
        }

        /// <summary>
        /// event handler that deals with when the size of a drink changes, the description is updated
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                
            }
        }

        /// <summary>
        /// event handler for the tyrannotea drink item that asks if we want to make it sweet and if we want to add lemon
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            order = DataContext as Order;
            drink = new Tyrannotea();
            tea = (Tyrannotea)drink;
            SpecialButtons.Children.Clear();
            sweet = new Button();
            sweet.Height = 100;
            sweet.Width = 100;
            sweet.Content = "Sweet";
            SpecialButtons.Children.Add(sweet);
            sweet.Click += new RoutedEventHandler(OnAddSweet);

            lemon = new Button();
            lemon.Height = 100;
            lemon.Width = 100;
            lemon.Content = "AddLemon";
            SpecialButtons.Children.Add(lemon);
            lemon.Click += new RoutedEventHandler(OnAddLemonTea);

            order.Add(tea); 
        }

        /// <summary>
        /// event handler that deals with when the sweet button is clicked, the description is updated in the order list
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void OnAddSweet(object sender, RoutedEventArgs args)
        {
            tea.Sweet = true;
        }

        /// <summary>
        /// event handler for the JurassicJava that deals with making the coffee decaf
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void SelectJava(object sender, RoutedEventArgs args)
        {
            order = DataContext as Order;
            drink = new JurrasicJava();
            jj = (JurrasicJava)drink;
            SpecialButtons.Children.Clear();
            decaf = new RadioButton();
            decaf.Height = 100;
            decaf.Width = 100;
            decaf.Content = "Decaf";
            SpecialButtons.Children.Add(decaf);
            decaf.Click += new RoutedEventHandler(OnAddDecaf);

            order.Add(jj);                
                        
        }

        /// <summary>
        /// event handler that deals with when the decafe radiobutton is clicked, the description is updated for the coffee to be decaf
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void OnAddDecaf(object sender, RoutedEventArgs args)
        {
            jj.DecafCoffee();
        }

        /// <summary>
        /// when the sodasaurus button is clicked, there is a new button that pops up displaying flavor
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            order = DataContext as Order;
            drink = new Sodasaurus();
            soda = (Sodasaurus)drink;
            SpecialButtons.Children.Clear();
            Button flavor = new Button();
            flavor.Height = 100;
            flavor.Width = 100;
            flavor.Content = "Flavor";
            SpecialButtons.Children.Add(flavor);
            flavor.Click += new RoutedEventHandler(SelectFlavor);
                
            order.Add(soda);
        }

        /// <summary>
        /// when the button "flavor" is clicked this method will take us to the flavor selection xaml
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection(soda));
        }

        /// <summary>
        /// this method will take the user back to the Menu Catagory Selection Page
        /// </summary>
        /// <param name="sender">reference to the control</param>
        /// <param name="args">contains the event data</param>
        void ReturnToMenuCatagorySelection(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        

        /// <summary>
        /// whenever this button is clicked, the ReturnToMenuCatagorySelection method is called 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            ReturnToMenuCatagorySelection(sender, args);
        }
        


    }    
}
