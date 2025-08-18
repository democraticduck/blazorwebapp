using MudBlazor;
namespace blazorwebapp.Components.Layout
{
    public partial class CustomLayout
    {
        bool _drawerOpen = true;
        MudTheme CustomTheme = new MudTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = Colors.Shades.White,
                Secondary = Colors.Red.Lighten1,
                AppbarBackground = Colors.Green.Accent1
            }
        };
        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
