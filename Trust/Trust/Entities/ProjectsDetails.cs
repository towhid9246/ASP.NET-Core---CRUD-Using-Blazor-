using System;
using System.ComponentModel.DataAnnotations;
namespace Trust.Entities
{
    public class ProjectsDetails
    {
        [Key]
        public int DetailsId { get; set; }
        public string Comments { get; set; }

        public DateTime ProjectDate { get; set; }
        public int StaId { get; set; }
        //public int StId { get; set; }
    }
}