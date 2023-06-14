
CREATE TABLE [dbo].[DMQuanHuyen](
	[MaQuanHuyen] [varchar](50) NOT NULL,
	[TenQuanHuyen] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[MaTinhThanh] [varchar](50) NULL,
	[MaQuanHuyen_BH] [nvarchar](50) NULL,
 CONSTRAINT [PK_DMQuanHuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuanHuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


