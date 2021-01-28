﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluatorRiscuri.Models
{
    public struct FormItem
    {
        public string Question { get; set; }
        public string[] Options { get; set; }
        public int Weight { get; set; }
    }
}
