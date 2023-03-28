create database MeterReading;

create table users(users_id int identity(1,1) primary key, emp_code int, emp_name varchar(50),mail varchar(100),password varchar(20), confirmpassword varchar(50),
emp_designation varchar(50),Branch_id int foreign key references Branch(id),
Region_id int foreign key references Region(id),
cluster_id int foreign key references Cluster(id),
RoleId int foreign key references tbl_Role(RoleId));


select * from users;

Create Table tbl_Role (
RoleId int IDENTITY (1,1) PRIMARY KEY NOT NULL,
Role varchar(20) NOT NULL)
 
 insert into tbl_Role(Role) values('BranchManager');

 select * from tbl_Role;

Go
CREATE OR Alter PROCEDURE [dbo].[SP_Register]
(
@emp_code int,@emp_name varchar(50),
@mail varchar(100),@password varchar(20),
@confirmpassword varchar(50),@emp_designation varchar(50),
@Branch_id int,
@Region_id int,
@cluster_id int,
@RoleId int
)
as 
Begin 
insert into users(emp_code,emp_name,mail,password,confirmpassword,emp_designation,Branch_id,Region_id,cluster_id,RoleId)
values			 (@emp_code,@emp_name,@mail,@password,@confirmpassword,@emp_designation,@Branch_id,@Region_id,@cluster_id,@RoleId)
End

drop procedure SP_Register;

create table Branch(id int identity(1,1) primary key,branch_name varchar(50),Region_id int foreign key references Region(id),cluster_id int foreign key references Cluster(id));

create table Region(id int identity(1,1) primary key,region_name varchar(50),cluster_id int foreign key references Cluster(id));

create table Cluster(id int identity(1,1) primary key,cluster_name varchar(50));

insert into Branch(branch_name,Region_id,cluster_id) values ('Amaravati',3,2)

drop table Branch
select * from users;


Go
create or alter procedure [dbo].[EmployeeLogin]  
(  
@mail varchar(100)=NULL,  
@password varchar(20)=NULL
)
as  
begin  
--select mail from users where mail=@mail and password=@password

--select mail, Branch.branch_name from users inner join users.users_id = Branch.id where mail=@mail and password=@password;
select mail,Branch.branch_name  from users
inner join Branch on  users.Branch_id = Branch.id
inner join tbl_Role on users.RoleId = tbl_Role.RoleId where mail=@mail and password=@password;
end  

SELECT * FROM users inner join Branch on  users.Branch_id = Branch.id
inner join tbl_Role on users.RoleId = tbl_Role.RoleId;

create table AddMeters(id int identity(1,1) primary key,
						MeterName1 varchar(50),
						Branch_id int foreign key references Branch(id),
						Region_id int foreign key references Region(id),
						cluster_id int foreign key references Cluster(id));
exec sp_rename 'AddMeters.MeterName' , 'MeterName1','Column';
select * from AddMeters;

Go
CREATE OR Alter PROCEDURE [dbo].[SP_AddMeters]
(
@MeterName1 varchar(50),
@Branch_id int,
@Region_id int,
@cluster_id int
)
as 
Begin 
insert into AddMeters(MeterName1,Branch_id,Region_id,cluster_id)
values			 (@MeterName1,@Branch_id,@Region_id,@cluster_id)
End


Go
create or alter procedure [dbo].[GetAllMeters]

as  
begin  
select * from AddMeters
end  

exec GetAllMeters @MeterName1 = 'Meter A';

select AddMeters.MeterName1, Branch.branch_name from AddMeters inner join Branch on  AddMeters.id = Branch.id;


create table MetersReading(id int identity(1,1) primary key, Mdate varchar(50), MeterName int foreign key references AddMeters(id),
branchid int foreign key references Branch(id),Reading bigint);
select * from MetersReading; 

drop table  MetersReading

Go
CREATE OR Alter PROCEDURE [dbo].[SP_MetersReading]
(
@Mdate varchar(50),
@MeterName int,
@Reading bigint,
@branchid int
)
as 
Begin 
insert into MetersReading(Mdate, MeterName,Reading,branchid)
	values (@Mdate,@MeterName,@Reading,@branchid)
End

select MetersReading.id, AddMeters.MeterName1,MetersReading.Reading ,MetersReading.Mdate from MetersReading
inner join AddMeters on  MetersReading.id = AddMeters.id ;

select MetersReading.id, AddMeters.MeterName1,MetersReading.Reading ,MetersReading.Mdate from MetersReading
inner join AddMeters on  MetersReading.id = AddMeters.id  ;
drop table MetersReading;

Go
create or alter procedure GetAllMetersReadings(@branch_name varchar(50))
as  
begin  
--select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName,MetersReading.Reading  from MetersReading
--inner join AddMeters on  MetersReading.id = AddMeters.id ;

--select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName,MetersReading.Reading,Branch.branch_name  from MetersReading
--inner join AddMeters on  MetersReading.id = AddMeters.id
--inner join Branch on AddMeters.Branch_id = Branch.id;
select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName1,MetersReading.Reading,Branch.branch_name  from MetersReading
inner join AddMeters on  MetersReading.MeterName = AddMeters.id
inner join Branch on AddMeters.Branch_id = Branch.id where branch_name = @branch_name;
end  

exec GetAllMetersReadings Hyderabad

Go
create or alter procedure GetAllMetersReading
as  
begin  
--select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName,MetersReading.Reading  from MetersReading
--inner join AddMeters on  MetersReading.id = AddMeters.id ;

--select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName,MetersReading.Reading,Branch.branch_name  from MetersReading
--inner join AddMeters on  MetersReading.id = AddMeters.id
--inner join Branch on AddMeters.Branch_id = Branch.id;
select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName1,MetersReading.Reading,Branch.branch_name  from MetersReading
inner join AddMeters on  MetersReading.MeterName = AddMeters.id
inner join Branch on AddMeters.Branch_id = Branch.id
end  

select * from MetersReading

select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName1,MetersReading.Reading, Branch.branch_name  from MetersReading
inner join AddMeters on  MetersReading.id = AddMeters.id 
inner join Branch on MetersReading.id = Branch.id;

select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName1,MetersReading.Reading  from MetersReading
inner join AddMeters on  MetersReading.id = AddMeters.id;

select MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName1,MetersReading.Reading,Branch.branch_name  from MetersReading
inner join AddMeters on  MetersReading.id = AddMeters.id
inner join Branch on AddMeters.Branch_id = Branch.id;

Go
create or alter procedure [dbo].[UpdateItem]
@id int,
@Mdate date,
@MeterName int,
@Reading varchar(100),
@branchid int
AS
BEGIN
    UPDATE MetersReading
    SET Mdate = @Mdate,
        MeterName = @MeterName,
        Reading = @Reading
    WHERE id = @id
END


SELECT MetersReading.id,MetersReading.MeterName,MetersReading.Mdate, AddMeters.MeterName1,MetersReading.Reading  from MetersReading
inner join AddMeters on  MetersReading.MeterName = AddMeters.id  ORDER BY Mdate ASC ;

SELECT 	
  MetersReading.MeterName,
  AddMeters.MeterName1,
  Mdate,
  Reading,
  Branch.branch_name,
  --LAG(Reading) OVER (ORDER BY Mdate ) AS previous_day,
  Reading - LAG(Reading,1,Reading) OVER (ORDER BY MetersReading.MeterName ) AS units
FROM MetersReading inner join AddMeters on  MetersReading.MeterName = AddMeters.id
	inner join Branch on AddMeters.Branch_id = Branch.id
WHERE MetersReading.MeterName = 2
ORDER BY Reading

Go
create or alter procedure ShowItem(@MeterName int,@branch_name varchar(50))
AS
BEGIN
   
SELECT 	
  MetersReading.MeterName,
  AddMeters.MeterName1,
  Mdate,
  Reading,
  Branch.branch_name,
  LAG(Reading,1,0) OVER (ORDER BY Mdate ) AS previous_day,
  Reading - LAG(Reading,1,Reading) OVER (ORDER BY MetersReading.MeterName ) AS units
FROM MetersReading inner join AddMeters on  MetersReading.MeterName = AddMeters.id
	inner join Branch on AddMeters.Branch_id = Branch.id
WHERE MetersReading.MeterName = @MeterName and branch_name = @branch_name ORDER BY Reading

END



Go
create or alter procedure ShowItem1(@MeterName int)
AS
BEGIN
   
SELECT 	
  MetersReading.MeterName,
  AddMeters.MeterName1,
  Mdate,
  Reading,
  Branch.branch_name,
  LAG(Reading,1,0) OVER (ORDER BY Mdate ) AS previous_day,
  Reading - LAG(Reading,1,Reading) OVER (ORDER BY MetersReading.MeterName ) AS units
FROM MetersReading inner join AddMeters on  MetersReading.MeterName = AddMeters.id
	inner join Branch on AddMeters.Branch_id = Branch.id
WHERE MetersReading.MeterName = @MeterName  ORDER BY Reading

END


SELECT Mdate, MeterName, Sum(80) AS SumOfTempColumn
FROM MetersReading
WHERE MeterName = 2
GROUP BY MeterName, Mdate;

SELECT 	
  MeterName,
  Mdate,
  Reading,
  LAG(Reading) OVER (ORDER BY Mdate) AS previous_day,
  Reading - LAG(Reading) OVER (ORDER BY MeterName) AS units
FROM MetersReading
WHERE MeterName = 2
AND Mdate BETWEEN '2023-03-01' AND '2023-02-27'
ORDER BY Mdate


SELECT 	
  MeterName,
  Mdate,
  Reading,
  LAG(Reading) OVER (ORDER BY Mdate) AS previous_day,
  Reading - LAG(Reading) OVER (ORDER BY Mdate) AS units
FROM MetersReading
WHERE MeterName = 2
AND Mdate >= '2023-02-27'
AND Mdate <= '2023-03-01'
ORDER BY Mdate