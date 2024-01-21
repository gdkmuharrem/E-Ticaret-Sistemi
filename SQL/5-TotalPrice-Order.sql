CREATE TRIGGER trg_Orders_Insert ON Orders
FOR INSERT
AS
BEGIN
    UPDATE Orders
    SET TotalPrice = Quantity * (SELECT Price FROM Products WHERE ProductID = Orders.ProductID)
    WHERE ProductID IN (SELECT ProductID FROM inserted)
END;