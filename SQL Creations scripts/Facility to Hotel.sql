CREATE TABLE Facility_To_Hotel (
   F_To_H_Id INT PRIMARY KEY IDENTITY(1,1),
   Facility_Id INT NOT NULL,
   Hotel_Id INT NOT NULL,
   FOREIGN KEY ([Facility_Id]) REFERENCES [dbo].[Facilities] ([Facility_Id]),
   FOREIGN KEY ([Hotel_Id]) REFERENCES [dbo].[Hotels]([Hotel_Id])
);