/* Menu.cshtml.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// initalize
        /// </summary>
        public Menu Menu
        {
            get
            {
                return new Menu();
            }
        }

        /// <summary>
        /// entree property 
        /// </summary>
        public List<IMenuItem> EntreePossibilities;

        /// <summary>
        /// Combos property 
        /// </summary>
        public List<IMenuItem> ComboPossibilities;

        /// <summary>
        /// Sides property 
        /// </summary>
        public List<IMenuItem> SidePossibilities;

        /// <summary>
        /// Drinks property 
        /// </summary>
        public List<IMenuItem> DrinkPossibilities;

        /// <summary>
        /// entire menu shows up
        /// </summary>
        public void OnGet()
        {
            
            DrinkPossibilities = Menu.AvailableDrinks;
            EntreePossibilities = Menu.AvailableEntrees;
            SidePossibilities = Menu.AvailableSides;
            ComboPossibilities = Menu.AvailableCombos;
        }

        /// <summary>
        /// property for ingredients to tie with the form
        /// </summary>
        [BindProperty]
        public List<string> ingredient { get; set; } = new List<string>();

        /// <summary>
        /// property for search to tie with the form
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// property for max price to tie with the form
        /// </summary>
        [BindProperty]
        public float? maxPrice { get; set; }

        /// <summary>
        /// property for different categories to tie with the form
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// property for min price to tie with the form
        /// </summary>
        [BindProperty]
        public float? minPrice { get; set; }

        /// <summary>
        /// filters the items displayed on the web page to be whatever check boxes are clicked when filtering
        /// </summary>
        /// <param name="menuCategory">catagories that are wanting to be displayed</param>
        public void CategoryFilter(List<string> menuCategory)
        {
            if(!menuCategory.Contains("Entree"))
            {
                EntreePossibilities = new List<IMenuItem>();
            }
            if (!menuCategory.Contains("Side"))
            {
                SidePossibilities = new List<IMenuItem>();
            }
            if (!menuCategory.Contains("Drink"))
            {
                DrinkPossibilities = new List<IMenuItem>();
            }
            if (!menuCategory.Contains("Combo"))
            {
                ComboPossibilities = new List<IMenuItem>();
            }
        }

        /// <summary>
        /// Search bar on the form that searches for items in Dino Diner
        /// </summary>
        /// <param name="items">list of possible items it could be</param>
        /// <param name="search">specific string for what is wanted</param>
        /// <returns>returns a list of items that were asked for</returns>
        public List<IMenuItem> Search(List<IMenuItem> items, string search)
        {
            List<IMenuItem> temp = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (item.ToString() != null && item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        /// <summary>
        /// Filters the ingredients of different items on the form to be displayed
        /// </summary>
        /// <param name="items">items it could be</param>
        /// <param name="ingredients">list of specific ingredients selected</param>
        /// <returns>returns a list of ingredients selected</returns>
        public static List<IMenuItem> IngredientsFilter(List<IMenuItem> items, List<string> ingredients)
        {
            List<IMenuItem> temp = new List<IMenuItem>();
            bool check;
            foreach (IMenuItem item in items)
            {
                check = false;
                for (int i = 0; i < ingredients.Count; i++)
                {

                    if (ingredients.Contains(item.Ingredients[i]))
                    {
                        check = true;
                    }
                }
                if (check == false)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        /// <summary>
        /// filters the items shown by setting a minimum price
        /// </summary>
        /// <param name="items">items that it could be</param>
        /// <param name="price">min price we want</param>
        /// <returns>returns a list of items that are within the threshold</returns>
        public static List<IMenuItem> FilterMinPrice(List<IMenuItem> items, float price)
        {
            List<IMenuItem> temp = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (item.Price >= price)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        /// <summary>
        /// filters the items shown by setting a max price
        /// </summary>
        /// <param name="items">items that it could be</param>
        /// <param name="price">max price we want</param>
        /// <returns>returns a list of items that are within the threshold</returns>
        public static List<IMenuItem> FilterMaxPrice(List<IMenuItem> items, float price)
        {
            List<IMenuItem> temp = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (item.Price <= price)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        /// <summary>
        /// whenever we are interacting with the form
        /// </summary>
        public void OnPost()
        {
            DrinkPossibilities = Menu.AvailableDrinks;
            EntreePossibilities = Menu.AvailableEntrees;
            SidePossibilities = Menu.AvailableSides;
            ComboPossibilities = Menu.AvailableCombos;

            if (menuCategory.Count != 0)
            {
                CategoryFilter(menuCategory);
            }

            if (search != null)
            {
                DrinkPossibilities = Search(DrinkPossibilities, search);
                EntreePossibilities = Search(EntreePossibilities, search);
                SidePossibilities = Search(SidePossibilities, search);
                ComboPossibilities = Search(ComboPossibilities, search);
            }

            if (ingredient.Count != 0)
            {
                DrinkPossibilities = IngredientsFilter(DrinkPossibilities, ingredient);
                EntreePossibilities = IngredientsFilter(EntreePossibilities, ingredient);
                SidePossibilities = IngredientsFilter(SidePossibilities, ingredient);
                ComboPossibilities = IngredientsFilter(ComboPossibilities, ingredient);
            }

            if (minPrice != null)
            {
                DrinkPossibilities = FilterMinPrice(DrinkPossibilities, (float)minPrice);
                EntreePossibilities = FilterMinPrice(EntreePossibilities, (float)minPrice);
                SidePossibilities = FilterMinPrice(SidePossibilities, (float)minPrice);
                ComboPossibilities = FilterMinPrice(ComboPossibilities, (float)minPrice);
            }

            if (maxPrice != null)
            {
                DrinkPossibilities = FilterMaxPrice(DrinkPossibilities, (float)maxPrice);
                EntreePossibilities = FilterMaxPrice(EntreePossibilities, (float)maxPrice);
                SidePossibilities = FilterMaxPrice(SidePossibilities, (float)maxPrice);
                ComboPossibilities = FilterMaxPrice(ComboPossibilities, (float)maxPrice);
            }
        }
        

    }
}