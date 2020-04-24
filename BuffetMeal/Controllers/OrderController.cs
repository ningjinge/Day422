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
        //显示订单列表。
        public IEnumerable<Orderfood> Get()
        {
            return dal.OrderList(); ;
        }

        // GET: api/Order/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Order
        //添加订单
        public int Post([FromBody]Orderfood u)
        {
            return dal.OrderAdd(u);
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Order/5
        //删除订单
        public int Delete(int id)
        {
            return dal.OrderDel(id);
        }
    }
}
