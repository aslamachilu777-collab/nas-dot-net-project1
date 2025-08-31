namespace nas_project1.Model
{
    public class Policy
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; } = string.Empty;
        public string HolderName { get; set; } = string.Empty;
        public decimal CoverageAmount { get; set; }
    }
}
