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
    public class OrderController : ApiController
    {
        UserDal dal = new UserDal();
        // GET: api/Order
        public IEnumerable<oderFill> Get()
        {
            return dal.Themenufordetails();
        }

        // GET: api/Order/5
        public oderFill Get(int id)
        {
            return dal.Themenufordetailss(id);
        }

        // POST: api/Order
        public int Post([FromBody]oreder value)
        {
            return dal.Oadd(value);
        }

        // PUT: api/Order/5
        public int Put([FromBody]oderFill value)
        {
            return dal.modifyorder(value);
        }

        // DELETE: api/Order/5
        public int Delete(int id)
        {
            return dal.Deletetheorder(id);
        }
    }
}
