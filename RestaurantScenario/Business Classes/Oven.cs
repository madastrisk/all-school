using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantScenario
{
    /// <summary>
    /// The class which is used to represent an oven.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Oven
    {
        /// <summary>
        /// The maximum number of breadsticks that can be baked in the oven at any given time.
        /// </summary>
        public int BreadstickBatchSize;

        /// <summary>
        /// The total number of breadsticks that have been baked in the oven.
        /// </summary>
        public int NumberOfBreadsticksBaked;
    }
}