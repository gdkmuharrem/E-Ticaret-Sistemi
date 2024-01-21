CREATE PROCEDURE GetCustomerInfo
    @CustomerUsername varchar(50)
AS
BEGIN
    SELECT * FROM Customers WHERE CustomerUsername = @CustomerUsername;
END;

