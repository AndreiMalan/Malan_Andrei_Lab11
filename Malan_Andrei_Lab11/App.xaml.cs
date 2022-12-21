using Malan_Andrei_Lab11.Data;

namespace Malan_Andrei_Lab11  
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
            /* InitializeComponent();

             MainPage = new AppShell();*/
        }
    }
}