CREATE TRIGGER TrackProductsDeletions
ON Products
AFTER DELETE
AS
BEGIN
    INSERT INTO DeletedRecords (Table_Name, Record_ID, DeletedAt)
    SELECT 'Products', deleted.ProductID, GETDATE()
    FROM deleted;
END;