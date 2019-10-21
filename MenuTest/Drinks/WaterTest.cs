/* WaterTest.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;
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

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeCorrect(Size size)
        {
            Water agua = new Water();
            agua.Size = size;
            Assert.Equal($"{size} Water", agua.Description);

        }

        /// <summary>
        /// checks to make sure that the special string array is empty by default
        /// </summary>
        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);
        }

        /// <summary>
        /// tests to see if there are multiple special instructions, to add to the special[]
        /// </summary>
        [Fact]
        public void HoldIceAndAddLemonShouldAddToSpecial()
        {
            Water agua = new Water();
            agua.HoldIce();
            agua.AddLemon();
            Assert.Collection<string>(agua.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            }, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Water agua = new Water();
            agua.HoldIce();
            Assert.Collection<string>(agua.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water agua = new Water();
            agua.AddLemon();
            Assert.Collection<string>(agua.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            }
                );
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {
            Water agua = new Water();
            Assert.PropertyChanged(agua, "Special", () =>
            {
                agua.AddLemon();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void AddLemonShouldNotifyIngredientsChange()
        {
            Water agua = new Water();
            Assert.PropertyChanged(agua, "Ingredients", () =>
            {
                agua.AddLemon();
            });
        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangeSizeShouldNotifyPrice(Size size)
        {
            Water agua = new Water();
            agua.Size = size;
            Assert.PropertyChanged(agua, "Price", () =>
            {
                agua.Size = size;
            });

        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangeSizeShouldNotifyCalories(Size size)
        {
            Water agua = new Water();
            agua.Size = size;
            Assert.PropertyChanged(agua, "Price", () =>
            {
                agua.Size = size;
            });

        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangeSizeShouldNotifyDescription(Size size)
        {
            Water agua = new Water();
            agua.Size = size;
            Assert.PropertyChanged(agua, "Description", () =>
            {
                agua.Size = size;
            });

        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Water agua = new Water();
            Assert.PropertyChanged(agua, "Special", () =>
            {
                agua.HoldIce();
            });
        }
    }
}
