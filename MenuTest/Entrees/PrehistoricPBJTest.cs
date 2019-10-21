using System.Collections.Generic;
using Xunit;

using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        /// <summary>
        /// has correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        /// <summary>
        /// has correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }
        
        /// <summary>
        /// has correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        /// <summary>
        /// removes peanut butter from ingredients
        /// </summary>
        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        /// <summary>
        /// removes jelly from ingredients
        /// </summary>
        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);

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
        public void HoldPeanutButterShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            }
                );
        }

        /// <summary>
        /// checks to make sure that if there are any special instructions for food prep, it adds to the special[]
        /// </summary>
        [Fact]
        public void HoldJellyShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Jelly", item);
            }
                );
        }

        /// <summary>
        /// tests to see if there are multiple special instructions, to add to the special[]
        /// </summary>
        [Fact]
        public void HoldPeanutButterAndJellyShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            pbj.HoldJelly();
            Assert.Collection<string>(pbj.Special, item =>
            {
                Assert.Equal("Hold Peanut Butter", item);
            }, item =>
            {
                Assert.Equal("Hold Jelly", item);
            }
                );
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldingPeanutButterShouldNotifySpecialChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldPeanutButter();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void HoldingJellyShouldNotifySpecialChange()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            });
        }
    }

}
