CREATE PROCEDURE UpdateProduct
    @ürün_adi NVARCHAR(255),
    @categoryID INT,
    @fiyat DECIMAL(10, 2),
    @stok INT,
    @productID INT
AS
BEGIN
    UPDATE Products
    SET ProductName = @ürün_adi,
        CategoryID = @categoryID,
        Price = @fiyat,
        StockQuantity = @stok
    WHERE ProductID = @productID;
END;
