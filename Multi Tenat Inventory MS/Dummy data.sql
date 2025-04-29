use IMS
DECLARE @counter INT = 1;

WHILE @counter <= 10
BEGIN
    -- Insert dummy data into Products table
    INSERT INTO Products (Name, Quantity, Price, TenantID)
    VALUES (
        CONCAT('Product ', @counter),   -- Product Name (e.g., "Product 1", "Product 2", etc.)
        ABS(CHECKSUM(NEWID()) % 100) + 1,  -- Random Quantity between 1 and 100
        ABS(CHECKSUM(NEWID()) % 1000) + 10, -- Random Price between 10.00 and 1000.00
        1  -- TenantID = 1
    );

    SET @counter = @counter + 1;
END;

DECLARE @counter2 INT = 1;

WHILE @counter2 <= 100
BEGIN
    -- Insert dummy data into Orders table
    INSERT INTO Orders (ProductID, Quantity, TenantID, OrderDate)
    VALUES (
        ABS(CHECKSUM(NEWID()) % 10) + 1, -- Random ProductID between 1-10 (Assuming you have 10 products)
        ABS(CHECKSUM(NEWID()) % 5) + 1,  -- Random Quantity between 1-5
        2, -- TenantID = 1
        DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 30), GETDATE()) -- Random OrderDate in the last 30 days
    );

    SET @counter2 = @counter2 + 1;
END;
