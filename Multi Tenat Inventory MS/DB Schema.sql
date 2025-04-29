CREATE DATABASE IMS 
USE IMS

-- Create Tenants Table
CREATE TABLE Tenants (
    TenantID INT PRIMARY KEY IDENTITY(1,1),
    TenantName NVARCHAR(100) NOT NULL
);

-- Create Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) NOT NULL,
    PasswordHash NVARCHAR(256) NOT NULL,
    TenantID INT NOT NULL,
    FOREIGN KEY (TenantID) REFERENCES Tenants(TenantID)
);

-- Create Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    TenantID INT NOT NULL,
    FOREIGN KEY (TenantID) REFERENCES Tenants(TenantID)
);

-- Create Orders Table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    OrderDate DATETIME NOT NULL DEFAULT GETDATE(),
    TenantID INT NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (TenantID) REFERENCES Tenants(TenantID)
);

-- Indexes for performance
CREATE INDEX idx_Products_TenantID ON Products(TenantID);
CREATE INDEX idx_Orders_TenantID ON Orders(TenantID);
CREATE INDEX idx_Users_TenantID ON Users(TenantID);
