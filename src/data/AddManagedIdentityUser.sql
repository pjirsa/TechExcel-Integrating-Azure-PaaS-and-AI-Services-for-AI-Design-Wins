USE ContosoSuitesBookings;
CREATE USER TechExcelMI FROM LOGIN TechExcelMI;
ALTER ROLE db_datareader ADD MEMBER TechExcelMI;
ALTER ROLE db_datawriter ADD MEMBER TechExcelMI;