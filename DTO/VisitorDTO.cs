using ASPVisitorManagement2020.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPVisitorManagement2020.DTO
{
    public class VisitorDTO
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Business { get; set; }
        public DateTime Datein { get; set; }
        public DateTime DateOut { get; set; }
        public StaffNames Staffname { get; set; }

    }
}
