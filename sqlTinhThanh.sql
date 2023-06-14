

CREATE TABLE [dbo].[DMTinhThanh](
	[MaTinhThanh] [varchar](50) NOT NULL,
	[TenTinhThanh] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[MaQuocGia] [varchar](50) NULL,
	[MaTinhThanh_BH] [nvarchar](50) NULL,
 CONSTRAINT [PK_DMTinhThanh] PRIMARY KEY CLUSTERED 
(
	[MaTinhThanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


