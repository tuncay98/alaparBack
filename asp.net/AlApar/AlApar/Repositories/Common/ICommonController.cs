﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using OkResult = Microsoft.AspNetCore.Mvc.OkResult;

namespace AlApar.Repositories.Common
{
    /// <summary>
    /// V is View, F is Form, M is Name class for image
    /// </summary>
    /// <typeparam name="V"></typeparam>
    /// <typeparam name="F"></typeparam>
    /// <typeparam name="M"></typeparam>
    interface ICommonController<V, F, M>
    {
        public Task<IEnumerable<V>> getAll();
        public Task<V> getOne(int id);
        public Task<object> getFilter();
        public Task<object> getForm();
        public Task<object> getImage(IFormFile images);
        public Task<OkResult> deleteImage([FromBody] M name);
        public Task<object> postFilter([FromBody] F res, [FromQuery] int s, [FromQuery] int t);
        public Task<IActionResult> addToDb([FromBody] F form);
    }
}
