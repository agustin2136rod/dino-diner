
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class DinoNuggetsUnitTest
    {
        /// <summary>
        /// has correct dault price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal(4.25, dn.Price, 2);
        }

        /// <summary>
        /// has correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal<uint>(59*6, dn.Calories);
        }

        /// <summary>
        /// has correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            List<string> ingredients = dn.Ingredients;
            // Should be six nuggets
            int nuggetCount = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(6, nuggetCount);
            Assert.Equal<int>(6, ingredients.Count);
        }

        /// <summary>
        /// adding nuggets adds to ingredients
        /// </summary>
        [Fact]
        public void AddingNuggetsShouldAddIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            // Should be seven nuggets
            int nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(7, nuggetCount);
            Assert.Equal<int>(7, dn.Ingredients.Count);

            dn.AddNugget();
            // Should be 8 nuggets
            nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(8, nuggetCount);
            Assert.Equal<int>(8, dn.Ingredients.Count);

        }

        /// <summary>
        /// adding nuggets increases the price
        /// </summary>
        [Fact]
        public void AddingNuggetsShouldIncreasePrice()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal(4.50, dn.Price, 2);
            dn.AddNugget();
            Assert.Equal(4.75, dn.Price, 2);
            dn.AddNugget();
            Assert.Equal(5.0, dn.Price, 2);
        }

        /// <summary>
        /// adding nuggets increases the calories
        /// </summary>
        [Fact]
        public void AddingNuggetsShouldIncreaseCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*7);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*8);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*9);
        }

        /// <summary>
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            DinoNuggets nuggs = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", nuggs.Description);

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
        public void AddingExtraNuggetsShouldAddToSpecial()
        {
            DinoNuggets nuggs = new DinoNuggets();
            nuggs.AddNugget();
            nuggs.AddNugget();
            Assert.Collection<string>(nuggs.Special, item =>
            {
                Assert.Equal("2 Extra Nuggets", item);
            });
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
        public void AddingNuggetShouldNotifyIngredintsChange()
        {
            DinoNuggets nuggs = new DinoNuggets();
            Assert.PropertyChanged(nuggs, "Ingredients", () =>
            {
                nuggs.AddNugget();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void AddingNuggetShouldNotifySpecialChange()
        {
            DinoNuggets nuggs = new DinoNuggets();
            Assert.PropertyChanged(nuggs, "Special", () =>
            {
                nuggs.AddNugget();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void AddingNuggetShouldNotifyPriceChange()
        {
            DinoNuggets nuggs = new DinoNuggets();
            Assert.PropertyChanged(nuggs, "Price", () =>
            {
                nuggs.AddNugget();
            });
        }

        /// <summary>
        /// tests to see that special is notified whenever a property changes
        /// </summary>
        [Fact]
        public void AddingNuggetShouldNotifyCaloriesChange()
        {
            DinoNuggets nuggs = new DinoNuggets();
            Assert.PropertyChanged(nuggs, "Calories", () =>
            {
                nuggs.AddNugget();
            });
        }
    }
}
