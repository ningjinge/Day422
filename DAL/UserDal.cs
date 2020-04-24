using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAMODEL;

namespace DAL
{
    public class UserDal
    {
        //
        //登陆
        public int Login(Users users)
        {
            return (int)DBHelper.ExecuteScalar(string.Format("select * from Users where Uname='{0}' and Upwd='{1}'",users.Uname,users.Upwd));
        }
         //注册
        public int Register(Users users)
        {      
            return DBHelper.ExecuteNonQuery(string.Format("insert into Users  values('{0}','{1}','1')",users.Uname,users.Upwd));
        }
         //用户详情
        public Users Userdetails(int uid)
        {
            return DBHelper.GetToList<Users>("select * from Users where Uid="+uid)[0];
        }
        //桌位列表
        public List<Dining> DiningDetails()
        {
            return DBHelper.GetToList<Dining>("select * from Dining a join Area b on a.Daid=b.Aid join State c on a.Dsid=c.Sid");
        }
        //桌位详情
        public Dining DiningList(int did)
        {
            return DBHelper.GetToList<Dining>("select * from Dining a join Area b on a.Daid=b.Aid join State c on a.Dsid=c.Sid where a.Did="+did)[0];
        }
        //菜单类别，查询
        public List<Menu> MenuList(string name, int fid)
        {
            string sql = "select * from Menu a join Foodtype b on a.Mfid=b.Fid where 1=1";
            if (string.IsNullOrEmpty(name))
            {
                sql += " and Mname like '%" + name + "%'";
            }
            else if (fid != 0)
            {
                sql += " and Mfid=" + fid;
            }
            return DBHelper.GetToList<Menu>(sql);
        }
        //菜单详情
        public Menu MenuDetails(int mid)
        {
            return DBHelper.GetToList<Menu>("select * from Menu where Mid="+mid)[0];
        }
        //点餐
        public int LineitemAdd(Lineitem lineitem)
        {
            return DBHelper.ExecuteNonQuery(string.Format("insert into Lineitem values ('{0}','{1}','{2}','{3}',0)",lineitem.Ltmid,lineitem.Lttid,lineitem.Ltnum,lineitem.Ltmoney));
        } 
        //添加订单
        public int OrderAdd(Orderfood orderfood)
        {
            orderfood.Onumber=DateTime.Now.ToString("yyyyMMddhhmmsss");
            return DBHelper.ExecuteNonQuery(string.Format("insert into Orderfood values('{0}','{1}','{2}')",orderfood.Onumber,orderfood.Odate,orderfood.Ouid));
        }
        //生成订单
        public int Lineitem(int oid)
        {
            return DBHelper.ExecuteNonQuery("update Lineitem set Ltoid="+oid);
        }
        //订单表列表
        public List<Orderfood> OrderList()
        {
            return DBHelper.GetToList<Orderfood>("select * from Orderfood");
        }
        //订单详情表列表
        public List<Lineitem> lineitemList()
        {
            return DBHelper.GetToList<Lineitem>("select * from Lineitem");
        }
        //删除订单详情
        public int lineitemDel(int lid)
        {
            return DBHelper.ExecuteNonQuery("delete from Lineitem where Ltid="+lid);
        }
        //删除订单
        public int OrderDel(int oid)
        {
             return DBHelper.ExecuteNonQuery("delete from Orderfood where Ouid="+oid);
        }
    }
}
