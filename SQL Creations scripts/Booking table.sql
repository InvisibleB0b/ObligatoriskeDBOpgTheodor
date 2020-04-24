CREATE TABLE Bookings (
 Booking_Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
 Room_Id INT NOT NULL,
 Hotel_Id INT NOT NULL,
 Guest_Id INT NOT NULL,
 Booking_Start DATETIME NOT NULL,
 Booking_End DATETIME NOT NULL,
    FOREIGN KEY ([Guest_Id]) REFERENCES [dbo].[Guests] ([Guest_Id]),
    FOREIGN KEY ([Room_Id]) REFERENCES [dbo].[Rooms] ([Room_Id]),
    FOREIGN KEY ([Hotel_Id]) REFERENCES [dbo].[Hotels] ([Hotel_Id])
);
