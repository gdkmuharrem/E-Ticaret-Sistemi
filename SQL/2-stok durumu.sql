CREATE TRIGGER UpdateStockOnOrderCompletion
ON OrderHistory
AFTER INSERT
AS
BEGIN
    DECLARE @ProductID INT;
    DECLARE @Quantity INT;

    -- Geçmiþ sipariþler tablosundan yeni eklenen kayýtlarý al
    SELECT @ProductID = ProductID, @Quantity = Quantity
    FROM inserted;

    -- Ürün stok miktarýný güncelle
    UPDATE Products
    SET StockQuantity = StockQuantity - @Quantity
    WHERE ProductID = @ProductID;
END;
