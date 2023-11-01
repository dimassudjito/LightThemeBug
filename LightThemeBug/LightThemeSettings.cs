using LightThemeBug;

namespace MobileRT_MAUI.Themes
{
    class LightThemeSettings : IDynamicTheme
    {
        public void ApplyDynamicTheme()
        {
            App.Current.Resources["BackgroundColor"] = Color.FromArgb("#F5F5F5");
            App.Current.Resources["PrimaryMainColor"] = Color.FromArgb("#00A499");
            App.Current.Resources["PrimaryMainDarkColor"] = Color.FromArgb("#007069");
            App.Current.Resources["PrimaryContrastColor"] = Color.FromArgb("#00897C");
            App.Current.Resources["ForegroundTextColor"] = Color.FromArgb("#000000");
            App.Current.Resources["ForegroundSecondaryTextColor"] = Color.FromArgb("#4C4C4C");
            App.Current.Resources["TitleBarBackgroundColor"] = Color.FromArgb("#E8E8E8");
            App.Current.Resources["BorderColor"] = Color.FromArgb("#4C4C4C");
            App.Current.Resources["CallSupportLogo"] = "support_agent_black.png";
            App.Current.Resources["SettingsLogo"] = "gear_black.png";
        }
    }
}
