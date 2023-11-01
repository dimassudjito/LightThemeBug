using LightThemeBug;

namespace MobileRT_MAUI.Themes
{
    class DarkThemeSettings: IDynamicTheme
    {
        public void ApplyDynamicTheme()
        {
            App.Current.Resources["BackgroundColor"] = Color.FromArgb("#404040");
            App.Current.Resources["PrimaryMainColor"] = Color.FromArgb("#00A499");
            App.Current.Resources["PrimaryMainDarkColor"] = Color.FromArgb("#007069");
            App.Current.Resources["PrimaryContrastColor"] = Color.FromArgb("#A1FFEF");
            App.Current.Resources["ForegroundTextColor"] = Color.FromArgb("#FFFFFF");
            App.Current.Resources["ForegroundSecondaryTextColor"] = Color.FromArgb("#b3b3b3");
            App.Current.Resources["TitleBarBackgroundColor"] = Color.FromArgb("#171717");
            App.Current.Resources["BorderColor"] = Color.FromArgb("#FFFFFF");
            App.Current.Resources["CallSupportLogo"] = "support_agent_white.png";
            App.Current.Resources["SettingsLogo"] = "gear_white.png";
        }
    }
}
