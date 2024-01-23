﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Domain.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manual { get; set; }
        public string Type { get; set; }
        public virtual List<string> Warnings { get; set; }

        public int Stock { get; set; }
    }
}
