Create Procedure Search
@id int
as
Select * from Menu where id=@id;
go