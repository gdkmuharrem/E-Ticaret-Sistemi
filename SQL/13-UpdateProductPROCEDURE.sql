CREATE PROCEDURE UpdateProduct
    @�r�n_adi NVARCHAR(255),
    @categoryID INT,
    @fiyat DECIMAL(10, 2),
    @stok INT,
    @productID INT
AS
BEGIN
    UPDATE Products
    SET ProductName = @�r�n_adi,
        CategoryID = @categoryID,
        Price = @fiyat,
        StockQuantity = @stok
    WHERE ProductID = @productID;
END;
