using MudBlazor;
using Microsoft.AspNetCore.Components;
using blazorwebapp.Components.Shared.Navigation;
namespace blazorwebapp.Components.SearchBox {

    public partial class CustomNavSearchBox {
        
        [Parameter]
        public List<NavListItem> Elements { get; set; } = new List<NavListItem>();
        [Parameter]
        public string Style { get; set; } = "";
        [Parameter]
        public MudBlazor.Variant Variant { get; set; } = MudBlazor.Variant.Text;

        private string _currentString = "";
        private bool _open = false;
        private MudTextField<string> textField = new MudTextField<string>();
        

        public void setOpen(bool val)
        {
            _open = val;
        } 

        public void toggleOpen()
        {
            _open = !_open;
        }
    }

}