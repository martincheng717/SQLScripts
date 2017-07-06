using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLScripts
{
    class TempTable
    {
        //        WITH t AS
        //(
        //SELECT c.ProductKey
        //, c.CustomerKey
        //, rowid = ROW_NUMBER()OVER(PARTITION BY c.ProductKey ORDER BY cm.CustomerKey DESC)
        //FROM CustomerMembership cm
        //LEFT JOIN Membership m ON m.MembershipKey = cm.MembershipKey
        //LEFT JOIN dbo.MembershipGroup mg ON mg.MembershipGroupKey = m.MembershipGroupKey
        //LEFT JOIN dbo.Customer c ON c.CustomerKey = cm.CustomerKey
        // where
        //  --mg.MembershipGroup LIKE '%Walmart bluesky%' 
        // --mg.MembershipGroup like '%gd bank classic everyday%'
        //mg.MembershipGroup like '%card%'
        //)
        //SELECT ProductKey, CustomerKey FROM t
        //WHERE t.rowid =1       --------if you want to get more, please update this to “<=5”
    }

    class TempTable1
    {
//        IF OBJECT_ID('tempdb..#Results') IS NOT NULL
//    DROP TABLE #Results
//IF OBJECT_ID('tempdb..#Products') IS NOT NULL
//       DROP TABLE #Products;
//CREATE TABLE #Products
//(
//  ProductKey smallint
//)
//CREATE TABLE #Results
//(
//      customerkey  int,
//      productKey smallint
//)

//INSERT INTO #Products
//SELECT c.ProductKey
//FROM CustomerMembership cm
//LEFT JOIN Membership m ON m.MembershipKey = cm.MembershipKey
//LEFT JOIN dbo.MembershipGroup mg ON mg.MembershipGroupKey = m.MembershipGroupKey
//LEFT JOIN dbo.Customer c ON c.CustomerKey = cm.CustomerKey
// WHERE
//  MembershipGroup LIKE '%Walmart bluesky%' 
// --mg.MembershipGroup like '%gd bank classic everyday%'
//--mg.MembershipGroup like '%gd bank rewards card%'
//  GROUP BY c.ProductKey

//DECLARE @tmpProductkey smallint

//DECLARE Product_Cursor CURSOR FOR
//SELECT productkey
//FROM #Products
//OPEN Product_Cursor;
//        FETCH NEXT FROM Product_Cursor INTO @tmpProductkey;

//WHILE(@@FETCH_STATUS = 0)
//BEGIN
//IF OBJECT_ID('tempdb..#tmpInfo') IS NOT NULL
//       DROP TABLE #tmpInfo;   
//CREATE TABLE #tmpInfo
//(
//      customerkey  int,
//      productKey smallint
//)
//INSERT into #tmpInfo 
//SELECT TOP 2 customerkey, c.ProductKey
//FROM dbo.Customer c
//WHERE c.ProductKey      = @tmpProductkey
//ORDER by c.CreateDate desc

//INSERT INTO #Results
//SELECT* FROM #tmpInfo ti           

//DROP TABLE #tmpInfo
//FETCH NEXT FROM Product_Cursor INTO @tmpProductkey;
//        END;
//CLOSE Product_Cursor;
//        DEALLOCATE Product_Cursor;

//        SELECT* FROM #Results ;
//DROP TABLE #Results;
//DROP TABLE #Products;

    }
}
