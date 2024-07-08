namespace PortfolioOkaBlazor.Domain
{
    public class EducationData
    {
        public Guid Id { get; set; }
        public string UniversityName { get; set; } = default!;
        public string Major { get; set; } = default!;
        public string GPA { get; set; }
        public string Color { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }


        // Parameterless constructor for EF Core
        private EducationData() { }
        public EducationData(string universityName, string major, string gpa, string color, string link, string image)
        {
            Id = Guid.NewGuid();
            UniversityName = universityName;
            Major = major;
            GPA = gpa;
            Color = color;
            Link = link;
            Image = image;
        }
    }
}
