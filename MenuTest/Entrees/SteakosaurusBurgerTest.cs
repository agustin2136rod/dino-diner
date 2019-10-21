using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        /// <summary>
        /// has correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        /// <summary>
        /// has correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        /// <summary>
        /// has correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        /// <summary>
        /// removes bun from the ingredients
        /// </summary>
        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        /// <summary>
        /// removes pickle from ingredients
        /// </summary>
        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        /// <summary>
        /// removes kethup from ingredients
        /// </summary>
        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        /// <summary>
        /// removes mustard from ingredients
        /// </summary>
        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", burger.Description);

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
        public void HoldKetchupAndPickleAndMustardShouldAddToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldPickle();
            burger.HoldKetchup();
            burger.HoldMustard();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            }, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            }, item =>
            {
                Assert.Equal("Hold Mustard", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldPickle();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldKetchup();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldMustard();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldBun();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            }
                );
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldBunShouldNotifyIngredintsChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Ingredients", () =>
            {
                burger.HoldBun();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldBunShouldNotifySpecialChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldBun();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldPickleShouldNotifyIngredintsChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Ingredients", () =>
            {
                burger.HoldPickle();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldPickleShouldNotifySpecialChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldPickle();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldKetchupShouldNotifyIngredintsChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Ingredients", () =>
            {
                burger.HoldKetchup();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldKetchupShouldNotifySpecialChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldKetchup();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldMustardShouldNotifyIngredintsChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Ingredients", () =>
            {
                burger.HoldMustard();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldMustardShouldNotifySpecialChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldMustard();
            });
        }
    }

}
