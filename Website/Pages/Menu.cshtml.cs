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
        public Menu Menu
        {
            get
            {
                return new Menu();
            }
        }

        public List<IMenuItem> EntreePossibilities;
        public List<IMenuItem> ComboPossibilities;
        public List<IMenuItem> SidePossibilities;
        public List<IMenuItem> DrinkPossibilities;

        public void OnGet()
        {
            DrinkPossibilities = Menu.AvailableDrinks;
            EntreePossibilities = Menu.AvailableEntrees;
            SidePossibilities = Menu.AvailableSides;
            ComboPossibilities = Menu.AvailableCombos;
        }

        [BindProperty]
        public List<string> ingredient { get; set; } = new List<string>();

        [BindProperty]
        public string searchBar { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public List<string> category { get; set; } = new List<string>();

        public void CategoryFilter(List<string> c)
        {
            if(!category.Contains("Entree"))
            {
                EntreePossibilities = new List<IMenuItem>();
            }
            if (!category.Contains("Side"))
            {
                SidePossibilities = new List<IMenuItem>();
            }
            if (!category.Contains("Drink"))
            {
                DrinkPossibilities = new List<IMenuItem>();
            }
            if (!category.Contains("Combo"))
            {
                ComboPossibilities = new List<IMenuItem>();
            }
        }

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

        public static List<IMenuItem> IngredientsFilter(List<IMenuItem> items, List<string> ingredients)
        {
            List<IMenuItem> temp = new List<IMenuItem>();
            bool check;
            foreach (IMenuItem item in items)
            {
                check = false;
                for (int i = 0; i < item.Ingredients.Count; i++)
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

        public void OnPost()
        {
            DrinkPossibilities = Menu.AvailableDrinks;
            EntreePossibilities = Menu.AvailableEntrees;
            SidePossibilities = Menu.AvailableSides;
            ComboPossibilities = Menu.AvailableCombos;

            if (category.Count != 0)
            {
                CategoryFilter(category);
            }

            if (searchBar != null)
            {
                DrinkPossibilities = Search(DrinkPossibilities, searchBar);
                EntreePossibilities = Search(EntreePossibilities, searchBar);
                SidePossibilities = Search(SidePossibilities, searchBar);
                ComboPossibilities = Search(ComboPossibilities, searchBar);
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