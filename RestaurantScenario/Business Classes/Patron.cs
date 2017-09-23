using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantScenario
{
    /// <summary>
    /// This is the class to represent a patron.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Patron
    {
        /// <summary>
        /// The patrons favorite drink.
        /// </summary>
        public string FavoriteDrinkClass;

        /// <summary>
        /// The patrons favorite entree.
        /// </summary>
        public string FavoriteEntreeName;

        /// <summary>
        /// The patrons name.
        /// </summary>
        public string Name;
    }
}
