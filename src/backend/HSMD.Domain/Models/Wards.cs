﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Wards
    {
        public int WardId { get; set; }
        public string? Ward_Name { get; set; }
        public string? Ward_Location { get; set; }
        public string? Ward_Description { get; set; }
    }
}
