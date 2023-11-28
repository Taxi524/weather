using weather.Pages;

namespace weather
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            MainPage = new WeatherPage();
        }
    }
}