using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentWebApi.Models
{
    public class EquiModels
    {
        [Key]

        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string TotalAmount { get; set; }
        public DateTime PurchageDate { get; set; }
    }
}
