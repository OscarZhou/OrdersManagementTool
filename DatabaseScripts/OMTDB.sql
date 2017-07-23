use master 
go

if exists(select * from sysdatabases where name = 'OMTDB')
drop database OMTDB
go

create database OMTDB
on primary
(
	name='OMTDB_data.mdf',
	filename='C:\Work&Study\DB\OMTDB_data.mdf',
	size=50MB,
	filegrowth=30MB
)
log on
(
	name='OMTDB_log.ldf',
	filename='C:\Work&Study\DB\OMTDB_log.ldf',
	size=10MB,
	filegrowth=5MB
)
go


-- Create UserInfo table 
use OMTDB
go

if exists(select * from sysobjects where name = 'UserInfo')
drop table UserInfo
go

create table UserInfo
(
	UserNo int identity(1,1) primary key,
	UserName varchar(30) not null,
	PhoneNumber varchar(20) not null,
	UserAddress varchar(500) not null,
	CardNo varchar(30),
	CreateTime datetime
)
go


-- create check constraints
--if exists(select * from sysobjects where name='ck_PhoneNumber')
--alter table UserInfo drop constraint ck_PhoneNumber
--alter table UserInfo add constraint ck_PhoneNumber check(len(PHoneNumber)=11)

-- create default constraints
if exists(select * from sysobjects where name='df_Address')
alter table UserInfo drop constraint df_Address
alter table UserInfo add constraint df_Address default('Unknown Address') for UserAddress



-- create Orders table
use OMTDB
go

if exists(select * from sysobjects where name = 'Orders')
drop table Orders
go

create table Orders
(
	Id int identity(1,1),
	OrderNo int not null,
	UserNo int not null,
	ShipmentFee float,
	ProductPrice float,
	Purchaser varchar(30) not null,
	ReceivedStatus bit not null,
	CreateTime datetime
	
)
go

-- create the constraints
-- create the primary constraints

if exists(select * from sysobjects where name='pk_Id')
alter table Orders drop constraint pk_Id
alter table Orders add constraint pk_Id primary key(Id)

-- create unique constraints

if exists(select * from sysobjects where name='uq_OrderNo')
alter table Orders drop constraint uq_OrderNo
alter table Orders add constraint uq_OrderNo unique(OrderNo)

-- create a foreign key
if exists(select * from sysobjects where name='fk_UserNo')
alter table Orders drop constraint fk_UserNo
alter table Orders add constraint  fk_UserNo foreign key (UserNo) references UserInfo(UserNo)


-- create ItemList table 
use OMTDB
go

if exists(select * from sysobjects where name='ItemList')
drop table ItemList
go

create table ItemList
(
	ItemNo int identity(1, 1) primary key,
	ItemDescription varchar(200) not null,
	Quantity int not null,
	Price float,
	OrderNo int not null,
	CreateTime datetime
)
go

-- create a foreign key
if exists(select * from sysobjects where name='fk_OrderNo')
alter table ItemList drop constraint fk_OrderNo
alter table ItemList add constraint fk_OrderNo foreign key (OrderNo) references Orders(OrderNo)


-- create TransactionList table
use OMTDB
go

if exists(select * from sysobjects where name='TransactionList')
drop table TransactionList
go

create table TransactionList
(
	TransactionId int identity(1,1),
	SellingPrice float,
	PurchasePrice float,
	Profit float,
	OrderNo int not null,
	Purchaser varchar(30) not null,
	OrderStatus bit not null,
	CreateTime datetime
)
go

-- create constraints
use OMTDBtest
go

-- create primary key
if exists(select * from sysobjects where name='pk_TransactionId')
alter table TransactionList drop constraint pk_TransactionId
alter table TransactionList add constraint pk_TransactionId primary key (TransactionId)

-- create foreign key

if exists(select * from sysobjects where name='fk_TOrderNo')
alter table TransactionList drop constraint fk_TOrderNo
alter table TransactionList add constraint fk_TOrderNo foreign key (OrderNo) references Orders(OrderNo)
