/* PrehistoricPBJ.cs
 * Modified by: Agustin Rodriguez
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class implements the menu item Peanut butter and jelly sandwich in Dino-Diner
    /// </summary>
    public class PrehistoricPBJ : Entree
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
        }

        /// <summary>
        /// User chooses to not put jelly on the sandwich 
        /// </summary>
        public void HoldJelly()
        {
            this.Jelly = false;
        }

        /// <summary>
        /// overrides the ToString method and returns menu item as a string 
        /// </summary>
        /// <returns></returns>string menu item 
        public override string ToString()
        {
            return $"Prehistoric PB&J";
        }
    }
}
