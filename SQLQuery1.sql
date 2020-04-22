--�������ϵͳ���ݿ�
create database OrderSystems
go
use OrderSystems
--�û���
create table Users                 
(
    Uid     int   primary key identity, --�û�id
	Uname   varchar(20),	            --�û���
	Upwd	varchar(50),                --����
	Ulid    int,			            --�û��ȼ�
)

insert into Users  values('����','000','1')
insert into Users  values('����','001','2')
insert into Users  values('����','010','1')
insert into Users  values('����','111','2')
insert into Users  values('�Ϲ�','101','1')
insert into Users  values('����','123','2')
insert into Users  values('Сɺ','254','1')
insert into Users  values('��׿','852','2')
insert into Users  values('��ѩ','741','1')
insert into Users  values('����','521','2')
select * from Users 

--�û��ȼ�
create  table Userlevel            
(
    Lid     int primary key identity,   	 --�û��ȼ�id
	Lname   varchar(20),		 --��ͨ�û�   ��Ա�û�
)
insert into Userlevel values('��Ա�û�')
insert into Userlevel values('��ͨ�û�')
select * from Userlevel
--��ʦ��
create  table Chef                  
(
    Cid     int   primary key identity,		 --��ʦid
	Cname   varchar(20),			 --��ʦ����
)
insert into Chef values('����')
insert into Chef values('����')
insert into Chef values('����')
insert into Chef values('���')
insert into Chef values('����')
insert into Chef values('�е�')
insert into Chef values('��һ��')
insert into Chef values('�����')
insert into Chef values('�����')
insert into Chef values('�±���')
select * from Chef
--����Ա��
create table Waiter                      
(   
    Wid     int primary key identity,        --����Աid
	Wname   varchar(20),	        --����Ա����
)
insert into Waiter values('������')
insert into Waiter values('���־')
insert into Waiter  values('������')
insert into Waiter values('������')
insert into Waiter values('������')
insert into Waiter values('���һ')
insert into Waiter values('����֮')
insert into Waiter values('����')
insert into Waiter values('���ջ�')
insert into Waiter values('����ΰ')
select * from Waiter
--��λ��
create table Dining                  
(
    Did     int primary key identity,		  --��λid
	Daid    int,					          --��λλ��
	Dspec   varchar(50),					  --��λ���(˫���� ������)
	Dsid    int,					          --��λ״̬(0�ǿ��ã�1�ǲ�����)
	Dwid    int 			                  --��λ����Ա
)			
insert into Dining values('1','˫����','0','1')
insert into Dining values('1','˫����','0','2')
insert into Dining values('1','������','0','3')
insert into Dining values('1','������','0','4')
insert into Dining values('2','������','0','5')
insert into Dining values('2','������','0','6')
insert into Dining values('2','������','0','7')
insert into Dining values('2','˫����','0','8')
insert into Dining values('3','˫����','0','9')
insert into Dining values('3','˫����','0','10')


select * from Dining


--��λλ��
create table Area                  
(
    Aid     int primary key identity,--����id
	Aname   varchar(20),--һ¥��������¥��������¥����
)
insert into Area values('��¥����')
insert into Area values('һ¥����')
insert into Area values('��¥����')

select *from Area

--��λ״̬
create table State                 
(
    Sid     int primary key identity ,--״̬id
	Sname   varchar(20),-- �գ�Ԥ��������
)
insert into State values('Ԥ��')
insert into State values('��')
insert into State values('����')

select * from State
--�˱�
create table Menu                 
( 
    Mid     int primary key identity , --��id
	Mname   varchar(20),			   --����
	Mphoto  varchar(max),			   --ͼƬ
	Mprice  money,					   --�۸�
	Mcid    int, --��ʦid
	Typeid		int,--�˵����������
)
insert into Menu values('������˿','./ͼƬ/1.jpg','20','1','2')
insert into Menu values('��������','./ͼƬ/2.jpg','28','2','2')
insert into Menu values('��������˿','./ͼƬ/3.jpg','15','3','2')
insert into Menu values('��������','./ͼƬ/4.jpg','22','4','5')
insert into Menu values('������','./ͼƬ/5.jpg','24','5','3')
insert into Menu values('������','./ͼƬ/6.jpg','18','6','3')
insert into Menu values('����Ģ��','./ͼƬ/7.jpg','21','7','2')
insert into Menu values('��������','./ͼƬ/8.jpg','14','8','4')
insert into Menu values('�Ļƹ�','./ͼƬ/9.jpg','30','9','1')
insert into Menu values('�̶���','./ͼƬ/10.jpg','10','10','5')
select * from Menu
--������
create table Foodtype
(
	Fid      int primary key identity,--������id
	Fname		varchar(50),--������
) 
insert into Foodtype values('���')
insert into Foodtype values('�Ȳ�')
insert into Foodtype values('��Ʒ')
insert into Foodtype values('��ʳ')
insert into Foodtype values('����')
select * from Foodtype
--������
create table Orderfood
(
    Oid			    int primary key identity,--����id	
	Onumber	        varchar(50),--������
	Odate		datetime,--��������
	Ouid            int,--������id
)
insert into Orderfood values('el00001','2019-04-20 13:05:23','1')
insert into Orderfood values('el00002','2019-03-22 16:08:25','2')
insert into Orderfood values('el00003','2019-01-12 08:05:15','3')
insert into Orderfood values('el00004','2019-04-22 10:18:26','4')
insert into Orderfood values('el00005','2019-02-20 20:05:48','5')
select *from Orderfood

--���������
create table Lineitem
(
	Ltid		int primary key identity,--��������id
	Ltmid		int,--����id
	Lttid		int ,--���Ϳ�ζid
	Ltnum		int ,--����
	Ltmoney     money,--���ͽ��
	Ltoid       int  --����id
)
insert into Lineitem values (1,1,1,'20',1)
insert into Lineitem values (2,2,2,'56',2)
insert into Lineitem values (3,3,2,'30',3)
insert into Lineitem values (4,1,1,'22',4)
insert into Lineitem values (5,2,2,'40',5)

select * from Lineitem


--������ζ��
create  table Taste
(
    Tid    int primary key identity ,--��ζid
	Tiname  varchar(20) --��ζ���ͣ��嵭��΢������̬����
	
)
insert into Taste values('΢��')
insert into Taste values('��̬��')
insert into Taste values('�嵭')

select * from Taste

