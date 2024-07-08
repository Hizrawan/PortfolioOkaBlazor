namespace PortfolioOkaBlazor.Domain
{
    public class SkillData
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;


        // Parameterless constructor for EF Core
        private SkillData() { }
        public SkillData(string title, string description)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;

        }
    }
}
