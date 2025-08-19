using Microsoft.AspNetCore.Components;
using MudBlazor;
using blazorwebapp.Components.Shared.Navigation;


namespace blazorwebapp.Components.Cards
{
public partial class DirCardsDialog
{
        
        private int selectedRowNumber = -1;
        private MudTable<NavListItem> mudTable;

        [Inject]
        private NavigationManager navMan { get; set; }
        [Parameter]
        public List<NavListItem> Elements { get; set; } = new List<NavListItem>()
        {
            new NavListItem() { Name="UserBranchMaintenance", Path="/" },
            new NavListItem() { Name="FinanceBranchMaintenance", Path="/" },
            new NavListItem() { Name="SomethingElseMaintenance", Path="/" },
        };
        
        private void RowClickEvent(TableRowClickEventArgs<NavListItem> tableRowClickEventArgs)
        {
            
            if(tableRowClickEventArgs != null)
                navMan.NavigateTo(tableRowClickEventArgs.Item.Path);
        }

        private string SelectedRowClassFunc(NavListItem element, int rowNumber)
        {
            if (mudTable.SelectedItem != null && mudTable.SelectedItem.Equals(element))
            {
                return "selected";
            }
            else
            {
                return string.Empty;
            }
        }

    }

}