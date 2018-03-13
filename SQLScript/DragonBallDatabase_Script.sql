use master 
go

if exists(select * from sys.databases where name = 'Dragon_Ball_Matching')
begin
	alter database [Dragon_Ball_Matching] set single_user with rollback immediate
	drop database Dragon_Ball_Matching
	print 'Deleting already existing database'
end
go
	

if not exists(select * from sys.databases where name = 'Dragon_Ball_Matching')
begin	
	print 'Creating database Dragon_Ball_Matching'
	Create database [Dragon_Ball_Matching]
end
else

begin
	print 'Database Dragon_Ball_Matching already exists'
end
go

alter database [Dragon_Ball_Matching] set multi_user
go

use Dragon_Ball_Matching
go

if exists(select * from information_schema.tables where table_name = 'AreaTable')
begin
	print 'Dropping table AreaTable'
	drop table AreaTable
end
go
	print 'Creating table AreaTable'
 go
Create table AreaTable
(
	AreaID int primary key identity(1,1) not null, 
	Area nvarchar(50)
)
go


if exists(select * from information_schema.tables where table_name = 'SexTable')
begin
	print 'Dropping table SexTable'
	drop table SexTable
end
go
	print 'Creating table SexTable'
 go
Create table SexTable
(
	SexID int primary key identity (1,1),
	Sex char not null
)
go

if exists(select * from information_schema.tables where table_name = 'UsersTable')
begin
	print 'Dropping table UsersTable'
	drop table UsersTable
end
go
	print 'Creating table UsersTable'
 go
Create table UsersTable
(
	UserID int primary key identity(1,1) not null,
	FirstName nvarchar(30) not null,
	LastName nvarchar(30) not null,
	Birthday datetime not null,
	StartDate datetime not null,
	EndDate datetime,
	ShortStory nvarchar(100),	
	Sex_FK int foreign key references SexTable(SexID) not null,	
	Area_FK int foreign key references AreaTable(AreaID) not null,	
)
go


if exists(select * from information_schema.tables where table_name = 'LogonTable')
begin
	print 'Dropping table LogonTable'
	drop table LogonTable
end
go
	print 'Creating table LogonTable'
 go
Create table LogonTable
(
	UserID int foreign key references UsersTable(UserID) not null,
	Username nvarchar(30) unique not null,
	PWD nvarchar(40) not null	
)
go


if exists(select * from information_schema.tables where table_name = 'LikesTable')
begin
	print 'Dropping table LikesTable'
	drop table LikesTable
end
go
	print 'Creating table LikesTable'
 go
Create table LikesTable
(
	Sender nvarchar(30) foreign key references LogonTable(Username) not null,
	reciever nvarchar(30) foreign key references LogonTable(Username) not null,
	IsRead bit,  
	Constraint PK_Sender_Reciever Primary key (Sender,Reciever) 	
)


if exists(select * from information_schema.tables where table_name = 'MessagesTable')
begin
	print 'Dropping table MessagesTable'
	drop table MessagesTable
end
go
	print 'Creating table MessagesTable'
 go
Create table MessagesTable
(
	Messages nvarchar(max),
	Sender_message nvarchar(30) foreign key references LogonTable(Username) not null,
	reciever_message nvarchar(30) foreign key references LogonTable(Username) not null,
	IsRead_message bit,  
	StartDate_message datetime not null,
	Constraint PK_Sender_Reciever_message Primary key (Sender_message,Reciever_message) 	
)
go


use Dragon_Ball_Matching
go

if exists(select * from information_schema.tables where table_name = 'ImagesTable')
begin
	print 'Dropping table ImagesTable'
	drop table ImagesTable
end
go
	print 'Creating table ImagesTable'
 go
Create table ImagesTable
(
	ImageID int foreign key references UsersTable(UserID),
	Images image	
)
go

use Dragon_Ball_Matching
go


--Testing, delete this table when done!

create table testtable (tableID int primary key identity(1,1), tableName1 nvarchar(20), tableName2 nvarchar(20))
go


insert into testtable values ( 'john', 'fido' )
insert into testtable values ( 'else', 'gunner' )
insert into testtable values ( 'sømand svend', 'svede hans' )

insert into AreaTable values ( 'Region Hovedstaden')
insert into AreaTable values ( 'Region Midtjylland')
insert into AreaTable values ( 'Region Syddanmark')
insert into AreaTable values ( 'Region Nordjylland')
insert into AreaTable values ( 'Region Sjælland')

select * from testtable

select * from testtable