create database  dormitory;
use dormitory
create table dormemberInfo(
studentnum int not null primary key,
sname char(60),
sex char(20),
profession char(60),
dormitoryBum int not null
)
create table dormitoryNumbe(
dormitoryNum int not null ,
dormitorytype int,
dormmember char (100),
profession char(100),
)
insert into dormemberInfo values (2008,'Ǯ����','Ů','��������ѧ��ҵ��',5002)
insert into dormitoryNumbe values (5002,4,'Ǯ����','��������ѧ��ҵ��')