using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantScenario
{
    /// <summary>
    /// The class to represent the bread basket.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Basket 
    {
        /// <summary>
        /// The number of breadsticks the basket can hold.
        /// </summary>
        public int BreadStickCapacity;

        /// <summary>
        /// The number of breadsticks in the basket.
        /// </summary>
        public int BreadStickCount;
    }
}
