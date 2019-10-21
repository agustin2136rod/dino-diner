/* JurrasicJavaTest.cs
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
    /// this class implements all of the tests for the drink jurrasicjava 
    /// </summary>
    public class JurrasicJavaTest
    {
        /// <summary>
        /// checks for correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<double>(0.59, jj.Price);
        }

        /// <summary>
        /// checks for correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        /// <summary>
        /// checks to see if correct default ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.Ice);
        }

        /// <summary>
        /// checks for correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        /// <summary>
        /// checks for default property setting for cream
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.RoomForCream);
        }

        /// <summary>
        /// checks for correct price when changing size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterChangingToSmall()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Small;
            Assert.Equal<double>(.59, jj.Price);
        }

        /// <summary>
        /// checks for correct price when changing size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterChangingToMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(.99, jj.Price);
        }

        /// <summary>
        /// checks for correct price when changing size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterChangingToLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }

        /// <summary>
        /// checks for correct calories when changing size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingToSmall()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }

        /// <summary>
        /// checks for correct calories when changing size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingToMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        /// <summary>
        /// checks for correct calories when changing size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingToLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }

        /// <summary>
        /// checks to see if add ice method works
        /// </summary>
        [Fact]
        public void ShouldAddIce()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }

        /// <summary>
        /// checks the method for leave space for cream in coffee
        /// </summary>
        [Fact]
        public void ShouldLeaveSpaceForCream()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }

        /// <summary>
        /// checks for correct ingredients in drink
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Contains<string>("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
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
            JurrasicJava jj = new JurrasicJava();
            jj.Size = size;
            Assert.Equal($"{size} Jurassic Java", jj.Description);

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
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.AddIce();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void LeaveRoomForCreamShouldAddToSpecial()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            }
                );
        }

        /// <summary>
        /// tests to see if there are multiple special instructions, to add to the special[]
        /// </summary>
        [Fact]
        public void AddIceAndLeaveRoomForCreamShouldAddToSpecial()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.AddIce();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            }, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void LeaveRoomForCreamShouldNotifySpecialChange()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.LeaveRoomForCream();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void AddIceShouldNotifySpecialChange()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.AddIce();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void DecafShouldNotifyDescription()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.DecafCoffee();
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
            JurrasicJava jj = new JurrasicJava();
            jj.Size = size;
            Assert.PropertyChanged(jj, "Price", () =>
            {
                jj.Size = size;
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
            JurrasicJava jj = new JurrasicJava();
            jj.Size = size;
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.Size = size;
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
            JurrasicJava jj = new JurrasicJava();
            jj.Size = size;
            Assert.PropertyChanged(jj, "Calories", () =>
            {
                jj.Size = size;
            });

        }
    }
}
