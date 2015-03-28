-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
use DoubleBalls
go

if not exists(select * from sysobjects where upper([xtype])='U' and upper([name])='ACCOUNT')
begin
	create table Account(
		[TenantGuid] uniqueidentifier default newid() not null primary key,
		[TenantName] nvarchar(50) not null,
		[TenantPassword] nvarchar(50) not null
	)

	print 'Table: Account is created. Time: ' + convert(varchar(30),getdate())

	create index AccountIndex
		on ACCOUNT ([TenantName])
end

if not exists(select * from sysobjects where upper([xtype])='U' and upper([name])='RECORD')
begin
	create table Record(
		[RecordGuid] uniqueidentifier default newid() not null primary key,
		[TenantGuid] uniqueidentifier not null,
		[DateTime] datetime not null,
		[Type] tinyint not null,
		[Cost] int not null,
		[State] tinyint not null,
	)

	print 'Table: Record is created. Time: ' + convert(varchar(30),getdate())

	create index RecordIndex
		on Record ([TenantGuid])
end

if not exists(select * from sysobjects where upper([xtype])='U' and upper([name])='DCBALLDETAIL')
begin
	create table DCBallDetail (
		[DetailGuid] uniqueidentifier default newid() not null primary key,
		[DateTime] datetime not null,
		[RecordGuid] uniqueidentifier not null,
		[TenantGuid] uniqueidentifier not null,
		[BallsNo] nvarchar(50) not null,
		[Count] int not null,
	)
	
	print 'Table: DCBallDetail is created. Time: ' + convert(varchar(30),getdate())

	create index DCBallDetailIndex
		on DCBallDetail ([RecordGuid])
end
