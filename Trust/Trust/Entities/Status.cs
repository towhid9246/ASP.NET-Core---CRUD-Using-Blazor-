using System.ComponentModel.DataAnnotations;
namespace Trust.Entities
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusType { get; set; }

    }
}