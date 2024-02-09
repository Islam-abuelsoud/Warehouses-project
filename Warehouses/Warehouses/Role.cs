﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouses
{
    internal class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumper { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public List<Transaction> transactions { get; set; }
    }
}