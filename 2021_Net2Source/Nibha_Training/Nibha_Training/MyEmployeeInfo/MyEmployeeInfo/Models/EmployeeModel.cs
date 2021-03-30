using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyEmployeeInfo.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeePosition { get; set; }
        public string OfficeLocation { get; set; }
    }
}
