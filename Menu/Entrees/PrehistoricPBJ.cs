/* PrehistoricPBJ.cs
 * Modified by: Agustin Rodriguez
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class implements the menu item Peanut butter and jelly sandwich in Dino-Diner
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// user has option to add peanut butter on sandwich 
        /// </summary>
        private bool PeanutButter = true;

        /// <summary>
        /// user has option to add jelly on sandwich 
        /// </summary>
        private bool Jelly = true;

        /// <summary>
        /// an event handler for PropertyChanged events for the fields peanut butter and jelly
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// an event handler to notify if a field/property is changed
        /// </summary>
        /// <param name="propertyName">name of the property changed</param>
        protected void NotifyofPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        /// <summary>
        /// These are a list of ingredients the user chooses to have on their sandwich with the exception of bread
        /// They can add peanut butter and jelly
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (PeanutButter) ingredients.Add("Peanut Butter");
                if (Jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// constructor for the PBJ class that sets the price and calories of the menu item
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// User chooses to not put peanut butter on the sandwich 
        /// </summary>
        public void HoldPeanutButter()
        {
            this.PeanutButter = false;
            NotifyofPropertyChanged("Ingredients");
            NotifyofPropertyChanged("Special");
        }

        /// <summary>
        /// User chooses to not put jelly on the sandwich 
        /// </summary>
        public void HoldJelly()
        {
            this.Jelly = false;
            NotifyofPropertyChanged("Ingredients");
            NotifyofPropertyChanged("Special");
        }

        /// <summary>
        /// overrides the ToString method and returns menu item as a string 
        /// </summary>
        /// <returns></returns>string menu item 
        public override string ToString()
        {
            return $"Prehistoric PB&J";
        }

        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }


        /// <summary>
        /// gets special instructions for food prep
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!PeanutButter) special.Add("Hold Peanut Butter");
                if (!Jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
