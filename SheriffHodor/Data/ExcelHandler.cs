/* ExcelHandler.cs
 * Purpose: The purpose of this class is to handle all of the functionality for exporting user data into an excel spreadsheet.
 * 
 * Version - 3.0.0 - 5/4/2014 - Initial Version/Draft.
 */
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
            int gameIndex = 1;
            Application xlApp;
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            Worksheet gameSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            gameSheet = xlWorkBook.Worksheets.get_Item(1);
            gameSheet.Name = "Games";
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.Add();
            xlWorkSheet.Name = "Users";
            xlWorkSheet.Cells[i, 1] = "Name";
            xlWorkSheet.Cells[i, 2] = "Group";
            xlWorkSheet.Cells[i, 3] = "Total Percentage";
            xlWorkSheet.Cells[i, 4] = "Total Coins";
            gameSheet.Cells[gameIndex, 1] = "Name";
            gameSheet.Cells[gameIndex, 2] = "Date Taken";
            gameSheet.Cells[gameIndex, 3] = "Correct Answers";
            gameSheet.Cells[gameIndex, 4] = "Total Questions";
            ++i;
            ++gameIndex;
            foreach(Data.User user in users)
            {
                if (user.Status == User.UserType.Teacher) continue;
                xlWorkSheet.Cells[i, 1] = user.Name;
                xlWorkSheet.Cells[i, 2] = user.GroupName;
                xlWorkSheet.Cells[i, 3] = user.TotalPercentage;
                xlWorkSheet.Cells[i, 4] = user.TotalCoins;
                foreach(Data.GameRecord record in user.PreviousGames)
                {
                    gameSheet.Cells[gameIndex, 1] = user.Name;
                    gameSheet.Cells[gameIndex, 2] = record.dateTaken.ToLongDateString() + " " + record.dateTaken.ToLongTimeString();
                    gameSheet.Cells[gameIndex, 3] = record.numCorrect.ToString();
                    gameSheet.Cells[gameIndex, 4] = record.numProblems.ToString();
                    ++gameIndex;
                }
                ++i;
            }
            xlWorkSheet.Columns.AutoFit();
            gameSheet.Columns.AutoFit();
            try
            {
                System.Windows.Forms.SaveFileDialog save = new System.Windows.Forms.SaveFileDialog();
                save.DefaultExt = "xls";
                save.Filter = "Excel Spreadsheet(*.xls)|*.*";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    xlWorkBook.SaveAs(save.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                }
            } catch(Exception e)
            {
                // TODO: What to do when the file handling fails.
            }
            xlWorkBook.Close(false, misValue, misValue);
            xlApp.Quit();
        }
    }
}
