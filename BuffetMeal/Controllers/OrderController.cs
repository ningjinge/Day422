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
        //订单详情页面
        public IEnumerable<oderFill> Get()
        {
            return dal.Themenufordetails();
        }
        //订单详情反填
        // GET: api/Order/5
        public oderFill Get(int id)
        {
            return dal.Themenufordetailss(id);
        }
        //订单添加
        // POST: api/Order
        public int Post([FromBody]oreder value)
        {
            return dal.Oadd(value);
        }
        //订单详情修改
        // PUT: api/Order/5
        public int Put([FromBody]oderFill value)
        {
            return dal.modifyorder(value);
        }
        //退订单
        // DELETE: api/Order/5
        public int Delete(int id)
        {
            return dal.Deletetheorder(id);
        }
    }
}
