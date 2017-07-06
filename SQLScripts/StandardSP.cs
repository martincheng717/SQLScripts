using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLScripts
{
    class StandardSP
    {
//        GO

//IF OBJECT_ID('dbo.uspGetEmployeeDetails') IS NULL -- Check if SP Exists
// EXEC('CREATE PROCEDURE dbo.uspGetEmployeeDetails AS SET NOCOUNT ON;') -- Create dummy/empty SP
//GO

//ALTER PROCEDURE dbo.uspGetEmployeeDetails -- Alter the SP Always
// @EmployeeID INT
//AS
//BEGIN


// SET NOCOUNT ON;

//        SELECT
//         HRE.EmployeeID
       
//         , PC.FirstName + ' ' + PC.LastName AS EmployeeName
       
//         , HRE.Title AS EmployeeTitle
       
//         , PC.EmailAddress AS EmployeeEmail
       
//         , PC.Phone AS EmployeePhone
//        FROM
       
//         HumanResources.Employee AS HRE
//         LEFT JOIN Person.Contact AS PC
//          ON HRE.ContactID = PC.ContactID
       
//        WHERE HRE.EmployeeID = @EmployeeID
       

//       END
//       GO
       

//       go
//       GRANT EXECUTE ON dbo….. TO user_ExecSP
//       go
    }
}
