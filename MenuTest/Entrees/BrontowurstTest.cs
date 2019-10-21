using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        /// <summary>
        /// correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        /// <summary>
        /// correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        /// <summary>
        /// correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        /// <summary>
        /// removes bun from ingredients
        /// </summary>
        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        /// <summary>
        /// removes peppers from ingredients
        /// </summary>
        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        /// <summary>
        /// removes onions from ingredients
        /// </summary>
        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.Equal("Brontowurst", wurst.Description);

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
        public void HoldOnionShouldAddToSpecial()
        {
            Brontowurst wurst = new Brontowurst();
            wurst.HoldOnion();
            Assert.Collection<string>(wurst.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            Brontowurst wurst = new Brontowurst();
            wurst.HoldBun();
            Assert.Collection<string>(wurst.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldPeppersShouldAddToSpecial()
        {
            Brontowurst wurst = new Brontowurst();
            wurst.HoldPeppers();
            Assert.Collection<string>(wurst.Special, item =>
            {
                Assert.Equal("Hold Peppers", item);
            }
                );
        }

        /// <summary>
        /// tests to see if there are multiple special instructions, to add to the special[]
        /// </summary>
        [Fact]
        public void HoldOnionAndPeppersAndBunShouldAddToSpecial()
        {
            Brontowurst wurst = new Brontowurst();
            wurst.HoldBun();
            wurst.HoldOnion();
            wurst.HoldPeppers();
            Assert.Collection<string>(wurst.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            }, item =>
            {
                Assert.Equal("Hold Peppers", item);
            }, item =>
            {
                Assert.Equal("Hold Bun", item);
            }
                );
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.PropertyChanged(wurst, "Special", () =>
            {
                wurst.HoldBun();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldingBunShouldNotifyIngredintsChange()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.PropertyChanged(wurst, "Ingredients", () =>
            {
                wurst.HoldBun();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldingPeppersShouldNotifySpecialChange()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.PropertyChanged(wurst, "Special", () =>
            {
                wurst.HoldPeppers();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldingPeppersShouldNotifyIngredintsChange()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.PropertyChanged(wurst, "Ingredients", () =>
            {
                wurst.HoldPeppers();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldingOnionShouldNotifySpecialChange()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.PropertyChanged(wurst, "Special", () =>
            {
                wurst.HoldOnion();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldingOnionShouldNotifyIngredintsChange()
        {
            Brontowurst wurst = new Brontowurst();
            Assert.PropertyChanged(wurst, "Ingredients", () =>
            {
                wurst.HoldOnion();
            });
        }
    }

}
