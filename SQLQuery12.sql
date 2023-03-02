
Go
CREATE OR Alter PROCEDURE [dbo].[SP_MetersReading]
(
@Mdate date,
@MeterName varchar(50),
@Reading varchar(100)
)
as 
Begin 
insert into MetersReading(Mdate, MeterName,Reading)
	values (@Mdate,@MeterName,@Reading)
End


select * from MetersReading;

SELECT Reading FROM MetersReading ORDER BY Mdate ASC;