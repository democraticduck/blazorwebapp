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
                Primary = Colors.Shades.Black,
                Secondary = Colors.Red.Lighten1,
                AppbarBackground = Colors.Shades.White,
                Background = Colors.Gray.Lighten4,
                
                
            }
        };
        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
