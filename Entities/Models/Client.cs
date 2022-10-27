﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Client:BaseEntity
    {
        [Required]
        public string FullName { get; set; }
        public List<SavingsAccount>? SavingsAccounts { get; set; }
    }
}
