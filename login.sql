use login;

create table loginInfo(
	id int primary key identity,
	name nvarchar(50), 
	password nvarchar(50)
);
insert into loginInfo (name, password) values ('Rohan123', 'pass#123');

select * from loginInfo;

select name, password from loginInfo;