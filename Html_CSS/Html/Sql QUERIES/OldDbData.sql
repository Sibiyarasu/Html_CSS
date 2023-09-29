
ALTER DATABASE [SQL QUERIES] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SQL QUERIES].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SQL QUERIES] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SQL QUERIES] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SQL QUERIES] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SQL QUERIES] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SQL QUERIES] SET ARITHABORT OFF 
GO
ALTER DATABASE [SQL QUERIES] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SQL QUERIES] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SQL QUERIES] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SQL QUERIES] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SQL QUERIES] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SQL QUERIES] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SQL QUERIES] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SQL QUERIES] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SQL QUERIES] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SQL QUERIES] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SQL QUERIES] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SQL QUERIES] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SQL QUERIES] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SQL QUERIES] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SQL QUERIES] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SQL QUERIES] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SQL QUERIES] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SQL QUERIES] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SQL QUERIES] SET  MULTI_USER 
GO
ALTER DATABASE [SQL QUERIES] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SQL QUERIES] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SQL QUERIES] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SQL QUERIES] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SQL QUERIES] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SQL QUERIES] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SQL QUERIES] SET QUERY_STORE = OFF
GO
USE [SQL QUERIES]
GO
/****** Object:  Table [dbo].[CourseDetails]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseDetails](
	[coursename] [nvarchar](30) NULL,
	[Duration] [int] NULL,
	[university] [nvarchar](30) NULL,
	[StartDate] [nvarchar](48) NULL,
	[seats] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[sibi]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sibi]

as
select * from dbo.CourseDetails
GO
/****** Object:  View [dbo].[sibis]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sibis]

as
select * from dbo.CourseDetails
GO
/****** Object:  Table [dbo].[CourseDetailsInfo]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseDetailsInfo](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [nvarchar](70) NULL,
	[Duration] [int] NULL,
	[University] [nvarchar](400) NULL,
	[StartDate] [datetime] NULL,
	[Seats] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[players]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[players](
	[player_id] [int] NOT NULL,
	[player_name] [varchar](300) NULL,
	[game] [varchar](34) NULL,
	[player_salary] [int] NULL,
	[age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[player_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[Age] [int] NULL,
	[Email] [varchar](100) NULL,
	[Gender] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studentaddress_info]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studentaddress_info](
	[stuid] [int] NULL,
	[student_address] [nvarchar](100) NULL,
	[aadhar] [int] NULL,
	[gender] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[EMPID] [nchar](10) NOT NULL,
	[NAME] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CourseDetails] ([coursename], [Duration], [university], [StartDate], [seats]) VALUES (N'B.com', 4, N'AnnaUniversity', N'july 4', 100)
GO
INSERT [dbo].[CourseDetails] ([coursename], [Duration], [university], [StartDate], [seats]) VALUES (N'M.com', 3, N'AnnaUniversity', N'july 10', 120)
GO
INSERT [dbo].[CourseDetails] ([coursename], [Duration], [university], [StartDate], [seats]) VALUES (N'B.E', 4, N'KamarajarUniversity', N'march 10', 150)
GO
INSERT [dbo].[CourseDetails] ([coursename], [Duration], [university], [StartDate], [seats]) VALUES (N'B.E', 4, N'KamarajarUniversity', N'march 10', 150)
GO
INSERT [dbo].[CourseDetails] ([coursename], [Duration], [university], [StartDate], [seats]) VALUES (N'mcom', 4, N'Bharathiyar university', N'jan10', 12)
GO
INSERT [dbo].[CourseDetails] ([coursename], [Duration], [university], [StartDate], [seats]) VALUES (N'suresh', 3, N'anna', N'15-05-2023', 14)
GO
SET IDENTITY_INSERT [dbo].[CourseDetailsInfo] ON 
GO
INSERT [dbo].[CourseDetailsInfo] ([CourseId], [CourseName], [Duration], [University], [StartDate], [Seats]) VALUES (1, N'b.com', 3, N'a', CAST(N'2023-09-25T00:00:00.000' AS DateTime), 120)
GO
INSERT [dbo].[CourseDetailsInfo] ([CourseId], [CourseName], [Duration], [University], [StartDate], [Seats]) VALUES (2, N'bsc cs', 4, N'k', CAST(N'2002-09-01T00:00:00.000' AS DateTime), 2345)
GO
INSERT [dbo].[CourseDetailsInfo] ([CourseId], [CourseName], [Duration], [University], [StartDate], [Seats]) VALUES (3, N'bsc', 5, N'a', CAST(N'2023-09-24T00:00:00.000' AS DateTime), 120)
GO
INSERT [dbo].[CourseDetailsInfo] ([CourseId], [CourseName], [Duration], [University], [StartDate], [Seats]) VALUES (4, N'bsc com', 4, N'k', CAST(N'2002-01-01T00:00:00.000' AS DateTime), 555)
GO
INSERT [dbo].[CourseDetailsInfo] ([CourseId], [CourseName], [Duration], [University], [StartDate], [Seats]) VALUES (5, N'sisiss', 33, N'karpagam', CAST(N'2002-01-01T00:00:00.000' AS DateTime), 2345)
GO
SET IDENTITY_INSERT [dbo].[CourseDetailsInfo] OFF
GO
INSERT [dbo].[players] ([player_id], [player_name], [game], [player_salary], [age]) VALUES (2, N'hari', N'boxing', 10000, 23)
GO
SET IDENTITY_INSERT [dbo].[Registration] ON 
GO
INSERT [dbo].[Registration] ([EmpId], [FirstName], [Age], [Email], [Gender]) VALUES (1, N'sibi', 23, N'sibiyarasu@gmail.com', N'male')
GO
INSERT [dbo].[Registration] ([EmpId], [FirstName], [Age], [Email], [Gender]) VALUES (2, N'ajay', 24, N'ajay@gmail.com', N'male')
GO
INSERT [dbo].[Registration] ([EmpId], [FirstName], [Age], [Email], [Gender]) VALUES (5, N'sibiyarasy', 45, N'sibi@gmail.com', N'b')
GO
INSERT [dbo].[Registration] ([EmpId], [FirstName], [Age], [Email], [Gender]) VALUES (6, N'hari', 23, N'hari@gmail.com', N'M')
GO
INSERT [dbo].[Registration] ([EmpId], [FirstName], [Age], [Email], [Gender]) VALUES (7, N'Indhu', 0, N'Indhu@gmail.com', N'M')
GO
SET IDENTITY_INSERT [dbo].[Registration] OFF
GO
INSERT [dbo].[studentaddress_info] ([stuid], [student_address], [aadhar], [gender]) VALUES (1, N'addd1', 45, N'm')
GO
INSERT [dbo].[studentaddress_info] ([stuid], [student_address], [aadhar], [gender]) VALUES (2, N'addd1', 45, N'm')
GO
INSERT [dbo].[studentaddress_info] ([stuid], [student_address], [aadhar], [gender]) VALUES (3, N'addd1', 45, N'm')
GO
INSERT [dbo].[studentaddress_info] ([stuid], [student_address], [aadhar], [gender]) VALUES (4, N'addd1', 45, N'm')
GO
/****** Object:  StoredProcedure [dbo].[Course]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Course]
as

begin 
select * from CourseDetails
end

exec Course
GO
/****** Object:  StoredProcedure [dbo].[DeleteRegistration]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[DeleteRegistration] (@FirstName varchar (110))
  as
  begin
  Delete  from dbo.Registration  where FirstName=@FirstName
  end
GO
/****** Object:  StoredProcedure [dbo].[deletesp]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deletesp] (@player_id int)
as
begin

delete from dbo.players where player_id=@player_id
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllCourseDetails]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[GetAllCourseDetails]
as
begin

select * from dbo.CourseDetailsInfo
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllRegisrtation]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  Create procedure [dbo].[GetAllRegisrtation]
  as
  begin
  select * from dbo.Registration
  end
GO
/****** Object:  StoredProcedure [dbo].[InsertAllCourseDetails]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create   procedure [dbo].[InsertAllCourseDetails](@CourseName nvarchar(45),@Duration int,@University nvarchar(100) ,@StartDate datetime,@Seats int)
as

begin
insert into dbo.CourseDetailsInfo (CourseName,Duration,University,StartDate,Seats) values(@CourseName,@Duration,@University,@StartDate,@Seats)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertCourse]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[InsertCourse](@coursename nvarchar(50),@Duration int, @University nvarchar(45),@startdate nvarchar(100) ,@seats int)
as 
begin
insert into dbo.CourseDetails (coursename,Duration , University,startdate,seats) values (@coursename ,@Duration , @University,@startdate ,@seats)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertInfo]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[InsertInfo](@coursename nvarchar(30),@Duration int,@university nvarchar(30),@StartDate  nvarchar(48),@seats int)

as
 begin
 Insert into CourseDetails values (@coursename,@Duration,@university,@StartDate,@seats)
 end
GO
/****** Object:  StoredProcedure [dbo].[InsertRegistration]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertRegistration](@Firstname varchar(100),@Age int,@Email varchar(100),@Gender varchar(100))
  as
  begin
  insert into dbo.Registration(Firstname,Age ,Email ,Gender) values(@Firstname,@Age,@Email,@Gender)
  end
GO
/****** Object:  StoredProcedure [dbo].[insertsp]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create  procedure [dbo].[insertsp] (@player_id int,@player_name nvarchar(100),@game nvarchar(40),@player_salary int,@age int)
as
begin
 insert into dbo.players (player_id,player_name,game,player_salary,age) values (@player_id,@player_name,@game,@player_salary,@age)
	
end
GO
/****** Object:  StoredProcedure [dbo].[selectsp]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectsp]
as
begin

select * from dbo.players
end
GO
/****** Object:  StoredProcedure [dbo].[SPTempTables]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPTempTables](@EmpId int, @EmpName varchar(40), @Gender varchar(50))

as 

begin 
select * from #Employee

end
GO
/****** Object:  StoredProcedure [dbo].[UpdateRegistration]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  Create procedure [dbo].[UpdateRegistration](@Email varchar(100),@FirstName varchar(100))
  as
  begin
  update dbo.Registration set Email=@Email where FirstName=@FirstName
  end
GO
/****** Object:  StoredProcedure [dbo].[updatesp]    Script Date: 7/28/2023 12:59:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[updatesp] (@player_name nvarchar(100),@game nvarchar(40),@player_salary int,@age int,@player_id int)

as 
begin
update dbo.players set 

player_name=@player_name,
game=@game,
player_salary=@player_salary,
age=@age

where  player_id=@player_id

end 
GO
USE [master]
GO
ALTER DATABASE [SQL QUERIES] SET  READ_WRITE 
GO
