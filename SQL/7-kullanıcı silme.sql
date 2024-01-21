CREATE TRIGGER CustomerDeletions
ON Customers
AFTER DELETE
AS
BEGIN
    INSERT INTO DeletedRecords (Table_Name, Record_ID, DeletedAt)
    SELECT 'Customers', deleted.CustomerUsername, GETDATE()
    FROM deleted;
END;
