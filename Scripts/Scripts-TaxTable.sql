USE [ADS_2]
GO

/****** Object:  Table [dbo].[TAX_TABLE]    Script Date: 4/1/2021 3:15:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TAX_TABLE](
	[TAXID] [bigint] NOT NULL,
	[TAXNAME] [nvarchar](max) NULL,
	[TAXRATE_PERCENTAGE] [float] NULL,
	[TAXRATE_PERUNIT] [float] NULL,
	[TAXVALIDITY_FROM] [date] NULL,
	[TAXVALIDITY_TO] [date] NULL,
	[TAXACTION] [nchar](1) NULL,
 CONSTRAINT [PK_TAX_TABLE] PRIMARY KEY CLUSTERED 
(
	[TAXID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'''A'' = Add, ''D'' = Deduct' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TAX_TABLE', @level2type=N'COLUMN',@level2name=N'TAXACTION'
GO



