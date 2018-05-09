Create Database DaCiccio
go
use DaCiccio
go
Create Table Menu(
id int identity(1,1) primary key not null,
datag date not null,
pasto nvarchar(20) not null,
Giorno nvarchar(20) not null,
primo nvarchar(20) ,
secondo nvarchar(20),
contorno nvarchar(20),
dolce nvarchar(20)
)