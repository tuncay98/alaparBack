﻿using AlApar.Classes;
using System;
using System.Collections.Generic;

#nullable disable

namespace AlApar.Models.Private.View
{
    public partial class ViewPrivateAd : TView<PrivatePhoto>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string StatusName { get; set; }
        public string CategoryName { get; set; }
        public int? Viewed { get; set; }
        public int? CategoryId { get; set; }
        public string CurrencyName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string TypeName { get; set; }
        public string ClothesTypeName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public bool? IsWp { get; set; }
        public bool? IsCall { get; set; }
        public string ContactNumber { get; set; }
        public string ClothesGenderName { get; set; }
        public string About { get; set; }
        public double? Price { get; set; }
        public string Title { get; set; }
        public bool? HasDelivery { get; set; }
        public bool? IsNew { get; set; }

        public int? LogId { get; set; }
        public int? StatusId { get; set; }
        public int? PackageId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CityId { get; set; }
        public int? ContactId { get; set; }
        public int? TypeId { get; set; }
        public int? ClothesTypeId { get; set; }
        public int? ClothesGenderId { get; set; }

        public virtual ICollection<PrivatePhoto> Images { get; set; }

    }
}
