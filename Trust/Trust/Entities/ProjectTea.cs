using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trust.Entities
{
    public class ProjectTea : Project
    {
        public string TeaId { get; set; }
        public string StatusName { get; set; }
    }
}