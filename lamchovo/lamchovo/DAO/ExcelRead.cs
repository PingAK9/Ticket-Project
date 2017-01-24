using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace lamchovo.DAO
{
    class ExcelRead
    {
        public static DataTable getSheet(String filePath, String sheetName)
        {
            //String sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + filePath + "; Extended Properties=Excel 8.0;";
            String sConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + filePath + "; Extended Properties=\"Excel 12.0; HDR = YES\"";
            OleDbConnection objConn = new OleDbConnection(sConnectionString);
            objConn.Open();
            OleDbCommand objCmdSelect = new OleDbCommand("SELECT * FROM [" + sheetName + "$]", objConn);
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
            objAdapter1.SelectCommand = objCmdSelect;
            DataTable dt = new DataTable();
            objAdapter1.Fill(dt);
            objConn.Close();
            return dt;
        }
    }
}
