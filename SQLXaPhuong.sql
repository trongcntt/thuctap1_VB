
CREATE TABLE [dbo].[DMXaPhuong](
	[MaXa] [varchar](50) NOT NULL,
	[TenXa] [nvarchar](200) NULL,
	[MoTaThonXa] [nvarchar](200) NULL,
	[MaQuanHuyen] [varchar](50) NULL,
	[MaTinhThanh] [varchar](50) NULL,
	[VietTat] [varchar](50) NULL,
 CONSTRAINT [PK_DMXaPhuong] PRIMARY KEY CLUSTERED 
(
	[MaXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



