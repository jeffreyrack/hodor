using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace CSUSM.CS441.SheriffHodor.Data
{
    class ExcelHandler
    {
        public static void createExcelSheet(List<User> users)
        {
            int i = 1;
            Application xlApp;
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[i, 1] = "Name";
            xlWorkSheet.Cells[i, 2] = "Group";
            xlWorkSheet.Cells[i, 3] = "Percentage";
            ++i;
            foreach(Data.User user in users)
            {
                xlWorkSheet.Cells[i, 1] = user.Name;
                xlWorkSheet.Cells[i, 2] = user.GroupName;
         //       xlWorkSheet.Cells[i, 3] = user.Percentages;
                ++i;
            }
            xlWorkBook.SaveAs(Global.UsersFilePath + "Sheriff_Hodor.xls", XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }
    }
}
