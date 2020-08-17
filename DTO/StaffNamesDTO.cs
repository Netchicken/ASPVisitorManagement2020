using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPVisitorManagement2020.DTO
{
    public class StaffNamesDTO
    {
        [Key]
        public int Id { get; set; }
    [Required]
        public string Name { get; set; }
        [Required]
        public string Department { get; set; }
      
        public int VisitorCount { get; set; }






    }
}
