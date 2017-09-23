using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RestaurantScenario
{
    /// <summary>
    /// Contains interaction logic for MainWindow.xaml.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event handlers may begin with lower-case letters.")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Moms Restaurant.
        /// </summary>
        public Restaurant Moms;
        
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Creates a restaurant and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newRestaurantButton_Click(object sender, RoutedEventArgs e)
        {
            this.Moms = new Restaurant();

            // Set the field value of Moms.
            this.Moms.Capacity = 25;
            this.Moms.DinnerMenu = new Menu();
            this.Moms.LunchMenu = new Menu();
            this.Moms.Name = "Mom's";
            this.Moms.Owner = new Cook();
            this.Moms.TheRegular = new Patron();

            // Set field values of dinner menu.
            this.Moms.DinnerMenu.Color = "Black";
            this.Moms.DinnerMenu.NumberOfPages = 6;
            this.Moms.DinnerMenu.Type = "Dinner";

            // Set field valuse of lunch menu
            this.Moms.LunchMenu.Color = "Black";
            this.Moms.LunchMenu.NumberOfPages = 4;
            this.Moms.LunchMenu.Type = "Lunch";

            // Set field values of the owner
            this.Moms.Owner.BreadBasket = new Basket();
            this.Moms.Owner.BreadOven = new Oven();
            this.Moms.Owner.Name = "Vladimir";
            this.Moms.Owner.NumberOfItemsCooked = 25;
            this.Moms.Owner.Salary = 28000.00m;
            this.Moms.Owner.GasStove = new Stove();
            this.Moms.Owner.SoupVat = new Vat();

            // Set field values of the patron.
            this.Moms.TheRegular.FavoriteDrinkClass = "Lemonade";
            this.Moms.TheRegular.FavoriteEntreeName = "Meatloaf";
            this.Moms.TheRegular.Name = "Frank";

            // Set the Values of the bread basket.
            this.Moms.Owner.BreadBasket.BreadStickCapacity = 45;
            this.Moms.Owner.BreadBasket.BreadStickCount = 18;

            // Set field values of the bread oven.
            this.Moms.Owner.BreadOven.BreadstickBatchSize = 25;
            this.Moms.Owner.BreadOven.NumberOfBreadsticksBaked = 255;

            // Set field values of the gas stove.
            this.Moms.Owner.GasStove.AmountOfSoupMade = 174;
            this.Moms.Owner.GasStove.SoupBatchSize = 12;

            // Set the field values of the soup vat.
            this.Moms.Owner.SoupVat.Capacity = 30;
            this.Moms.Owner.SoupVat.Level = 10;
            this.Moms.Owner.SoupVat.Type = "Soup";
        }
    }
}