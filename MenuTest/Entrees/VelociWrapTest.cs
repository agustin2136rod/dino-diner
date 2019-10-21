using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        /// <summary>
        /// has correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        /// <summary>
        /// has correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        /// <summary>
        /// has correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        /// <summary>
        /// removes dressing from the ingredients
        /// </summary>
        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        /// <summary>
        /// removes lettuce from the ingredients
        /// </summary>
        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        /// <summary>
        /// removes cheese from the ingredients
        /// </summary>
        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.Equal("Veloci-Wrap", wrap.Description);

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
        public void HoldDressingAndLettuceAndCheeseShouldAddToSpecial()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldDressing();
            wrap.HoldLettuce();
            wrap.HoldCheese();
            Assert.Collection<string>(wrap.Special, item =>
            {
                Assert.Equal("Hold Cheese", item);
            }, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            }, item =>
            {
                Assert.Equal("Hold Dressing", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldDressingShouldAddToSpecial()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldDressing();
            Assert.Collection<string>(wrap.Special, item =>
            {
                Assert.Equal("Hold Dressing", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldLettuce();
            Assert.Collection<string>(wrap.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldCheeseShouldAddToSpecial()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldCheese();
            Assert.Collection<string>(wrap.Special, item =>
            {
                Assert.Equal("Hold Cheese", item);
            }
                );
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldDressingShouldNotifyIngredintsChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Ingredients", () =>
            {
                wrap.HoldDressing();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldDressingShouldNotifySpecialChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldDressing();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldLettuceShouldNotifyIngredintsChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Ingredients", () =>
            {
                wrap.HoldLettuce();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldLettuceShouldNotifySpecialChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldLettuce();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldCheeseShouldNotifyIngredintsChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Ingredients", () =>
            {
                wrap.HoldCheese();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldCheeseShouldNotifySpecialChange()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, "Special", () =>
            {
                wrap.HoldCheese();
            });
        }
    }
}
