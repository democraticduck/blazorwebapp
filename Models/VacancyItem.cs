namespace blazorwebapp.Models
{
    public class VacancyItem
    {
        public int No { get; set; }
        public string Role { get; set; } = "";
        public string Location { get; set; } = "";
        public string EmploymentType { get; set; } = "";
        public string JobCategory { get; set; } = "";
        public string SalaryRange { get; set; } = "";
        public string PostedDate { get; set; } = "";
        public string ClosingDate { get; set; } = "";
        public string Status { get; set; } = "";
    }
}