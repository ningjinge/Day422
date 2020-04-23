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
    public class DeskController : ApiController
    {
        UserDal dal = new UserDal();
        // GET: api/Desk0
        //桌子列表
        public IEnumerable<Dining> Get()
        {
            return dal.DiningDetails() ;
        }

        // GET: api/Desk/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Desk
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Desk/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Desk/5
        public void Delete(int id)
        {
        }
    }
}
