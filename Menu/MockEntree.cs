/* MockEntree.cs
 * Author: Agustin Rodriguez
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class implements a mock entree for the order tests
    /// </summary>
    public class MockEntree : Entree
    {
        /// <summary>
        /// list of ingredients of the food item
        /// </summary>
        public override List<string> Ingredients => throw new NotImplementedException();

        /// <summary>
        /// description of the item itself
        /// </summary>
        public override string Description => throw new NotImplementedException();

        /// <summary>
        /// special food prep instructions
        /// </summary>
        public override string[] Special => throw new NotImplementedException();

        /// <summary>
        /// constructor that sets the price of the item
        /// </summary>
        /// <param name="price"></param>
        public MockEntree(double price)
        {
            this.Price = price;
        }
    }
}
