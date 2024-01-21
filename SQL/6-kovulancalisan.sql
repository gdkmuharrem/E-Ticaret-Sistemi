CREATE TRIGGER EmployeeDeletions
ON Employee
AFTER DELETE
AS
BEGIN
    INSERT INTO DeletedRecords (Table_Name, Record_ID, DeletedAt)
    SELECT 'Employee', deleted.EmployeeUsername, GETDATE()
    FROM deleted;
END;