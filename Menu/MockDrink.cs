/* MockDrink.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class implements a mock drink item for order tests
    /// </summary>
    public class MockDrink : Drink
    {
        /// <summary>
        /// list of ingredients for the item
        /// </summary>
        public override List<string> Ingredients => throw new NotImplementedException();

        /// <summary>
        /// description of the item itself
        /// </summary>
        public override string Description => throw new NotImplementedException();

        /// <summary>
        /// special food prep instructions for item
        /// </summary>
        public override string[] Special => throw new NotImplementedException();

        /// <summary>
        /// constructor that sets the price of the item
        /// </summary>
        /// <param name="price"></param>
        public MockDrink(double price)
        {
            this.Price = price;
        }
    }
}
