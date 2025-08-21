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
            new NavListItem { Name = "Expenses", Path = "/expenses" },
            new NavListItem { Name = "Budgets", Path = "/budgets" }
        }
    },
    new TableCategoryElement
    {
        Category = "HR",
        navListItems = new List<NavListItem>
        {
            new NavListItem { Name = "Employees", Path = "/employees" },
            new NavListItem { Name = "Leave Requests", Path = "/leave-requests" },
            new NavListItem { Name = "Payroll", Path = "/payroll" }
        }
    },
    new TableCategoryElement
    {
        Category = "Sales",
        navListItems = new List<NavListItem>
        {
            new NavListItem { Name = "Customers", Path = "/customers" },
            new NavListItem { Name = "Orders", Path = "/orders" },
            new NavListItem { Name = "Products", Path = "/products" }
        }
    },
    new TableCategoryElement
    {
        Category = "Operations",
        navListItems = new List<NavListItem>
        {
            new NavListItem { Name = "Suppliers", Path = "/suppliers" },
            new NavListItem { Name = "Inventory", Path = "/inventory" },
            new NavListItem { Name = "Logistics", Path = "/logistics" }
        }
    },
    new TableCategoryElement
    {
        Category = "Analytics",
        navListItems = new List<NavListItem>
        {
            new NavListItem { Name = "Reports", Path = "/reports" },
            new NavListItem { Name = "Dashboards", Path = "/dashboards" },
            new NavListItem { Name = "KPIs", Path = "/kpis" }
        }
    }
    };
    }
}
