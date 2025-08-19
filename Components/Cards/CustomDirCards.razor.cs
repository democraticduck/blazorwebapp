using blazorwebapp.Components.Shared.Navigation;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace blazorwebapp.Components.Cards
{
    public partial class CustomDirCards
    {
        [Inject]
        private IDialogService DialogService { get; set; }

        [Parameter]
        public List<TableCategoryElement> Elements { get; set; }
        private Task OpenDialogAsync(TableCategoryElement e)
        {
            var options = new DialogOptions { CloseOnEscapeKey = true };
            var dialogParameters = new DialogParameters<DirCardsDialog>();
            dialogParameters.Add(x => x.Elements, e.navListItems);

            return DialogService.ShowAsync<DirCardsDialog>(e.Category, dialogParameters, options);
        }
    }
}
