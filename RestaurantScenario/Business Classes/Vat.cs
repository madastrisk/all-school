using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantScenario
{
    /// <summary>
    /// The class to represent a vat.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Vat
    {
        /// <summary>
        /// The vat's capacity.
        /// </summary>
        public double Capacity;

        /// <summary>
        /// The vat's soup level.
        /// </summary>
        public double Level;

        /// <summary>
        /// The type of soup.
        /// </summary>
        public string Type;
    }
}
