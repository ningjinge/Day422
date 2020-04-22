using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAMODEL
{
    //用户表
    public class user1
    {
        public int uid   { get; set; }
        public string uname { get; set; }
        public string upwd   { get; set; }
        public int udid { get; set; }
        public int did { get; set; }
        public string dname { get; set; }
    }
    //座位表
    public class desk1
    {
        public int fid { get; set; }
        public string fname { get; set; }
        public int deid   { get; set; }
        public int dewid  { get; set; }
        public string deg    { get; set; }
        public int det    { get; set; }
        public int def { get; set; }
        public int wid { get; set; }
        public string wname { get; set; }
        public int tid { get; set; }
        public string tname { get; set; }
    }
    //菜表
    public class lfood 
    {
        public int cid { get; set; }
        public string cname { get; set; }
        public int fid    { get; set; }
        public string fname  { get; set; }
        public string fphoto { get; set; }
        public decimal fprice { get; set; }
        public int fcid { get; set; }
        public int typeid { get; set; }
        public int ftid { get; set; }
        public string ftname { get; set; }
    }
    //订单表
    public class oreder
    {
        public int oid		 { get; set; }
        public string ooid { get; set; }
        public DateTime odertime { get; set; }
        public int ouid { get; set; }
    }
    //订单详情表
    public class oderFill
    {
        public int weid { get; set; }
        public string weiname { get; set; }
        public int oderfid		 { get; set; }
        public int ofid { get; set; }
        public int owid		 { get; set; }
        public int ownum { get; set; }
        public decimal odermoney	 { get; set; }
        public int oderid { get; set; }
    }
}
