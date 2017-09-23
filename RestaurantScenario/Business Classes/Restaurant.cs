using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantScenario
{
    /// <summary>
    /// The class which is used to represent a restaurant.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Restaurant
    {
        /// <summary>
        /// The number of patrons that can be seated in the restaurant at any given time.
        /// </summary>
        public int Capacity;

        /// <summary>
        /// The restaurant's dinner menu.
        /// </summary>
        public Menu DinnerMenu;

        /// <summary>
        /// The restaurant's lunch menu.
        /// </summary>
        public Menu LunchMenu;

        /// <summary>
        /// The name of the restaurant.
        /// </summary>
        public string Name;

        /// <summary>
        /// The owner of the restaurant.
        /// </summary>
        public Cook Owner;

        /// <summary>
        /// Moms regular patron.
        /// </summary>
        public Patron TheRegular;
    }
}