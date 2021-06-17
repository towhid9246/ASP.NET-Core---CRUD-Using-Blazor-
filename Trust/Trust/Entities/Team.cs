using System.ComponentModel.DataAnnotations;
namespace Trust.Entities
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamDesc { get; set; }
        public string TeamStatus { get; set; }
    }
}