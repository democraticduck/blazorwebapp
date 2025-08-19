using blazorwebapp.Components.Shared.Navigation;

namespace blazorwebapp.Components.Pages
{
    public partial class Home
    {
        private List<TableCategoryElement> Elements { get; set; } = new List<TableCategoryElement>
    {
        new TableCategoryElement
        {
            Category = "IT",
            navListItems = new List<NavListItem>
            {
                new NavListItem { Name = "Users", Path = "/users" },
                new NavListItem { Name = "Roles", Path = "/roles" },
                new NavListItem { Name = "Permissions", Path = "/permissions" }
            }
        },
        new TableCategoryElement
        {
            Category = "Finance",
            navListItems = new List<NavListItem>
            {
                new NavListItem { Name = "Invoices", Path = "/invoices" },
                new NavListItem { Name = "Expenses", Path = "/expenses" }
            }
        }
    };
    }
}
