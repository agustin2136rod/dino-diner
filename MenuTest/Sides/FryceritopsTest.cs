using Xunit;

using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class FryceritopsTest
    {
        /// <summary>
        /// has correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal(0.99, ft.Price, 2);
        }

        /// <summary>
        /// has correct calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<uint>(222, ft.Calories);
        }

        /// <summary>
        /// has correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Contains<string>("Potato", ft.Ingredients);
            Assert.Contains<string>("Salt", ft.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }

        /// <summary>
        /// has correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        /// <summary>
        /// has correct price for size medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal(1.45, ft.Price, 2);
        }

        /// <summary>
        /// has correct calories for size medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(365, ft.Calories);
        }

        /// <summary>
        /// sets size to medium
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        /// <summary>
        /// has correct price for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal(1.95, ft.Price, 2);
        }

        /// <summary>
        /// has correct calories for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<uint>(480, ft.Calories);
        }

        /// <summary>
        /// able to set to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
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
            Fryceritops fries = new Fryceritops();
            fries.Size = size;
            Assert.Equal($"{size} Fryceritops", fries.Description);

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
        /// tests to make sure the description for the item is correct
        /// </summary>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangeSizeShouldNotifyPrice(Size size)
        {
            Fryceritops fries = new Fryceritops();
            fries.Size = size;
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = size;
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
            Fryceritops fries = new Fryceritops();
            fries.Size = size;
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = size;
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
            Fryceritops fries = new Fryceritops();
            fries.Size = size;
            Assert.PropertyChanged(fries, "Description", () =>
            {
                fries.Size = size;
            });

        }
    }
}
