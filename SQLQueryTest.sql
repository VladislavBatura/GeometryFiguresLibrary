/*
	� ���� ������ MS SQL Server ���� �������� � ���������.
    ������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������.
	�������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������.
	���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.
*/

create table Products
(
	Id int primary key,
	"Name" nvarchar(50)
);

insert into Products values
	(1, N'�������'),
	(2, N'�������'),
	(3, N'����'),
	(4, N'����'),
	(5, N'������ �����');

create table Categories (
	Id int primary key,
	"Name" nvarchar(50)
);

insert into Categories values
	(0, 'Null'),
	(1, N'������'),
	(2, N'�������'),
	(3, N'�������'),
	(4, N'����');

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