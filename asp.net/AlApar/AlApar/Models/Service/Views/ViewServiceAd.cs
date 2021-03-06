﻿using AlApar.Classes;
using System;
using System.Collections.Generic;

#nullable disable

namespace AlApar.Models.Service.Views
{
    public partial class ViewServiceAd : TView<ServicePhoto>
    {
        public long Id { get; set; }
        public int? Viewed { get; set; }
        public string About { get; set; }
        public int? CategoryId { get; set; }
        public string Title { get; set; }
        public bool? IsNew { get; set; }
        public bool? HasDelivery { get; set; }
        public double? Price { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int? AdId { get; set; }
        public int? PrimaryImage { get; set; }
        public string Thumbnail { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ContactNumber { get; set; }
        public bool? IsCall { get; set; }
        public bool? IsWp { get; set; }
        public string Email { get; set; }
        public string ContactName { get; set; }
        public string CategoryName { get; set; }
        public string PackageName { get; set; }
        public string CurrencyName { get; set; }
        public string StatusName { get; set; }
        public string CityName { get; set; }

        public int? LogId { get; set; }
        public int? StatusId { get; set; }
        public int? PackageId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CityId { get; set; }
        public int? ContactId { get; set; }
        public int? TypeId { get; set; }

        public virtual ICollection<ServicePhoto> Images { get; set; }

    }
}
