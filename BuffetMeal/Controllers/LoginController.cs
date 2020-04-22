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
    public class LoginController : ApiController
    {
        UserDal dal = new UserDal();
        //登陆
        public int Post([FromBody] user1 u)
        {
            return dal.zuce(u);
        }
    }
}
