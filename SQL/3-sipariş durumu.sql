CREATE TRIGGER MoveOrderToHistory
ON Orders
AFTER UPDATE
AS
BEGIN
    DECLARE @OrderID INT;
    DECLARE @OrderStatus NVARCHAR(1);

    -- G�ncellenen sipari�in kimli�ini ve durumunu al
    SELECT @OrderID = OrderID, @OrderStatus = OrderStatus
    FROM inserted;

    -- E�er sipari� tamamland� ise (�rne�in "OrderStatus" s�tunu G ise)
    IF @OrderStatus ='G'
    BEGIN
        -- Silinen sipari�i "OrderHistory" tablosuna ekle
        INSERT INTO OrderHistory (CustomerUsername,OrderDate, ProductID, Quantity,TotalPrice)
        SELECT od.CustomerUsername, od.OrderDate, od.ProductID, od.Quantity, od.TotalPrice
        FROM Orders od
        INNER JOIN Products p ON od.ProductID = p.ProductID
        WHERE od.OrderID = @OrderID;

        -- Silinen sipari�i "Orders" tablosundan kald�r
        DELETE FROM Orders
        WHERE OrderID = @OrderID;
    END;
END;
