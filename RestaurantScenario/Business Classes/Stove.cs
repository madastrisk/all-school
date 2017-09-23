using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantScenario
{
    /// <summary>
    /// The class that represents a stove.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Stove
    {
        /// <summary>
        /// The amount of soup that is made.
        /// </summary>
        public double AmountOfSoupMade;

        /// <summary>
        /// The size of a batch of soup.
        /// </summary>
        public double SoupBatchSize;
    }
}
