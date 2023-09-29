create table Customer_Info_
(
customer_id int primary key identity(1,1),
customer_name varchar (100),
email nvarchar(200),
mobile bigint,
gender nvarchar(24) DEFAULT('M')

);

DROP TABLE DBO.Customer_Info_
SELECT * FROM 

insert into dbo.Customer_Info_(customer_name,email,mobile) values('sibi','sibi@gmail.com',1234567,'F',564),
('sri','sri@gmail.com',5467267),
('saavanan','saravanan@gmail.com',975205676),
('praveen','praveen@gmail.com',9876342),
('seenu','seenu@gmail.com',456278)

insert into dbo.Customer_Info_ (gender) values('M','M','M','M','M')

alter table Customer_Info_ add gender nvarchar(45)  null

alter table dbo.Customer_Info_ drop column PRICES;

alter table dbo.Customer_INFO_ ADD RATE BIGINT NOT NULL

INSERT INTO  DBO.STUDENT_INFO (PRICE) VALUES(150,256,345,823,1200)

select * from dbo.Customer_Info_

SELECT  SUM(CUSTOMER_ID)  AS SUM FROM CUSTOMER_INFO_

SELECT AVG(CUSTOMER_ID) AS AVG FROM CUSTOMER_INFO_

SELECT MAX(CUSTOMER_ID) AS MAX FROM  CUSTOMER_INFO_

SELECT MIN( CUSTOMER_ID) AS MIN FROM  CUSTOMER_INFO_
SELECT COUNT ( CUSTOMER_ID) AS COUNT FROM  CUSTOMER_INFO_

SELECT  MOBILE  FROM  CUSTOMER_INFO_ ORDER BY MOBILE;