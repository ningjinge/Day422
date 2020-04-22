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
        // GET: api/Desk
        public IEnumerable<desk1> Get()
        {
            return dal.Dshoe();
        }
      

        // PUT: api/Order/5
        public int Put([FromBody]desk1 value)
        {
            return dal.Modifytheseat(value);
        }
    }
}
