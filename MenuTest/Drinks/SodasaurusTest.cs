/* SodasaurusTest.cs
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
    /// this class implements all of the tests for sodasaurus
    /// </summary>
    public class SodasaurusTest
    {
        /// <summary>
        /// checks for setting flavor to cherry
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        /// <summary>
        /// checks for setting flavor to cola
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        /// <summary>
        /// checks for setting flavor to orange
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        /// <summary>
        /// checks for setting flavor to vanilla
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        /// <summary>
        /// checks for setting flavor to chocolate
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        /// <summary>
        /// checks for setting flavor to root beer
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        /// <summary>
        /// checks for setting flavor to lime
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        /// <summary>
        /// checks to make sure holdice method works and sets ice to false
        /// </summary>
        [Fact]  
        public void ShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        /// <summary>
        /// checks for correct default price of the drink
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// checks for correct price after setting size to small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// checks to see default calories are correct (small)
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// checks for correct price after setting size to medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        /// <summary>
        /// checks for correct price after setting size to large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        /// <summary>
        /// checks to see if drink has ice at default
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        /// <summary>
        /// checks for correct default size of soda
        /// </summary>
        [Fact] 
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(Size.Small, soda.Size);
        }
        /// <summary>
        /// checks to see if the drink has the correct ingredients 
        /// </summary>
        [Fact] 
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
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
            SodasaurusFlavor flav = new SodasaurusFlavor();
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            switch(flav)
            {
                case SodasaurusFlavor.Cherry:
                    Assert.Equal($"{size} {flav} Sodasaurus", soda.Description);
                    break;
                case SodasaurusFlavor.Chocolate:
                    Assert.Equal($"{size} {flav} Sodasaurus", soda.Description);
                    break;
                case SodasaurusFlavor.Cola:
                    Assert.Equal($"{size} {flav} Sodasaurus", soda.Description);
                    break;
                case SodasaurusFlavor.Lime:
                    Assert.Equal($"{size} {flav} Sodasaurus", soda.Description);
                    break;
                case SodasaurusFlavor.Orange:
                    Assert.Equal($"{size} {flav} Sodasaurus", soda.Description);
                    break;
                case SodasaurusFlavor.RootBeer:
                    Assert.Equal($"{size} {flav} Sodasaurus", soda.Description);
                    break;
                case SodasaurusFlavor.Vanilla:
                    Assert.Equal($"{size} {flav} Sodasaurus", soda.Description);
                    break;
            }
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
        public void HoldIceShouldAddToSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            }
                );
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
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = size;
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
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = size;
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
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Size = size;
            });

        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Fact]
        public void FlavorShouldBeNotifiedWhenChanged()
        {
            SodasaurusFlavor flav = new SodasaurusFlavor();
            Sodasaurus soda = new Sodasaurus();
            
            switch (flav)
            {
                case SodasaurusFlavor.Cherry:
                    Assert.PropertyChanged(soda, "Flavor", () =>
                    {
                        soda.Flavor = flav;
                    });
                    break;
                case SodasaurusFlavor.Chocolate:
                    Assert.PropertyChanged(soda, "Flavor", () =>
                    {
                        soda.Flavor = flav;
                    });
                    break;
                case SodasaurusFlavor.Cola:
                    Assert.PropertyChanged(soda, "Flavor", () =>
                    {
                        soda.Flavor = flav;
                    });
                    break;
                case SodasaurusFlavor.Lime:
                    Assert.PropertyChanged(soda, "Flavor", () =>
                    {
                        soda.Flavor = flav;
                    });
                    break;
                case SodasaurusFlavor.Orange:
                    Assert.PropertyChanged(soda, "Flavor", () =>
                    {
                        soda.Flavor = flav;
                    });
                    break;
                case SodasaurusFlavor.RootBeer:
                    Assert.PropertyChanged(soda, "Flavor", () =>
                    {
                        soda.Flavor = flav;
                    });
                    break;
                case SodasaurusFlavor.Vanilla:
                    Assert.PropertyChanged(soda, "Flavor", () =>
                    {
                        soda.Flavor = flav;
                    });
                    break;
            }
        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldBeNotifiedWhenChanged(Size size)
        {
            SodasaurusFlavor flav = new SodasaurusFlavor();
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            switch (flav)
            {
                case SodasaurusFlavor.Cherry:
                    Assert.PropertyChanged(soda, "Description", () =>
                    {
                        soda.Size = size;
                    });
                    break;
                case SodasaurusFlavor.Chocolate:
                    Assert.PropertyChanged(soda, "Description", () =>
                    {
                        soda.Size = size;
                    });
                    break;
                case SodasaurusFlavor.Cola:
                    Assert.PropertyChanged(soda, "Description", () =>
                    {
                        soda.Size = size;
                    });
                    break;
                case SodasaurusFlavor.Lime:
                    Assert.PropertyChanged(soda, "Description", () =>
                    {
                        soda.Size = size;
                    });
                    break;
                case SodasaurusFlavor.Orange:
                    Assert.PropertyChanged(soda, "Description", () =>
                    {
                        soda.Size = size;
                    });
                    break;
                case SodasaurusFlavor.RootBeer:
                    Assert.PropertyChanged(soda, "Description", () =>
                    {
                        soda.Size = size;
                    });
                    break;
                case SodasaurusFlavor.Vanilla:
                    Assert.PropertyChanged(soda, "Description", () =>
                    {
                        soda.Size = size;
                    });
                    break;
            }
        }
    }
}
