﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet
{
    internal class StokKontrol
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
