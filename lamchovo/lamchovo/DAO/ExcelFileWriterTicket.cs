using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.Data;

namespace lamchovo.DAO
{
    public class ExcelFileWriterTicket
    {
        private Microsoft.Office.Interop.Excel.Application _excelApplication = null;
        private Microsoft.Office.Interop.Excel.Workbooks _workBooks = null;
        private Microsoft.Office.Interop.Excel._Workbook _workBook = null;
        private object _value = Missing.Value;
        private Microsoft.Office.Interop.Excel.Sheets _excelSheets = null;
        private Microsoft.Office.Interop.Excel._Worksheet _excelSheet1 = null;
        private Microsoft.Office.Interop.Excel._Worksheet _excelSheet2 = null;
        private Microsoft.Office.Interop.Excel._Worksheet _excelSheet3 = null;
        private Microsoft.Office.Interop.Excel.Range _excelRange1 = null;
        private Microsoft.Office.Interop.Excel.Range _excelRange2 = null;
        private Microsoft.Office.Interop.Excel.Range _excelRange3 = null;
        private Microsoft.Office.Interop.Excel.Font _excelFont = null;
        
        /// <summary>
        public int colCount1 { get; set; }
        public int colCount2 { get; set; }
        public int colCount3 { get; set; }
        public int rowCount1 { get; set; }
        public int rowCount2 { get; set; }
        public int rowCount3 { get; set; }

        protected List<string> list1;
        protected List<string> list2;
        protected List<string> list3;

        public ExcelFileWriterTicket()
        {
            this.rowCount1 = 0;
            this.rowCount2 = 0;
            this.rowCount3 = 0;
            this.colCount1 = 0;
            this.colCount2 = 0;
            this.colCount3 = 0;
        }
        /// <summary>
        /// api through which data from the list can be write to an excel
        /// kind of a Template Method Pattern is used here
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="holdingsList"></param>
        public void WriteDateToExcel(string fileName, DataTable dtMega, DataTable dtMax, DataTable dtPower, string startColumnOfData, int starRow)
        {
            TicketDataToExcel(dtMega, starRow, 1);
            TicketDataToExcel(dtMax, starRow, 2);
            TicketDataToExcel(dtPower, starRow, 3);
            this.ActivateExcel();
            this.FillRowData(list1, list2, list3);
            this.FillExcelWithData(startColumnOfData);
            this.SaveExcel(fileName);
        }

        /// <summary>
        /// activate the excel application
        /// </summary>
        /// 
        protected void ActivateExcel()
        {
            _excelApplication = new Microsoft.Office.Interop.Excel.Application();
            _workBooks = (Microsoft.Office.Interop.Excel.Workbooks)_excelApplication.Workbooks;
            _workBook = (Microsoft.Office.Interop.Excel._Workbook)(_workBooks.Open(Environment.CurrentDirectory + @"\template.xlsx"));
            _excelSheets = (Microsoft.Office.Interop.Excel.Sheets)_workBook.Worksheets;
            _excelSheet1 = (Microsoft.Office.Interop.Excel._Worksheet)(_excelSheets.get_Item(2));
            _excelSheet2 = (Microsoft.Office.Interop.Excel._Worksheet)(_excelSheets.get_Item(3));
            _excelSheet3 = (Microsoft.Office.Interop.Excel._Worksheet)(_excelSheets.get_Item(4));
        }
        /// Fill the excel sheet with data along with the position specified
        /// </summary>
        /// <param name="columnrow"></param>
        /// <param name="data"></param>
        private void FillExcelWithData(string startColumn)
        {
            _excelRange1 = _excelSheet1.get_Range(startColumn, _value);
            _excelRange1 = _excelRange1.get_Resize(rowCount1 + 1, colCount1);
            _excelRange1.set_Value(Missing.Value, ExcelData1);
            _excelRange1.EntireColumn.AutoFit();
            //
            _excelRange2 = _excelSheet2.get_Range(startColumn, _value);
            _excelRange2 = _excelRange2.get_Resize(rowCount2 + 1, colCount2);
            _excelRange2.set_Value(Missing.Value, ExcelData2);
            _excelRange2.EntireColumn.AutoFit();
            //
            _excelRange3 = _excelSheet3.get_Range(startColumn, _value);
            _excelRange3 = _excelRange3.get_Resize(rowCount3 + 1, colCount3);
            _excelRange3.set_Value(Missing.Value, ExcelData3);
            _excelRange3.EntireColumn.AutoFit();
        }
        /// <summary>
        /// save the excel sheet to the location with file name
        /// </summary>
        /// <param name="fileName"></param>
        protected void SaveExcel(string fileName)
        {
            _workBook.SaveAs(fileName, 51, _value,
                _value, _value, _value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                _value, _value, _value, _value, null);
            _workBook.Close(false, _value, _value);
            _excelApplication.Quit();
        }
        /// <summary>
        /// make the range of rows bold
        /// </summary>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        private void BoldRow(string row1, string row2, int _index)
        {
            if (_index == 1)
            {
                _excelRange1 = _excelSheet1.get_Range(row1, row2);
                _excelFont = _excelRange1.Font;
                _excelFont.Bold = true;
            }
            else if (_index == 2)
            {
                _excelRange2 = _excelSheet2.get_Range(row1, row2);
                _excelFont = _excelRange2.Font;
                _excelFont.Bold = true;
            }
            else if (_index == 3)
            {
                _excelRange3 = _excelSheet3.get_Range(row1, row2);
                _excelFont = _excelRange3.Font;
                _excelFont.Bold = true;
            }
        }

        protected void Merge(int col1, int row1, int col2, int row2, int _index)
        {
            if (_index == 1)
            {
                _excelRange1 = _excelSheet1.get_Range(_excelSheet1.Cells[col1, row1], _excelSheet1.Cells[col1, row2]);
                _excelRange1.Merge(true);
            }
            else if(_index == 2)
            {
                _excelRange2 = _excelSheet2.get_Range(_excelSheet2.Cells[col1, row1], _excelSheet2.Cells[col1, row2]);
                _excelRange2.Merge(true);
            }
            else if (_index == 3)
            {
                _excelRange3 = _excelSheet3.get_Range(_excelSheet3.Cells[col1, row1], _excelSheet3.Cells[col1, row2]);
                _excelRange3.Merge(true);
            }
        }
        
        /// user have to parse the data from the list and pass each data along with the
        /// column and row name to the base fun, FillExcelWithData().
        /// </summary>
        /// <param name="list"></param>
        public void FillRowData(List<String> list1, List<String> list2, List<String> list3)
        {
            myExcelData1 = new object[rowCount1 + 1, colCount1];
            for (int row = 0; row < rowCount1; row++)
            {
                for (int col = 0; col < colCount1; col++)
                {
                    myExcelData1[row, col] = list1[row * colCount1 + col];
                }
            }
            //
            myExcelData2 = new object[rowCount2 + 1, colCount2];
            for (int row = 0; row < rowCount2; row++)
            {
                for (int col = 0; col < colCount2; col++)
                {
                    myExcelData2[row, col] = list2[row * colCount2 + col];
                }
            }
            //
            myExcelData3 = new object[rowCount3 + 1, colCount3];
            for (int row = 0; row < rowCount3; row++)
            {
                for (int col = 0; col < colCount3; col++)
                {
                    myExcelData3[row, col] = list3[row * colCount3 + col];
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        void TicketDataToExcel(DataTable dgv, int start, int index)
        {
            if (dgv.Rows.Count == 0)
            {
                if (index == 1)
                {
                    rowCount1 = 1;
                    colCount1 = 1;
                    list1 = new List<string>();
                    list1.Add("");
                }
                else if (index == 2)
                {
                    rowCount2 = 1;
                    colCount2 = 1;
                    list2 = new List<string>();
                    list2.Add("");
                }
                else if(index == 3)
                {
                    rowCount3 = 1;
                    colCount3 = 1;
                    list3 = new List<string>();
                    list3.Add("");
                }
                return;
            }
            int rowNumber = dgv.Rows.Count;
            int colNumber = 5;
            List<String> myList = new List<String>();
            string current_day = dgv.Rows[0].ItemArray[0].ToString();
            int startRow = start;
            int startRowDay = start;
            int currentRow = start;
            foreach (DataRow row in dgv.Rows)
            {
                if (current_day != row.ItemArray[0].ToString())
                {
                    myList.Add("Cộng ngày");
                    myList.Add(current_day);
                    myList.Add("=+SUM(C" + startRowDay + ":C" + (currentRow - 1) + ")");
                    myList.Add("=+SUM(D" + startRowDay + ":D" + (currentRow - 1) + ")");
                    myList.Add("");
                    rowNumber++;
                    currentRow++;
                    startRowDay = currentRow;
                    current_day = row.ItemArray[0].ToString();
                }

                myList.Add(row.ItemArray[0].ToString());
                myList.Add(row.ItemArray[1].ToString());
                myList.Add(row.ItemArray[2].ToString());
                myList.Add("= B" + currentRow + "*C" + currentRow);
                myList.Add("");
                currentRow++;
            }
            // Tong ngay cuoi
            myList.Add("Cộng ngày");
            myList.Add(current_day);
            myList.Add("=+SUM(C" + startRowDay + ":C" + (currentRow - 1) + ")");
            myList.Add("=+SUM(D" + startRowDay + ":D" + (currentRow - 1) + ")");
            myList.Add("");
            rowNumber++;
            currentRow++;
            startRowDay = currentRow;
            // Tong hêt
            myList.Add("Tổng Cộng");
            myList.Add("");
            myList.Add("=+SUM(C" + startRow + ":C" + (currentRow - 1) + ")/2");
            myList.Add("=+SUM(D" + startRow + ":D" + (currentRow - 1) + ")/2");
            myList.Add("");
            rowNumber++;
            if (index == 1)
            {
                rowCount1 = rowNumber;
                colCount1 = colNumber;
                list1 = myList;
            }
            else if (index == 2)
            {
                rowCount2 = rowNumber;
                colCount2 = colNumber;
                list2 = myList;
            }
            else if (index == 3)
            {
                rowCount3 = rowNumber;
                colCount3 = colNumber;
                list3 = myList;
            }
            //
        }

        /// <summary>
        /// get the data of object which will be saved to the excel sheet
        /// </summary>
        public object[,] myExcelData1;
        public object[,] myExcelData2;
        public object[,] myExcelData3;
        public object[,] ExcelData1
        {
            get
            {
                return myExcelData1;
            }
        }
        public object[,] ExcelData2
        {
            get
            {
                return myExcelData2;
            }
        }
        public object[,] ExcelData3
        {
            get
            {
                return myExcelData3;
            }
        }
    }
}
