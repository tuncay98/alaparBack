﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlApar.Models.Auto
{
    public class AutoColors
    {
        public AutoColors() {
            AutoAds = new HashSet<AutoAds>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AutoAds> AutoAds { get; set; }
    }
}
