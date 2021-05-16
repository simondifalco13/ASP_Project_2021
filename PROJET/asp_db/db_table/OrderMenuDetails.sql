USE [ASP_Project]
GO

/****** Object:  Table [dbo].[OrderMenuDetails]    Script Date: 09-05-21 08:58:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderMenuDetails](
	[OrderId] [int] NOT NULL,
	[MenuId] [int] NOT NULL,
 CONSTRAINT [PK_OrderMenuDetails] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrderMenuDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderMenuDetails_Menus] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menus] ([MenuId])
GO

ALTER TABLE [dbo].[OrderMenuDetails] CHECK CONSTRAINT [FK_OrderMenuDetails_Menus]
GO

ALTER TABLE [dbo].[OrderMenuDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderMenuDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO

ALTER TABLE [dbo].[OrderMenuDetails] CHECK CONSTRAINT [FK_OrderMenuDetails_Orders]
GO

