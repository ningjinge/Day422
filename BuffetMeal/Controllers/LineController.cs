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
    public class LineController : ApiController
    {
        UserDal dal = new UserDal();
        // GET: api/Line
        //显示订单详情。
        public IEnumerable<Lineitem> Get()
        {
            return dal.lineitemList();
        }

        // GET: api/Line/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Line
        //点餐。
        public int Post([FromBody]Lineitem value)
        {
            return dal.LineitemAdd(value);
        }

        // PUT: api/Line/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Line/5
        //删除订单详情。
        public int  Delete(int id)
        {
            return dal.lineitemDel(id);
        }
    }
}
