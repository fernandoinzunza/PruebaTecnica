using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Movement:BaseEntity
    {
        public decimal Amount { get; set; }
        public MovementType MovementType { get; set; }
        public int SavingsAccountId { get; set; }
        [ForeignKey("SavingsAccountId")]
        public SavingsAccount? SavingsAccount { get; set; }
    }
}
