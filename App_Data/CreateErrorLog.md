CREATE TABLE [dbo].[ErrorLog](   
    [nId] [bigint] IDENTITY(1,1) NOT NULL,   
    [dtDate] [datetime] NOT NULL,   
    [sThread] [nvarchar](100) NOT NULL,   
    [sLevel] [nvarchar](200) NOT NULL,   
    [sLogger] [nvarchar](500) NOT NULL,   
    [sMessage] [nvarchar](3000) NOT NULL,   
    [sException] [nvarchar](4000) NULL) 