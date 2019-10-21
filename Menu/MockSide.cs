/* MockSide.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class implements a mock side item for order tests
    /// </summary>
    public class MockSide : Side
    {
        /// <summary>
        /// list of ingredients 
        /// </summary>
        public override List<string> Ingredients => throw new NotImplementedException();

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description => throw new NotImplementedException();

        /// <summary>
        /// string array of special order instructions
        /// </summary>
        public override string[] Special => throw new NotImplementedException();

        /// <summary>
        /// constructor that sets the price of the item
        /// </summary>
        /// <param name="price"></param>
        public MockSide(double price)
        {
            this.Price = price;
        }
    }
}
