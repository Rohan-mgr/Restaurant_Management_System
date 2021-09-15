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

create table orderDetails(
	id int primary key identity,
	category nvarchar(50), 
	items nvarchar(50), 
	quantity float, 
	unitprice float, 
	totalprice float
);
drop table orderDetails;
insert into orderDetails values ('Snacks', 'French Fries', 10, 75.25, 750); 
select * from orderDetails;