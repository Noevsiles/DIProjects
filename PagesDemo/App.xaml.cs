namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new TabedPageDemo();
            //MainPage = new NavigationPage(new FlyoutPageDemo());
        }
    }
}
