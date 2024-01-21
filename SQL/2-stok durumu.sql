CREATE TRIGGER UpdateStockOnOrderCompletion
ON OrderHistory
AFTER INSERT
AS
BEGIN
    DECLARE @ProductID INT;
    DECLARE @Quantity INT;

    -- Ge�mi� sipari�ler tablosundan yeni eklenen kay�tlar� al
    SELECT @ProductID = ProductID, @Quantity = Quantity
    FROM inserted;

    -- �r�n stok miktar�n� g�ncelle
    UPDATE Products
    SET StockQuantity = StockQuantity - @Quantity
    WHERE ProductID = @ProductID;
END;
