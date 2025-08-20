using Microsoft.AspNetCore.Components;

namespace blazorwebapp.Components.Tables
{
    public class TableColumn<T>
    {
        public string Header { get; set; } = "";
        public string PropertyName { get; set; } = "";
        public RenderFragment<T>? CellTemplate { get; set; }
        public bool IsSortable { get; set; } = false;
        public string CssClass { get; set; } = "";
        public string Width { get; set; } = "";
    }

    public static class TableColumnBuilder<T>
    {
        public static TableColumn<T> Create(string header, string propertyName)
        {
            return new TableColumn<T>
            {
                Header = header,
                PropertyName = propertyName
            };
        }

        public static TableColumn<T> CreateWithTemplate(string header, RenderFragment<T> template)
        {
            return new TableColumn<T>
            {
                Header = header,
                CellTemplate = template
            };
        }
    }
}