/* WaterTest.cs
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
    /// this class implements all of the tests for water class
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// checks for correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// checks for correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        /// <summary>
        /// checks for correct default ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        /// <summary>
        /// checks to see small is default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        /// <summary>
        /// checks that lemon is false initially
        /// </summary>
        [Fact] 
        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        /// <summary>
        /// checks that price is correct afer changing size of drink to small
        /// </summary>
        [Fact] 
        public void ShouldHaveCorrectPriceAfterChangingSizeToSmall()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// checks that price is correct afer changing size of drink to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterChangingSizeToMedium()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// checks that price is correct afer changing size of drink to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterChangingSizeToLarge()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// checks that calories is correct afer changing size of drink to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingSizeToSmall()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        /// <summary>
        /// checks that calories is correct afer changing size of drink to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingSizeToMedium()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        /// <summary>
        /// checks that calories is correct afer changing size of drink to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingSizeToLarge()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        /// <summary>
        /// calls holdice method to take is out of drin
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        /// <summary>
        /// adds lemons the the drink 
        /// </summary>
        [Fact] 
        public void ShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        /// <summary>
        /// checks for correct ingredients in the drink
        /// </summary>
        [Fact] 
        public void ShouldHaveCorrectIngredients()
        {
            Water w = new Water();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Single(w.Ingredients);
        }

        /// <summary>
        /// checks that drink has correct ingredients when lemon property is true
        /// </summary>
        [Fact] 
        public void ShouldHaveCorrectIngredientsWithLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Contains<string>("Water", w.Ingredients);
            Assert.Contains<string>("Lemon", w.Ingredients);
            Assert.Equal<int>(2, w.Ingredients.Count);
        }
    }
}
