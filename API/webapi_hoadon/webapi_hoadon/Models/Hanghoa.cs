﻿using System;
using System.Collections.Generic;

namespace webapi_hoadon.Models
{
    public partial class Hanghoa
    {
        public Hanghoa()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
        }

        public string Mahang { get; set; } = null!;
        public string? Tenhang { get; set; }
        public string? Dvt { get; set; }
        public double? Dongia { get; set; }

        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
