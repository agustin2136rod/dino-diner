/* CretaceousCombo.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class implements the combo meal at Dino-Diner
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// implement interface for INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// an event handler to notify if a field/property is changed
        /// </summary>
        /// <param name="propertyName">name of the property changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// object entree for the menu item used in the combo
        /// </summary>
        private Entree entree;

        /// <summary>
        /// New entree instance
        /// </summary>
        public Entree Entree
        {
            get { return entree; }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                    {
                        NotifyOfPropertyChanged(args.PropertyName);
                    };
            }
        }

        /// <summary>
        /// Side instance for this class
        /// </summary>
        private Side side;

        /// <summary>
        /// gets the side that is requested and sets it equal to the right size and returns it
        /// </summary>
        public Side Side { get
            {
                return side;
            }
            set
            {
                side = value;
                side.Size = this.size;
            }
        }

        /// <summary>
        /// drink object for the combo that is initialized to sodasaurus
        /// </summary>
        private Drink drink = new Sodasaurus();

        /// <summary>
        /// field for setting an instance of the drink class
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        

        /// <summary>
        /// Property that gets the price of the combo by adding all prices of each menu item together and subtracting 25 cents
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Adds the calories of each menu item in the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// sets size initially to small
        /// </summary>
        private Size size = Size.Small;


      

        /// <summary>
        /// Gets the size of each menu item and returns it
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// property that implements a List of all the ingredietns for each item 
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// constructor that creates the combo from the menu item selected. Fries and soda are the default side and drink
        /// </summary>
        /// <param name="entree"></param>entree that will come with the combo
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// overrides ToString method for each menu item 
        /// </summary>
        /// <returns></returns> each menu item as a string
        public override string ToString()
        {
            return Entree + " Combo";
        }

        /// <summary>
        /// gets special instructions for food prep
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
    }
}
