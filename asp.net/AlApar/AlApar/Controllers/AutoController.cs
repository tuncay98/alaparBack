﻿using AlApar.Classes;
using AlApar.Classes.Auto;
using AlApar.Classes.Common;
using AlApar.Models.Auto;
using AlApar.Models.Auto.View;
using AlApar.Repositories.Auto;
using AlApar.Repositories.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlApar.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class AutoController : ControllerBase, ICommonController<ViewAutoAds, Form, Name>
    {
        private readonly IAutoCrud _crud;
        private readonly IUtility _utility;
        private readonly AutoContext db;

        private readonly IWebHostEnvironment _webHostEnvironment;
        public AutoController(IAutoCrud autoCrud, AutoContext _db, IUtility utility, IWebHostEnvironment webHostEnvironment)
        {
            _crud = autoCrud;
            _utility = utility;
            db = _db;
            _webHostEnvironment = webHostEnvironment;
        }

        [Route("Form")]
        [HttpGet]
        public async Task<object> getForm()
        {
            return await _crud.getForm(db);
        }

        [Route("Filter")]
        [HttpGet]
        public async Task<object> getFilter()
        {
            return await _crud.getForm(db);
        }

        [Route("Image")]
        [HttpPost]
        [Produces("application/json")]
        [Consumes("multipart/form-data")]
        public async Task<object> getImage(IFormFile images)
        {
            return await _crud.saveTempImage(images, _utility, _webHostEnvironment) ?? NotFound();
        }

        [Route("Image")]
        [HttpDelete]
        public async Task<OkResult> deleteImage([FromBody] Name name)
        {
            await _crud.deleteTempImage(name.name, _utility, _webHostEnvironment);

            return Ok();
        }


        [Route("Add")]
        [HttpPost]
        public async Task<IActionResult> addToDb([FromBody] Form form)
        {
            Func<AutoAds, AutoContacts, AutoAdLogs, Form, Task> action = async (auto, contact, logs, form) =>
                 auto.Title = $"{(await db.AutoMarks.FindAsync(form.MarkId)).Name} {(await db.AutoModels.FindAsync(form.ModelId)).Name}";

            await _crud.addToDb(form, db, _utility, _webHostEnvironment, action);

            return Ok();
        }

        [Route("getAll")]
        public async Task<IEnumerable<ViewAutoAds>> getAll()
        {
            return await db.ViewAutoAds.AsNoTracking().ToListAsync();
        }

        [Route("get/{id}")]
        public async Task<ViewAutoAds> getOne(int id)
        {
            return await _crud.getPersonalAd(id, db);
        }

        private Func<AutoContext, int?, int, int, IAsyncEnumerable<ViewAutoAds>> query = EF.CompileAsyncQuery((AutoContext db, int? id, int skip, int take) => db.ViewAutoAds.Include(w => w.Images).AsNoTracking().Where(w => w.MarkId == id).OrderBy(w => w.ModifiedDate).Skip(skip).Take(take));

        [Route("Search")]
        public async Task<object> postFilter([FromBody] Form res, [FromQuery] int s, [FromQuery] int t)
        {
            return await _crud.PostFilter(res, db, "MarkId", s, t, _utility, query);
        }
    }


}
