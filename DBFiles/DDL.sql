
USE [Library]
GO

DROP TABLE [dbo].[Borrower_Details]
GO

/****** Object:  Table [dbo].[Borrower_Details]    Script Date: 4/26/2020 4:02:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Borrower_Details](
	[Issue_ID] [int] NOT NULL IDENTITY PRIMARY KEY ,
	[Book_Name] [nvarchar](50) NULL,
	[Borrowed_From_Date] [datetime] NULL,
	[Borrowed_To_Date] [datetime] NULL,
	[Issued_by] [nvarchar](50) NULL
) ON [PRIMARY]
GO


