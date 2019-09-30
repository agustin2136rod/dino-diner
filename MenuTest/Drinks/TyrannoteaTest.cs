/* TyrannoteaTest.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// this class implements the tests for tyrannotea class
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// checks for right default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<double>(0.99, tt.Price);
        }

        /// <summary>
        /// checks for the right default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<uint>(8, tt.Calories);
        }

        /// <summary>
        /// should have ice at default
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.True(tt.Ice);
        }

        /// <summary>
        /// chekcs for correct default size which is small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        /// <summary>
        /// checks to see if drink has lemon ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.DoesNotContain("Lemon", tt.Ingredients);
        }

        /// <summary>
        /// checks if its sweet or not
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.DoesNotContain("Cane Sugar", tt.Ingredients);
        }

        /// <summary>
        /// checks for correct calories and price when changing size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Small;
            Assert.Equal<double>(0.99, tt.Price);
            Assert.Equal<uint>(8, tt.Calories);
        }

        /// <summary>
        /// checks for correct calories and price when changing size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<double>(1.49, tt.Price);
            Assert.Equal<uint>(16, tt.Calories);
        }

        /// <summary>
        /// checks for correct calories and price when changing size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<double>(1.99, tt.Price);
            Assert.Equal<uint>(32, tt.Calories);
        }

        /// <summary>
        /// calls holdice method
        /// </summary>
        [Fact]
        public void ShouldHaveNoIce()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.HoldIce();
            Assert.False(tt.Ice);
        }

        /// <summary>
        /// calls addlemon method
        /// </summary>
        [Fact] 
        public void ShouldHaveLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            Assert.True(tt.Lemon);
        }

        /// <summary>
        /// checks to see calories are correct when adding sweetener to small
        /// </summary>
        [Fact]
        public void ShouldHaveSweetSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            Assert.Equal<uint>(16, tt.Calories);
        }

        /// <summary>
        /// checks to see calories are correct when adding sweetener to medium
        /// </summary>
        [Fact]
        public void ShouldHaveSweetMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            tt.Size = Size.Medium;
            Assert.Equal<uint>(32, tt.Calories);
        }

        /// <summary>
        /// checks to see calories are correct when adding sweetener to large
        /// </summary>
        [Fact]
        public void ShouldHaveSweetLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            tt.Size = Size.Large;
            Assert.Equal<uint>(64, tt.Calories);
        }

        /// <summary>
        /// checks to see calories are correct when taking sweetener away from size small
        /// </summary>
        [Fact]
        public void ShouldNotHaveSweetSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            tt.Sweet = false;
            Assert.Equal<uint>(8, tt.Calories);
        }

        /// <summary>
        /// checks to see calories are correct when taking sweetener away from size medium
        /// </summary>
        [Fact]
        public void ShouldNotHaveSweetMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            tt.Sweet = false;
            tt.Size = Size.Medium;
            Assert.Equal<uint>(16, tt.Calories);
        }

        /// <summary>
        /// checks to see calories are correct when taking sweetener away from size medium
        /// </summary>
        [Fact]
        public void ShouldNotHaveSweetLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            tt.Sweet = false;
            tt.Size = Size.Large;
            Assert.Equal<uint>(32, tt.Calories);
        }

        /// <summary>
        /// checks to see ingredients are correct in the drink
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Contains<string>("Water", tt.Ingredients);
            Assert.Contains<string>("Tea", tt.Ingredients);
            Assert.Equal<int>(2, tt.Ingredients.Count);
        }

        /// <summary>
        /// checks ingredients when lemon is added
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsWithLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            Assert.Contains<string>("Water", tt.Ingredients);
            Assert.Contains<string>("Tea", tt.Ingredients);
            Assert.Contains<string>("Lemon", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
        }

        /// <summary>
        /// checks ingredients when adding sweetener
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsWithSweet()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Sweet = true;
            Assert.Contains<string>("Water", tt.Ingredients);
            Assert.Contains<string>("Tea", tt.Ingredients);
            Assert.Contains<string>("Cane Sugar", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
        }
           
    }
}
