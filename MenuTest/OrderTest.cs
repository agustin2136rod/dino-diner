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
            MockEntree entree = new MockEntree(-10);
            order.Items.Add(entree);
            Assert.Equal<double>(0, order.SubtotalCost);

        }

        [Fact]
        public void SubtotalCostIsCorrect()
        {
            Order order = new Order();
            MockEntree entree = new MockEntree(2);
            MockSide side = new MockSide(2);
            MockDrink drink = new MockDrink(2);
            order.Items.Add(entree);
            order.Items.Add(side);
            order.Items.Add(drink);
            Assert.Equal<double>(6, order.SubtotalCost);
        }

        [Fact]
        public void SalesTaxCostIsCorrect()
        {
            Order order = new Order();
            MockEntree entree = new MockEntree(2);
            MockSide side = new MockSide(2);
            MockDrink drink = new MockDrink(2);
            order.Items.Add(entree);
            order.Items.Add(side);
            order.Items.Add(drink);
            Assert.Equal<double>(.39, order.SalesTaxCost);
        }

        [Fact]
        public void SalesTaxRateIsCorrect()
        {
            Order order = new Order();
            Assert.Equal<double>(.065, order.SalesTaxRate);
        }

        [Fact]
        public void TotalCostIsCorrect()
        {
            Order order = new Order();
            MockEntree entree = new MockEntree(2);
            MockSide side = new MockSide(2);
            MockDrink drink = new MockDrink(2);
            order.Items.Add(entree);
            order.Items.Add(side);
            order.Items.Add(drink);
            Assert.Equal<double>(6.39, order.TotalCost);
        }
    }
}
