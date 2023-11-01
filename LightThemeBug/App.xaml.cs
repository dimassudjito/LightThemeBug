using MobileRT_MAUI.Themes;

namespace LightThemeBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            new DarkThemeSettings().ApplyDynamicTheme();

            MainPage = new AppShell();
        }
    }
}