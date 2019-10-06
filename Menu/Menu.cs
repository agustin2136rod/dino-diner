/* Menu.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class contains properties for menu items such as entrees, drinks, and sides.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// property that gets each menu item at dino diner
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> list = new List<IMenuItem>();

                Fryceritops fry = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();
                list.Add(fry);
                list.Add(mac);
                list.Add(sticks);
                list.Add(tots);

                JurrasicJava jj = new JurrasicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water agua = new Water();
                list.Add(jj);
                list.Add(soda);
                list.Add(tea);
                list.Add(agua);

                Brontowurst wurst = new Brontowurst();
                DinoNuggets nuggs = new DinoNuggets();
                PrehistoricPBJ sandwich = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burger = new SteakosaurusBurger();
                TRexKingBurger king = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();
                list.Add(wurst);
                list.Add(nuggs);
                list.Add(sandwich);
                list.Add(wings);
                list.Add(burger);
                list.Add(king);
                list.Add(wrap);
                return list;
            }
        }

        /// <summary>
        /// property that gets the available entrees at Dino DIner
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> list = new List<Entree>();
                Brontowurst wurst = new Brontowurst();
                DinoNuggets nuggs = new DinoNuggets();
                PrehistoricPBJ sandwich = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burger = new SteakosaurusBurger();
                TRexKingBurger king = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();
                list.Add(wurst);
                list.Add(nuggs);
                list.Add(sandwich);
                list.Add(wings);
                list.Add(burger);
                list.Add(king);
                list.Add(wrap);
                return list;

            }
        }

        /// <summary>
        /// Property that gets the available sides at dino diner
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> list = new List<Side>();
                Fryceritops fry = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();
                list.Add(fry);
                list.Add(mac);
                list.Add(sticks);
                list.Add(tots);
                return list;
            }
        }

        /// <summary>
        /// property that gets the available drinks at dino diner
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> list = new List<Drink>();
                JurrasicJava jj = new JurrasicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water agua = new Water();
                list.Add(jj);
                list.Add(soda);
                list.Add(tea);
                list.Add(agua);
                return list;
            }
        }

        /// <summary>
        /// property that gets all available combos at dino diner and returns them in a list
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> list = new List<CretaceousCombo>();
                Brontowurst wurst = new Brontowurst();
                DinoNuggets nuggs = new DinoNuggets();
                PrehistoricPBJ sandwich = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burger = new SteakosaurusBurger();
                TRexKingBurger king = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();
                CretaceousCombo combo1 = new CretaceousCombo(wurst);
                CretaceousCombo combo2 = new CretaceousCombo(nuggs);
                CretaceousCombo combo3 = new CretaceousCombo(sandwich);
                CretaceousCombo combo4 = new CretaceousCombo(wings);
                CretaceousCombo combo5 = new CretaceousCombo(burger);
                CretaceousCombo combo6 = new CretaceousCombo(king);
                CretaceousCombo combo7 = new CretaceousCombo(wrap);
                list.Add(combo1);
                list.Add(combo2);
                list.Add(combo3);
                list.Add(combo4);
                list.Add(combo5);
                list.Add(combo6);
                list.Add(combo7);
                return list;
            }
        }

        /// <summary>
        /// overrides the ToString method to show every menu item seperated by new lines
        /// </summary>
        /// <returns></returns> returns every menu item as a string
        public override string ToString()
        {
            return $"Jurassic Java \n Cola Sodasaurus \n Orange Sodasaurus \n Vanilla Sodasaurus \n Chocolate Sodasaurus \n RootBeet Sodasaurus \n Cherry Sodasaurus \n Lime Sodasaurus \n Decaf Jurassic Java \n Sweet Tyrannotea \n Tyrannotea Water \n Brontowurst \n Dino-Nuggets \n Prehistoric PB&J \n Pterodactyl Wings \n Steakosaurus Burger \n T-Rex King Burger \n Veloci-Wrap \n Friceritops \n Meteor Mac and Cheese \n Mezzorella Sticks \n Triceritots";
        }
    }
}
