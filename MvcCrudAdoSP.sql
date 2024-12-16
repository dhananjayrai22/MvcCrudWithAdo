Create Database MvcCrudAdo

Use MvcCrudAdo

Create table Users (
Id int Primary key Identity(1,1),
Name varchar(50),
Email varchar(50),
Age int
)

Create Proc sp_insert
@name varchar(50),
@email varchar(50),
@age int
as
begin
	insert into Users values (@name, @email, @age)
end

Create Proc sp_update
@name varchar(50),
@email varchar(50),
@age int,
@id int
as 
begin 
	Update Users set Name=@name, Email=@email, Age=@age where Id=@id
end

Create Proc sp_delete
@id int
as 
begin
	delete from Users where Id=@id
end

Create Proc sp_select
as
begin
	select * from Users
end

Select * from Users