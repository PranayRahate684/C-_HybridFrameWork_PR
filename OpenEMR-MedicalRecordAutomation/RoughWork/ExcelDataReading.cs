using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEMR_MedicalRecordAutomation.RoughWork
{
    public class ExcelDataReading
    {
        [Test]
        public void ReadexcelData()
        { 
        var wb = new XLWorkbook (@"C:\\AutomationWithC#\\AutomationFrameWorkSolution\\OpenEMR-MedicalRecordAutomation\\TestData\\OpenEMR_TestData.xlsx");
            var sheet=wb.Worksheet("LoginUserTest");//getting into sheet
            var range = sheet.RangeUsed();//get rows which has data in excel

            for (int rows = 2; rows <= 3; rows++)
            {
                for (int cols = 1; cols <= 3; cols++)
                {
                    var cellvalue = range.Cell(rows, cols).GetString();
                    Console.WriteLine(cellvalue);
                }
            }
            wb.Dispose();
        }
    }
}
