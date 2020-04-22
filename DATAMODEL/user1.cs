using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAMODEL
{
    //用户表
    public class Users
    {
        //用户id
        public int Uid   { get; set; }
        //用户名
        public string Uname { get; set; }
        //用户密码
        public string Upwd   { get; set; }
        //用户等级
        public int Ulid { get; set; }
        //等级id
        public int Lid { get; set; }
        //等级名称
        public string Lname { get; set; }
    }
    //座位表
    public class desk1
    {
        //服务员id
        public int Wid { get; set; }
        //服务员名字
        public string Wname { get; set; }
        //桌位id
        public int Did   { get; set; }
        //桌位位置
        public int Daid  { get; set; }
        //桌位规格
        public string Dspec   { get; set; }
        //桌位状态
        public int Dsid    { get; set; }
        //服务员id外键
        public int Dwid { get; set; }
        //区域id
        public int Aid { get; set; }
        //区域名称
        public string Aname { get; set; }
        //状态id
        public int Sid { get; set; }
        //桌位状态
        public string Sname { get; set; }
    }
    //菜表
    public class lfood 
    {
        //厨师id
        public int Cid { get; set; }
        //厨师名称
        public string Cname { get; set; }
        //菜名id
        public int Mid    { get; set; }
        //菜名
        public string Mname  { get; set; }
        //菜图
        public string Mphoto { get; set; }
        //菜单价
        public decimal Mprice { get; set; }
        //厨师id外键
        public int Mcid { get; set; }
        //菜类型id
        public int Fid { get; set; }
        //菜类型
        public string Fname { get; set; }
    }
    //订单表
    public class oreder
    {
        //订单id
        public int Oid		 { get; set; }
        //订单号
        public string Onumber { get; set; }
        //订单日期
        public DateTime Odate { get; set; }
        //订单人id
        public int Ouid { get; set; }
    }
    //订单详情表
    public class oderFill
    {
        //口味id
        public int Tid { get; set; }
        //口味类型
        public string Tname { get; set; }
        //订单详情id
        public int Ltid		 { get; set; }
        //订单详情菜名
        public int Ltmid { get; set; }
        //订单口味id
        public int Lttid		 { get; set; }
        //订单数量
        public int Ltnum { get; set; }
        //订单金额
        public decimal Ltmoney	 { get; set; }
        //订单id外键
        public int Ltoid { get; set; }
    }
}
