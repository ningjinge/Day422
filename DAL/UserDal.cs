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
        //登陆
        public int zuce(user1 m)
        {
            return (int)DBHelper.ExecuteScalar(string.Format("select * from user1 where uname='{0}',upwd='{1}'", m.uname, m.upwd));
        }
        //用户详情
        public List<user1> Theuserdetails()
        {
            return DBHelper.GetToList<user1>("select * from user1");
        }
        //食品列表
        public List<lfood> Listoffood()
        {
            return DBHelper.GetToList<lfood>("select * from lfood");
        }
        //订单详情
        public List<oderFill> Themenufordetails()
        {
            return DBHelper.GetToList<oderFill>("select * from oderFill");
        }
        //订单表反填
        public oderFill Themenufordetailss(int id)
        {
            return DBHelper.GetToList<oderFill>("select * from oderFill where oderfid="+id)[0];
        }
        //退订
        public int Deletetheorder(int id)
        {
            return DBHelper.ExecuteNonQuery(string.Format("delete from oreder  where oid='{0}'", id));
        }
        //修改订单
        public int modifyorder(oderFill m)
        {
            return DBHelper.ExecuteNonQuery(string.Format("update oderFill set ofid='{0}',owid='{1}',ownu='{2}',odermoney='{3}' where oderfid='{4}'", m.ofid,m.owid,m.ownum,m.odermoney,m.oderfid));
        }
        //修改座位
        public int Modifytheseat(desk1 m)
        {
            return DBHelper.ExecuteNonQuery(string.Format("update desk1 set dewid='{0}',deg='{1}',det='{2}',def='{3}' where deid='{4}'",m.dewid,m.deg,m.det,m.def,m.deid));
        }
        //注册
        public int Uadd(user1 u)
        {
            string sql = string.Format("insert into user1 values('{0}','{1}','1')", u.uname, u.upwd);
            return DBHelper.ExecuteNonQuery(sql);
        }
        //桌位列表
        public List<desk1> Dshoe()
        {
            string sql = "select * from desk1 a join desk2 b on a.dewid = b.wid join desk4 c on c.tid = a.det";
            return DBHelper.GetToList<desk1>(sql);
        }
        //菜单类别，查询
        public List<lfood> Fshow(string name, int fid)
        {
            string sql = "select * from desk1 a join desk2 b on a.dewid=b.wid join desk4 c on c.tid=a.det where 1=1";
            if (string.IsNullOrEmpty(name))
            {
                sql += " and fname like '%" + name + "%'";
            }
            else if (fid != 0)
            {
                sql += " and fotid=" + fid;
            }
            return DBHelper.GetToList<lfood>(sql);
        }
        //添加订单
        public int Oadd(oreder o)
        {
            string sql = string.Format("insert into oreder values('{0}','{1}','{2}')", o.ooid, o.odertime, o.ouid);
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
