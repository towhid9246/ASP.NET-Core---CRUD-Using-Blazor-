using System;
using System.ComponentModel.DataAnnotations;

namespace Trust.Entities
{
    public class TeamAssign
    {

        [Key]
        public int AssignId { get; set; }
        
        //public int TeamId { get; set; }
        public int UserId { get; set; }
    }
}
