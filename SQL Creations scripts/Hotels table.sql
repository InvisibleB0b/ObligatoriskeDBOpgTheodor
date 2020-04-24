CREATE TABLE [dbo].[Hotels] (
    [Hotel_No] INT PRIMARY KEY  IDENTITY (1, 1)  NOT NULL,
    [Name]     VARCHAR (30) NOT NULL,
    [Address]  VARCHAR (50) NOT NULL
)
SET IDENTITY_INSERT [dbo].[Hotels] ON
INSERT INTO [dbo].[Hotels] ([Hotel_Id], [Hotel_Name], [Hotel_Address]) VALUES (2, N'Opdateret for JP', N'Opdateret for JP')
INSERT INTO [dbo].[Hotels] ([Hotel_Id], [Hotel_Name], [Hotel_Address]) VALUES (3, N'test2', N'test2')
INSERT INTO [dbo].[Hotels] ([Hotel_Id], [Hotel_Name], [Hotel_Address]) VALUES (4, N'test3', N'test3')
INSERT INTO [dbo].[Hotels] ([Hotel_Id], [Hotel_Name], [Hotel_Address]) VALUES (5, N'Test', N'´test')
INSERT INTO [dbo].[Hotels] ([Hotel_Id], [Hotel_Name], [Hotel_Address]) VALUES (6, N'Test', N'test')
INSERT INTO [dbo].[Hotels] ([Hotel_Id], [Hotel_Name], [Hotel_Address]) VALUES (7, N'Test', N'midt Roskilde vej 32')
SET IDENTITY_INSERT [dbo].[Hotels] OFF
