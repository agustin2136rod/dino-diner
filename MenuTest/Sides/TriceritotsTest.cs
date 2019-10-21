using Xunit;

using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class TriceritotsTest
    {
        /// <summary>
        /// has correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal(0.99, tt.Price, 2);
        }

        /// <summary>
        /// has correct calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<uint>(352, tt.Calories);
        }

        /// <summary>
        /// has correct ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Triceritots tt = new Triceritots();
            Assert.Contains<string>("Potato", tt.Ingredients);
            Assert.Contains<string>("Salt", tt.Ingredients);
            Assert.Contains<string>("Vegetable Oil", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
        }

        /// <summary>
        /// has correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        /// <summary>
        /// has correct price for medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal(1.45, tt.Price, 2);
        }

        /// <summary>
        /// has correct calories for medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(410, tt.Calories);
        }

        /// <summary>
        /// able to set to medium
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tt.Size);
        }

        /// <summary>
        /// has correct price for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal(1.95, tt.Price, 2);
        }

        /// <summary>
        /// has correct calories for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<uint>(590, tt.Calories);
        }

        /// <summary>
        /// able to set to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tt.Size);
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
            Triceritots tots = new Triceritots();
            tots.Size = size;
            Assert.Equal($"{size} Triceritots", tots.Description);

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
            Triceritots tots = new Triceritots();
            tots.Size = size;
            Assert.PropertyChanged(tots, "Price", () =>
            {
                tots.Size = size;
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
            Triceritots tots = new Triceritots();
            tots.Size = size;
            Assert.PropertyChanged(tots, "Calories", () =>
            {
                tots.Size = size;
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
            Triceritots tots = new Triceritots();
            tots.Size = size;
            Assert.PropertyChanged(tots, "Description", () =>
            {
                tots.Size = size;
            });

        }
    }
}
