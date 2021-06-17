using System;
using System.ComponentModel.DataAnnotations;
namespace Trust.Entities
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectEnd { get; set; }
        public DateTime ProjectDeadline { get; set; }
        public int TeaId { get; set; }
        public int StatusName { get; set; }
    }
   
}