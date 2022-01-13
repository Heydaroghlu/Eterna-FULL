using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EternaFULL.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(maximumLength:200)]
        public string Desc { get; set; }
    }
}
