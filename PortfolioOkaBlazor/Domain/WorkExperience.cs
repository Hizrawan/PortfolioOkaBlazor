namespace PortfolioOkaBlazor.Domain
{
    public class WorkExperience
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; } = default!;
        public string Position { get; set; } = default!;
        public string JobDesc { get; set; }

        // Parameterless constructor for EF Core
        private WorkExperience() { }
        public WorkExperience(string companyname, string position, string jobdesc)
        {
            Id = Guid.NewGuid();
            CompanyName = companyname;
            Position = position;
            JobDesc = jobdesc;
        }
    }
}
