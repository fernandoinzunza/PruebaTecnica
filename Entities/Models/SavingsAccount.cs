using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class SavingsAccount:BaseEntity
    {
        [Required]
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client? Client { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [DefaultValue(0)]
        public decimal Balance { get; set; }
    }
}
