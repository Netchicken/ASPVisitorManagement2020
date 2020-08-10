using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPVisitorManagement2020.Models
{
    public class Visitor
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
