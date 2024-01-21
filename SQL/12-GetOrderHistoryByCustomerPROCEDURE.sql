CREATE PROCEDURE GetOrderHistoryByCustomer
    @kullaniciAdi NVARCHAR(50) 
AS
BEGIN
    SELECT * FROM OrderHistory WHERE CustomerUsername = @kullaniciAdi;
END;
