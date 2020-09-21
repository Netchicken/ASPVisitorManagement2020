using System;
using System.ComponentModel.DataAnnotations;

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
        [Range(0, 1000)]
        public int VisitorCount { get; set; }

    }
}
