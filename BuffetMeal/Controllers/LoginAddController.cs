using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using DATAMODEL;


namespace BuffetMeal.Controllers
{
    public class LoginAddController : ApiController
    {
        UserDal dal = new UserDal();
        // GET: api/LoginAdd
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LoginAdd/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LoginAdd
        //注册
        public int Post([FromBody] Users u)
        {
            return dal.Register(u);
        }

        // PUT: api/LoginAdd/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LoginAdd/5
        public void Delete(int id)
        {
        }
    }
}
