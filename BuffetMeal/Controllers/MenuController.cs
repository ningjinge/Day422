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
    public class MenuController : ApiController
    {
        UserDal dal = new UserDal();
        //显示菜单列表。
        // GET: api/Menu
        public IEnumerable<Menu> Get(string name ,int fid)
        {
            return dal.MenuList(name,fid); ;
        }

        // GET: api/Menu/5
        public Menu Get(int id)
        {
            return dal.MenuDetails(id);
        }

        // POST: api/Menu
        //
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Menu/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Menu/5
        public void Delete(int id)
        {
        }
    }
}
