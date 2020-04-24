CREATE TABLE [dbo].[Facilities] (
 Facility_Id INT PRIMARY KEY IDENTITY(1,1),
 Facility_Name VARCHAR(64) NOT NULL
)
SET IDENTITY_INSERT [dbo].[Facilities] ON
INSERT INTO [dbo].[Facilities] ([Facility_Id], [Facility_Name]) VALUES (1, N'Svømmehal')
INSERT INTO [dbo].[Facilities] ([Facility_Id], [Facility_Name]) VALUES (2, N'Bordtennisbord')
INSERT INTO [dbo].[Facilities] ([Facility_Id], [Facility_Name]) VALUES (3, N'Fittness center')
INSERT INTO [dbo].[Facilities] ([Facility_Id], [Facility_Name]) VALUES (4, N'WorkOutZone')
SET IDENTITY_INSERT [dbo].[Facilities] OFF
