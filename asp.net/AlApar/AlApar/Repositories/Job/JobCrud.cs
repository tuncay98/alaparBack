﻿using AlApar.Classes.Job;
using AlApar.Models.Job;
using AlApar.Models.Job.Views;
using AlApar.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlApar.Repositories.Job
{
    public class JobCrud : Common<ViewJobAds, JobContext, Form, JobAd, JobLog, JobContact, JobEmployeePhoto>, IJobCrud
    {
        public override string TempFolder => "images/job/temporarily";
        public override string MainFolder => "images/job/personal";

        public override async Task<object> getForm(JobContext db)
        {
            var types = await db.JobAdTypes.AsNoTracking().ToListAsync();
            var categories = await db.JobCategories.AsNoTracking().ToListAsync();
            var educations = await db.JobEducations.AsNoTracking().ToListAsync();
            var practices = await db.JobPracticeDurations.AsNoTracking().ToListAsync();
            var cities = await db.Cities.AsNoTracking().ToListAsync();
            var sharedDate = await db.LastSharedTimes.AsNoTracking().ToListAsync();

            return new { 
                types,
                categories,
                educations,
                practices,
                cities,
                sharedDate,
            };
        }

        public override async Task<ViewJobAds> getPersonalAd(int id, JobContext db)
        {
            return await db.ViewJobAds.Include(w => w.Images).AsNoTracking().FirstOrDefaultAsync(w => w.Id == id);
        }
    }
}