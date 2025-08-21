using Microsoft.AspNetCore.Components;

namespace blazorwebapp.Components.Tabs
{
    public partial class CustomNavTabs
    {
        [Parameter, EditorRequired]
        public RenderFragment? MudTabPanels { get; set; }
    }
}
