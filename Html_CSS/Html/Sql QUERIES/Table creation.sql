--Data Definition Language

		--Create,Alter,Drop,Truncate

		CREATE TABLE STUDENT_INFO
		(EMPID INT not null ,
		NAME VARCHAR(100) not null,
		PLACE NVARCHAR (100)not null,
	MOBILE INT
		);
		SELECT * FROM STUDENT_INFO
		SELECT  MOBILE, *FROM STUDENT_INFO WHERE EMPID= 1 --AND PLACE='PALANI'

		INSERT INTO STUDENT_INFO VALUES (1,'sibi','palani',98765343),
		(2,'hari','coimbatore',98765643),
		(3,'saravanan','erode',34765367),
		(4,'arun','palani',98565343)

		UPDATE STUDENT_INFO SET PLACE='SALEM' WHERE EMPID=3

				SELECT * FROM STUDENT_INFO

		Delete   FROM STUDENT_INFO where EMPID=1

		DROP TABLE STUDENT_INFO


	select * from dbo.student_info

select * from dbo.STUDENT_INFO
USE [SQL QUERIES]
GO

/****** Object:  Table [dbo].[STUDENT_INFO]    Script Date: 7/12/2023 9:42:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
use 
[SQL QUERIES]
go

CREATE TABLE [dbo].[STUDENT_INFO]
(
	[EMPID] [int] NOT NULL,
	[NAME] [varchar](100) NOT NULL,
	[PLACE] [nvarchar](100) NOT NULL,
	[MOBILE] [int] NULL,
	[MARK] [int]  not NULL
) ON [PRIMARY]
GO
drop table STUDENT_INFO
truncate table dbo.STUDENT_INFO
select * from dbo.STUDENT_INFO
insert into dbo.STUDENT_INFO values(1,'sibi','palani',4566,90),
(2,'seenu','mayiladudhurai',89790,90),
(3,'indhu','namakkal',9834,78),
(4,'dhanush','salem',4566,100),
(5,'ganes','erode',56785,30)

create table studentaddress_info
(
stuid int,
student_address nvarchar(100),
aadhar int,
gender varchar(100)

)
drop table dbo.studentaddress_info
select * from dbo.studentaddress_info
truncate table dbo.studentaddress_info
insert into dbo.studentaddress_info values(1,'addd1',45,'m'),
(2,'addd1',45,'m'),
(3,'addd1',45,'m'),
(4,'addd1',45,'m')























update dbo.STUDENT_INFO set NAME = 'sibiyarasu' where  EMPID=1




		