/*
	В базе данных MS SQL Server есть продукты и категории.
    Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
	Написать SQL запрос для выбора всех пар «Имя продукта – Имя категории».
	Если у продукта нет категорий, то его имя все равно должно выводиться.
*/

create table Products
(
	Id int primary key,
	"Name" nvarchar(50)
);

insert into Products values
	(1, N'Печенье'),
	(2, N'Конфеты'),
	(3, N'Вода'),
	(4, N'Хлеб'),
	(5, N'Зубная паста');

create table Categories (
	Id int primary key,
	"Name" nvarchar(50)
);

insert into Categories values
	(0, 'Null'),
	(1, N'Мучное'),
	(2, N'Сладкое'),
	(3, N'Напитки'),
	(4, N'Мясо');

create table ProductCategories (
	ProductId int foreign key references Products(Id),
	CategoryId int foreign key references Categories(Id),
	primary key (ProductId, CategoryId)
);

insert into ProductCategories values
	(1, 1),
	(1, 2),
	(2, 2),
	(3, 4),
	(4, 1),
	(5, 0);

select P."Name", C."Name"
from Products P
left join ProductCategories PC
	on P.Id = PC.ProductId
left join Categories C
	on PC.CategoryId = C.Id;