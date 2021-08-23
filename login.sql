create database login

use login;

create table loginInfo(
	id int primary key identity,
	name nvarchar(50) unique, 
	password nvarchar(50)
);
insert into loginInfo (name, password) values ('Kushal123', 'passport');

select * from loginInfo;

select name, password from loginInfo;