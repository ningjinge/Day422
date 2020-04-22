--创建点餐系统数据库
create database OrderSystems
go
use OrderSystems
--用户表
create table Users                 
(
    Uid     int   primary key identity, --用户id
	Uname   varchar(20),	            --用户名
	Upwd	varchar(50),                --密码
	Ulid    int,			            --用户等级
)

insert into Users  values('张三','000','1')
insert into Users  values('李四','001','2')
insert into Users  values('王五','010','1')
insert into Users  values('赵柳','111','2')
insert into Users  values('老顾','101','1')
insert into Users  values('王柳','123','2')
insert into Users  values('小珊','254','1')
insert into Users  values('李卓','852','2')
insert into Users  values('冬雪','741','1')
insert into Users  values('王佳','521','2')
select * from Users 

--用户等级
create  table Userlevel            
(
    Lid     int primary key identity,   	 --用户等级id
	Lname   varchar(20),		 --普通用户   会员用户
)
insert into Userlevel values('会员用户')
insert into Userlevel values('普通用户')
select * from Userlevel
--厨师表
create  table Chef                  
(
    Cid     int   primary key identity,		 --厨师id
	Cname   varchar(20),			 --厨师姓名
)
insert into Chef values('瑞秋')
insert into Chef values('帕克')
insert into Chef values('保拉')
insert into Chef values('里奥')
insert into Chef values('艾伦')
insert into Chef values('托得')
insert into Chef values('刘一凡')
insert into Chef values('江镇城')
insert into Chef values('陈岚舒')
insert into Chef values('陈宝明')
select * from Chef
--服务员表
create table Waiter                      
(   
    Wid     int primary key identity,        --服务员id
	Wname   varchar(20),	        --服务员姓名
)
insert into Waiter values('郭文秀')
insert into Waiter values('朱陈志')
insert into Waiter  values('孙振林')
insert into Waiter values('胡海飞')
insert into Waiter values('高振琪')
insert into Waiter values('杨贯一')
insert into Waiter values('王婷之')
insert into Waiter values('戴龙')
insert into Waiter values('铁艺花')
insert into Waiter values('赵泽伟')
select * from Waiter
--座位表
create table Dining                  
(
    Did     int primary key identity,		  --座位id
	Daid    int,					          --座位位置
	Dspec   varchar(50),					  --座位规格(双人桌 四人桌)
	Dsid    int,					          --座位状态(0是可用，1是不可用)
	Dwid    int 			                  --座位服务员
)			
insert into Dining values('1','双人桌','0','1')
insert into Dining values('1','双人桌','0','2')
insert into Dining values('1','四人桌','0','3')
insert into Dining values('1','四人桌','0','4')
insert into Dining values('2','四人桌','0','5')
insert into Dining values('2','四人桌','0','6')
insert into Dining values('2','四人桌','0','7')
insert into Dining values('2','双人桌','0','8')
insert into Dining values('3','双人桌','0','9')
insert into Dining values('3','双人桌','0','10')


select * from Dining


--桌位位置
create table Area                  
(
    Aid     int primary key identity,--区域id
	Aname   varchar(20),--一楼大厅，二楼卡座，三楼包间
)
insert into Area values('二楼卡座')
insert into Area values('一楼大厅')
insert into Area values('三楼包间')

select *from Area

--桌位状态
create table State                 
(
    Sid     int primary key identity ,--状态id
	Sname   varchar(20),-- 空，预定。已满
)
insert into State values('预定')
insert into State values('空')
insert into State values('已满')

select * from State
--菜表
create table Menu                 
( 
    Mid     int primary key identity , --菜id
	Mname   varchar(20),			   --名称
	Mphoto  varchar(max),			   --图片
	Mprice  money,					   --价格
	Mcid    int, --厨师id
	Typeid		int,--菜的类型外键。
)
insert into Menu values('鱼香肉丝','./图片/1.jpg','20','1','2')
insert into Menu values('宫保鸡丁','./图片/2.jpg','28','2','2')
insert into Menu values('酸辣土豆丝','./图片/3.jpg','15','3','2')
insert into Menu values('骨肉相连','./图片/4.jpg','22','4','5')
insert into Menu values('玉米汤','./图片/5.jpg','24','5','3')
insert into Menu values('蛋花汤','./图片/6.jpg','18','6','3')
insert into Menu values('椒盐蘑菇','./图片/7.jpg','21','7','2')
insert into Menu values('兰州拉面','./图片/8.jpg','14','8','4')
insert into Menu values('拍黄瓜','./图片/9.jpg','30','9','1')
insert into Menu values('绿豆糕','./图片/10.jpg','10','10','5')
select * from Menu
--菜类型
create table Foodtype
(
	Fid      int primary key identity,--菜类型id
	Fname		varchar(50),--菜类型
) 
insert into Foodtype values('冷菜')
insert into Foodtype values('热菜')
insert into Foodtype values('汤品')
insert into Foodtype values('主食')
insert into Foodtype values('其他')
select * from Foodtype
--订单表
create table Orderfood
(
    Oid			    int primary key identity,--订单id	
	Onumber	        varchar(50),--订单号
	Odate		datetime,--订餐日期
	Ouid            int,--订餐人id
)
insert into Orderfood values('el00001','2019-04-20 13:05:23','1')
insert into Orderfood values('el00002','2019-03-22 16:08:25','2')
insert into Orderfood values('el00003','2019-01-12 08:05:15','3')
insert into Orderfood values('el00004','2019-04-22 10:18:26','4')
insert into Orderfood values('el00005','2019-02-20 20:05:48','5')
select *from Orderfood

--订单详情表
create table Lineitem
(
	Ltid		int primary key identity,--订单详情id
	Ltmid		int,--菜名id
	Lttid		int ,--订餐口味id
	Ltnum		int ,--数量
	Ltmoney     money,--订餐金额
	Ltoid       int  --订单id
)
insert into Lineitem values (1,1,1,'20',1)
insert into Lineitem values (2,2,2,'56',2)
insert into Lineitem values (3,3,2,'30',3)
insert into Lineitem values (4,1,1,'22',4)
insert into Lineitem values (5,2,2,'40',5)

select * from Lineitem


--订单口味表
create  table Taste
(
    Tid    int primary key identity ,--口味id
	Tiname  varchar(20) --口味类型（清淡，微辣，变态辣）
	
)
insert into Taste values('微辣')
insert into Taste values('变态辣')
insert into Taste values('清淡')

select * from Taste

