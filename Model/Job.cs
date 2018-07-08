using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobApi.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string Name { get; set; }

        public string Company { get; set; }

        public string Skills { get; set; }
    }
}
