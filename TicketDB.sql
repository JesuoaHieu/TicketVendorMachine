CREATE DATABASE TicketDB;
GO
USE TicketDB;
GO

CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    StationName NVARCHAR(100),
    Price DECIMAL(18,2),
    PaymentMethod NVARCHAR(50), 
    Status NVARCHAR(50),       
    CreatedDate DATETIME DEFAULT GETDATE()
);