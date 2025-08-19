namespace blazorwebapp.Components.Shared.Navigation
{
    public class NavListItem
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
