﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlApar.Models.Bina
{
    public class BinaTargetPoints
    {
        public BinaTargetPoints() {

            BinaAdsPersonals = new HashSet<BinaAdsPersonal>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CityId { get; set; }

        public virtual ICollection<BinaAdsPersonal> BinaAdsPersonals { get; set; }
        public virtual Cities City { get; set; }
    }
}
