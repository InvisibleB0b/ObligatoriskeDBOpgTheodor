CREATE TABLE [dbo].Rooms (
    [Room_Id] INT PRIMARY KEY  IDENTITY (1, 1)  NOT NULL,
    [Room_No] INT NOT NULL,
    [Hotel_Id] INT NOT NULL,
    [Room_Type] CHAR(1) DEFAULT('S') NULL,
    [Room_Price] FLOAT NOT NULL,
    CONSTRAINT [checkType] CHECK ([Room_Type]='S' OR [Room_Type]='F' OR [Room_Type]='D' OR [Room_Type] IS NULL),
    CONSTRAINT [checkPrice] CHECK ([Room_Price]>=(0) AND [Room_Price]<=(9999))
);
