namespace Punkt.Model.DAL
{
    public static class QueryRepo
    {
        #region Create Tables
        public static string CheckTableExist = "SELECT name FROM sqlite_master WHERE type='table' AND name='{0}';";

        public static string CreateOwnerTable = @"CREATE TABLE `Owners` (
                                                `Id`    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                                `CreatedOn` TEXT NOT NULL,
                                                `UpdatedOn` TEXT,
                                                `FirstName` TEXT NOT NULL,
                                                `LastName`  TEXT,
                                                `Telephone` TEXT NOT NULL);";

        public static string CreateCarTable = @"CREATE TABLE `Cars` (
                                                `Id`    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                                `CreatedOn` TEXT NOT NULL,
                                                `UpdatedOn` TEXT,
                                                `NumberPlate`   TEXT NOT NULL UNIQUE,
                                                `Category`  TEXT NOT NULL,
                                                `OwnerId`   INTEGER NOT NULL,
                                                FOREIGN KEY(`OwnerId`) REFERENCES `Owners`(`Id`));";

        public static string CreateSaleTable = @"CREATE TABLE `Sales` (
                                                `Id`    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                                `CreatedOn` TEXT NOT NULL,
                                                `UpdatedOn` TEXT,
                                                `Note`  TEXT,
                                                `Price` NUMERIC NOT NULL,
                                                `CreatedBy` INTEGER NOT NULL,
                                                `CarId` INTEGER NOT NULL,
                                                FOREIGN KEY(`CreatedBy`) REFERENCES `Employees`(`Id`),
                                                FOREIGN KEY(`CarId`) REFERENCES `Cars`(`Id`));";

        public static string CreateEmployeeTable = @"CREATE TABLE `Employees` ( 
                                                `Id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                                `CreatedOn` TEXT NOT NULL, 
                                                `UpdatedOn` TEXT, 
                                                `Name` TEXT NOT NULL UNIQUE, 
                                                `Pass` TEXT, 
                                                `Location` TEXT NOT NULL, 
                                                `Roles` TEXT NOT NULL )";

        #endregion

        #region Employee Queries
        public static string SelectEmployee = "Select * from Employees";
        public static string SelectEmployeeWhere = "Select * from Employees Where {0} == {1}";
        #endregion

        #region Sale Queries
        public static string UpdateSale = "";
        public static string CreateSale = @"INSERT INTO `Sales`(`CreatedOn`,`Note`,`Price`,`CreatedBy`,`CarId`)
                                            VALUES(@CreatedOn,@Note,@Price,@CreatedBy,@CarId)";

        public static string SelectSale = @"Select * from Sales";
        public static string SelectSaleWhere = @"SELECT * FROM Sales WHERE {0}=={1}";
        #endregion
    }
}
