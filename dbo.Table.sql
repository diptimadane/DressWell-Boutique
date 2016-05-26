CREATE TABLE [dbo].[TBL_CustomerInfo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Address] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(50) NULL, 
    [Name] NVARCHAR(50) NULL, 
    [PrefTimeOfDelivery] NVARCHAR(50) NULL, 
    [PrevOrder] NVARCHAR(50) NULL, 
    [Style] NVARCHAR(50) NULL
)
