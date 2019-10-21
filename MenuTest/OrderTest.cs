/* OrderTest.cs
 * Author: Agustin Rodriguez
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest
{
    /// <summary>
    /// this class implements all of the tests for the Order class
    /// </summary>
    public class OrderTest
    {
        /// <summary>
        /// checks to make sure that totalCost is not negative
        /// </summary>
        [Fact]
        public void SubtotalCostShouldNeverBeNegative()
        {
            Order order = new Order();
            Brontowurst wurst = new Brontowurst();
            wurst.Price = -10;
            order.Items.Add(wurst);
            Assert.Equal(0, order.SubtotalCost);
        }
    }
}
