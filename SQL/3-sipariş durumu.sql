CREATE TRIGGER MoveOrderToHistory
ON Orders
AFTER UPDATE
AS
BEGIN
    DECLARE @OrderID INT;
    DECLARE @OrderStatus NVARCHAR(1);

    -- Güncellenen sipariþin kimliðini ve durumunu al
    SELECT @OrderID = OrderID, @OrderStatus = OrderStatus
    FROM inserted;

    -- Eðer sipariþ tamamlandý ise (örneðin "OrderStatus" sütunu G ise)
    IF @OrderStatus ='G'
    BEGIN
        -- Silinen sipariþi "OrderHistory" tablosuna ekle
        INSERT INTO OrderHistory (CustomerUsername,OrderDate, ProductID, Quantity,TotalPrice)
        SELECT od.CustomerUsername, od.OrderDate, od.ProductID, od.Quantity, od.TotalPrice
        FROM Orders od
        INNER JOIN Products p ON od.ProductID = p.ProductID
        WHERE od.OrderID = @OrderID;

        -- Silinen sipariþi "Orders" tablosundan kaldýr
        DELETE FROM Orders
        WHERE OrderID = @OrderID;
    END;
END;
