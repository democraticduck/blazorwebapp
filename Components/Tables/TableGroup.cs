using Microsoft.AspNetCore.Components;

namespace blazorwebapp.Components.Tables
{
    public class TableGroup<T>
    {
        public string GroupName { get; set; } = "";
        public List<T> Data { get; set; } = new();
        public bool IsExpanded { get; set; } = false;
    }

    public static class TableGroupBuilder<T>
    {
        public static TableGroup<T> Create(string groupName, List<T> data, bool isExpanded = false)
        {
            return new TableGroup<T>
            {
                GroupName = groupName,
                Data = data,
                IsExpanded = isExpanded
            };
        }
    }
}