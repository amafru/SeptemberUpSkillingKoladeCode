create database Testing

use Testing

create table Customer
(
CustomerID integer primary key identity(1,1),
CustomerFirstName varchar(30) not null,
CustomerLastName varchar(30) not null,
CustomerAddress varchar(50) not null,
CustomerCity varchar(50)
);

create table ItemOrder
(
OrderID integer primary key identity(50,1),
ItemName varchar(20) not null,
ItemPrice money,
CustomerID integer not null foreign key references Customer(CustomerID),
);

--select statement practice
select * from Customer
select * from ItemOrder

--insert statement practice
insert into Customer(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerCity)
values('Bisi', 'Ola', 'East Croydon', 'London')

insert into Customer(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerCity)
values('Temi', 'Lola', 'Dartford', 'Kent')

insert into Customer(CustomerFirstName, CustomerLastName, CustomerAddress, CustomerCity)
values('Zina', 'Niba', 'Erith', 'Kent')

insert into ItemOrder(ItemName, ItemPrice, CustomerID)
values('Laptop', 500, 1);

insert into ItemOrder(ItemName, ItemPrice, CustomerID)
values('Wireless Keyboard', 28, 1);

insert into ItemOrder(ItemName, ItemPrice, CustomerID)
values('Screen', 120, 2);

--update statement practice
update ItemOrder
set ItemName = 'Wireless Mouse'
where OrderID = 52;

--delete a customer with no order history
delete from Customer
where CustomerID = 4;

--delete customer with an order history.
--command SHOULD NOT execute sucessfully because the foreign key for that customer still exits
--in ItemOrder table
--Therefore we MUST first delete the record in the ItemOrder table before the Customer record
--can be deleted
delete from ItemOrder
where OrderID = 52;

delete from Customer
where CustomerID = 2;

select * from Customer
select * from ItemOrder

--left join
select * from Customer
left join ItemOrder on Customer.CustomerID = ItemOrder.CustomerID

--right join
select * from Customer
right join ItemOrder on Customer.CustomerID = ItemOrder.CustomerID

--inner join
select * from Customer
inner join ItemOrder on Customer.CustomerID = ItemOrder.CustomerID