﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClub.Model
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Fee { get; set; }
    }
}
