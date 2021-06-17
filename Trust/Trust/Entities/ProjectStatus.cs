using System.ComponentModel.DataAnnotations;


namespace Trust.Entities
{
    public class ProjectStatus
    {
        [Key]
        public long? ProjectId { get; set; }
        public int StatusId { get; set; }
        //public byte? StatusOrd { get; set; }
    }
}