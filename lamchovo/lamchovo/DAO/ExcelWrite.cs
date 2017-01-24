using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using System.Windows.Forms;


namespace lamchovo.DAO
{
    class ExcelWrite : ExcelFileWriter<String>
    {
        public ExcelWrite(int rowNumber, int colNumber)
        {
            this.rowNumber = rowNumber;
            this.colNumber = colNumber;
        }

        public ExcelWrite()
        {
            this.rowNumber = 0;
            this.colNumber = 0;
        }

        public object[,] myExcelData;

        private object[] _headers;
        public override object[] Headers
        {
            get
            {
                return _headers;
            }
            set
            {
                _headers = value;
            }
        }

        public override void FillRowData(List<String> list)
        {
            myExcelData = new object[RowCount + 1, ColumnCount];
            for (int row = 0; row < RowCount; row++)
            {
                for (int col = 0; col < ColumnCount; col++)
                {
                    myExcelData[row, col] = list[row * ColumnCount + col];
                }
            }
        }

        public List<String> DGVToExcel(DataGridView dgv)
        {
            List<String> myList = new List<String>();

            //doc du lieu tu datagridview bo vao excel
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    myList.Add(dgv.Rows[i].Cells[j].Value.ToString());
                }
            }
            colNumber = dgv.ColumnCount;
            rowNumber = dgv.RowCount;

            List<object> header = new List<object>();
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                header.Add(dgv.Columns[i].HeaderText);
            }
            Headers = new object[header.Count];
            header.CopyTo(Headers);

            return myList;
        }
        string current_day = "";
        int startRow = 1;
        int startRowDay = 1;
        int currentRow = 1;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public List<String> TicketDataToExcel(DataTable dgv, int start)
        {
            colNumber = 5;
            rowNumber = dgv.Rows.Count;
            List<String> myList = new List<String>();
            current_day = dgv.Rows[0].ItemArray[0].ToString();
            startRow = start;
            startRowDay = start;
            currentRow = start;
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
            //
            List<object> header = new List<object>();
            header.Add("'(1)");
            header.Add("'(2)");
            header.Add("'(3)");
            header.Add("'(4)");
            header.Add("'(5)");
            Headers = new object[header.Count];
            header.CopyTo(Headers);

            return myList;
        }
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public List<String> TicketErrorDataToExcel(DataTable dgv, int start)
        {
            colNumber = 5;
            rowNumber = dgv.Rows.Count;
            List<String> myList = new List<String>();
            current_day = dgv.Rows[0].ItemArray[0].ToString();
            startRow = start;
            startRowDay = start;
            currentRow = start;
            foreach (DataRow row in dgv.Rows)
            {
                if (current_day != row.ItemArray[0].ToString())
                {
                    current_day = row.ItemArray[0].ToString();
                    myList.Add("Cộng ngày");
                    myList.Add(current_day);
                    myList.Add("=+SUM(C" + startRowDay + ":C" + (currentRow - 1) + ")");
                    myList.Add("=+SUM(D" + startRowDay + ":D" + (currentRow - 1) + ")");
                    myList.Add("");
                    rowNumber++;
                    currentRow++;
                    startRowDay = currentRow;
                }

                myList.Add(row.ItemArray[0].ToString());
                myList.Add(row.ItemArray[1].ToString());
                myList.Add(row.ItemArray[2].ToString());
                myList.Add("= B" + currentRow + "*C" + currentRow);
                myList.Add(row.ItemArray[3].ToString());
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
            //
            List<object> header = new List<object>();
            header.Add("'(1)");
            header.Add("'(2)");
            header.Add("'(3)");
            header.Add("'(4)");
            header.Add("'(5)");
            Headers = new object[header.Count];
            header.CopyTo(Headers);

            return myList;
        }
        public override object[,] ExcelData
        {
            get
            {
                return myExcelData;
            }
        }

    }
}
