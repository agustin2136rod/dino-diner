﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MenuItemNamesTest
    {
        #region Entrees
        /// <summary>
        /// checks tostring
        /// </summary>
        [Fact]
        public void BrontowurstToStringShouldGiveName()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Fact]
        public void DinoNuggetToStringShouldGiveName()
        {

            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Fact]
        public void PrehistoricPBJToStringShouldGiveName()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Fact]
        public void PterodactylWingsToStringShouldGiveName()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Fact]
        public void SteakosaurusBurgerToStringShouldGiveName()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Fact]
        public void TRexKingBurgerToStringShouldGiveName()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Fact]
        public void VelociWrapToStringShouldGiveName()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.ToString());
        }

        #endregion

        #region Sides

        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsToStringShouldGiveNameForSize(Size size)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseToStringShouldGiveNameForSize(Size size)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mmc.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksToStringShouldGiveNameForSize(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Equal($"{size} Mezzorella Sticks", ms.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ToStringShouldGiveNameForSize(Size size)
        {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Equal($"{size} Triceritots", tt.ToString());
        }

        #endregion

        #region Drinks
        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaToStringShouldGiveNameForSizeAndDecaf(Size size, bool decaf)
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.ToString());
            else Assert.Equal($"{size} Jurassic Java", java.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodaSaurusToStringShouldGiveNameForSizeAndFlavor(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaToStringShouldGiveNameForSizeAndSweetness(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.ToString());
            else Assert.Equal($"{size} Tyrannotea", tea.ToString());
        }

        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterToStringShouldGiveNameForSize(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.ToString());
        }

        #endregion

        #region Combos
        /// <summary>
        /// checks tostring
        /// </summary>
        [Theory]
        [InlineData(typeof(Brontowurst), "Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), "Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), "Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), "Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), "Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), "T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), "Veloci-Wrap Combo")]
        public void ToStringShouldGiveName(Type type, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            Assert.Equal(name, combo.ToString());
        }

        #endregion
    }
}
