using Xunit;

using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MeteorMacAndCheeseTest
    {
        /// <summary>
        /// has correctt price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal(0.99, mmc.Price, 2);
        }

        /// <summary>
        /// has correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<uint>(420, mmc.Calories);
        }

        /// <summary>
        /// has correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Contains<string>("Macaroni Noodles", mmc.Ingredients);
            Assert.Contains<string>("Cheese Product", mmc.Ingredients);
            Assert.Contains<string>("Pork Sausage", mmc.Ingredients);
            Assert.Equal<int>(3, mmc.Ingredients.Count);
        }

        /// <summary>
        /// has correct size 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<Size>(Size.Small, mmc.Size);
        }

        /// <summary>
        /// can change size to medium and get right price
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal(1.45, mmc.Price, 2);
        }

        /// <summary>
        /// gets right calories for size medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<uint>(490, mmc.Calories);
        }

        /// <summary>
        /// able to set to medium
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, mmc.Size);
        }

        /// <summary>
        /// has correct price for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal(1.95, mmc.Price, 2);
        }

        /// <summary>
        /// has correct calories for large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<uint>(520, mmc.Calories);
        }

        /// <summary>
        /// able to set to large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, mmc.Size);
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
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mac.Description);

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
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = size;
            Assert.PropertyChanged(mac, "Price", () =>
            {
                mac.Size = size;
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
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = size;
            Assert.PropertyChanged(mac, "Calories", () =>
            {
                mac.Size = size;
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
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            mac.Size = size;
            Assert.PropertyChanged(mac, "Description", () =>
            {
                mac.Size = size;
            });

        }
    }
}
