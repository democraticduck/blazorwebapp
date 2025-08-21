using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace blazorwebapp.Components.Dialog
{
    public partial class CustomDialog
    {
        [Parameter]
        public RenderFragment? Title { get; set; }
        [Parameter, EditorRequired]
        public RenderFragment? Body { get; set; }
        private MudDialog _dialog { get; set; }

        private void CloseDialog()
        {
            _dialog?.CloseAsync();
        }
    }
}
