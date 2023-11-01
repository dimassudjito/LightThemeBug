using MobileRT_MAUI.Themes;

namespace LightThemeBug
{
    public partial class MainPage : ContentPage
    {
        string theme = "Dark";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(CounterBtn.Text);

            if (theme == "Dark")
            {
                new LightThemeSettings().ApplyDynamicTheme();
                theme = "Light";
            } else
            {
                new DarkThemeSettings().ApplyDynamicTheme();
                theme = "Dark";
            }
            CounterBtn.Text = $"Using {theme} theme";

        }
    }
}