using RentShopVT.Views;

namespace RentShopVT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPageNovo();
        }
    }
}
