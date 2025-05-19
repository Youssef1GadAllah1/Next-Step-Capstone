namespace Capstone_Next_Step.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public string ReportContant { get; set; }
        public int CreatedById { get; set; }
       

        // Foreign key for the associated asset
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
    }
}
