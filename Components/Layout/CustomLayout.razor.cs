namespace blazorwebapp.Components.Layout
{
    public partial class CustomLayout
    {
        bool _drawerOpen = true;
        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
