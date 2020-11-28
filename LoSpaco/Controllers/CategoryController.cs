﻿using LoSpacoWebAPi.DAO;
using LoSpacoWebAPi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace LoSpaco.Controllers
{

    public class CategoryController : ApiController
    {
        [ActionName("GetList")]
        public IEnumerable<Category> GetList()
        {
            return CategoryDAO.GetList();
        }

        [ActionName("GetByName")]
        public Category GetByName(string name)
        {
            return CategoryDAO.GetByName(name);
        }

        [ActionName("GetById")]
        public Category GetById(byte id)
        {
            return CategoryDAO.GetById(id);
        }
     
        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
