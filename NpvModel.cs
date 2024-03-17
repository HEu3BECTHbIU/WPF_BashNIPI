using Microsoft.Office.Interop.Excel;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace CountNPV
{
    internal static class NpvModel
    {
        public static double CountNPV(double discount, int year)
        {
            string filename = "data.xlsx";
            string path = Path.GetFullPath(filename);

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[2];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            object[,] valueArray = (object[,])xlRange.get_Value(XlRangeValueDataType.xlRangeValueDefault);

            double npv = 0;
            int row = 2;
            while (Convert.ToInt32(valueArray[row, 1]) < year)
            {
                int cf = Convert.ToInt32(valueArray[row, 2]) - Convert.ToInt32(valueArray[row, 3]);
                npv += (double)cf * (1 / Math.Pow((1.0 + discount), row - 1));
                row++;
            }
            int cf_last = Convert.ToInt32(valueArray[row, 2]) - Convert.ToInt32(valueArray[row, 3]);
            npv += (double)cf_last * (1 / Math.Pow((1.0 + discount), row - 1));

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            return npv;
        }
    }
}
