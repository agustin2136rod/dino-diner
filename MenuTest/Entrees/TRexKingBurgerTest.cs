using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        /// <summary>
        /// has correct price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        /// <summary>
        /// has correct calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        /// <summary>
        /// has correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        /// <summary>
        /// removes bun from ingredients
        /// </summary>
        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        /// <summary>
        /// removes lettuce from the ingredients
        /// </summary>
        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        /// <summary>
        /// removes tomato from the ingredients
        /// </summary>
        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        /// <summary>
        /// removes onion from the ingredients
        /// </summary>
        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        /// <summary>
        /// removes pickles from the ingredients
        /// </summary>
        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        /// <summary>
        /// removes ketchup from the ingredients
        /// </summary>
        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        /// <summary>
        /// removes mustard from the ingredients
        /// </summary>
        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        /// <summary>
        /// removes mayo from the ingredients
        /// </summary>
        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", burger.Description);

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
        public void HoldPickleShouldAddToSpecial()
        {
            TRexKingBurger burger = new TRexKingBurger();
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
        public void HoldBunShouldAddToSpecial()
        {
            TRexKingBurger burger = new TRexKingBurger();
            burger.HoldBun();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            TRexKingBurger burger = new TRexKingBurger();
            burger.HoldLettuce();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Lettuce", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldTomatoShouldAddToSpecial()
        {
            TRexKingBurger burger = new TRexKingBurger();
            burger.HoldTomato();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Tomato", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldOnionShouldAddToSpecial()
        {
            TRexKingBurger burger = new TRexKingBurger();
            burger.HoldOnion();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Onion", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            TRexKingBurger burger = new TRexKingBurger();
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
            TRexKingBurger burger = new TRexKingBurger();
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
        public void HoldMayoShouldAddToSpecial()
        {
            TRexKingBurger burger = new TRexKingBurger();
            burger.HoldMayo();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Mayo", item);
            }
                );
        }

        /// <summary>
        /// tests to see if there are multiple special instructions, to add to the special[]
        /// </summary>
        [Fact]
        public void HoldKetchupAndPickleAndMustardAndMayoShouldAddToSpecial()
        {
            TRexKingBurger burger = new TRexKingBurger();
            burger.HoldPickle();
            burger.HoldKetchup();
            burger.HoldMustard();
            burger.HoldMayo();
            Assert.Collection<string>(burger.Special, item =>
            {
                Assert.Equal("Hold Pickle", item);
            }, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            }, item =>
            {
                Assert.Equal("Hold Mustard", item);
            }, item =>
            {
                Assert.Equal("Hold Mayo", item);
            }
                );
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldBunShouldNotifyIngredintsChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
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
            TRexKingBurger burger = new TRexKingBurger();
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
            TRexKingBurger burger = new TRexKingBurger();
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
            TRexKingBurger burger = new TRexKingBurger();
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
            TRexKingBurger burger = new TRexKingBurger();
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
            TRexKingBurger burger = new TRexKingBurger();
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
            TRexKingBurger burger = new TRexKingBurger();
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
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldMustard();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldLettuceShouldNotifyIngredintsChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Ingredients", () =>
            {
                burger.HoldLettuce();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldLettuceShouldNotifySpecialChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldLettuce();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldTomatoShouldNotifyIngredintsChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Ingredients", () =>
            {
                burger.HoldTomato();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldTomatoShouldNotifySpecialChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldTomato();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldMayoShouldNotifyIngredintsChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Ingredients", () =>
            {
                burger.HoldMayo();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldMayoShouldNotifySpecialChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldMayo();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldOnionShouldNotifyIngredintsChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Ingredients", () =>
            {
                burger.HoldOnion();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldOnionShouldNotifySpecialChange()
        {
            TRexKingBurger burger = new TRexKingBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldOnion();
            });
        }
    }

}
