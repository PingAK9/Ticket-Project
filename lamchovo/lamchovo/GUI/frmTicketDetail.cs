using lamchovo.BUS;
using lamchovo.DAO;
using lamchovo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamchovo.GUI
{
    public partial class frmTicketDetail : Form
    {
        public frmTicketDetail()
        {
            InitializeComponent();
        }
        bool isLoad = false;
        private void frmTicket_Load(object sender, EventArgs e)
        {
            cbTypeFilter.ValueMember = "ID";
            cbTypeFilter.DisplayMember = "typet";
            cbTypeFilter.DataSource = TypeTicketBUS.Select();
            //
            gridTypet.ValueMember = "ID";
            gridTypet.DisplayMember = "typet";
            gridTypet.DataSource = TypeTicketBUS.Select();
            gridcbClient.ValueMember = "ID";
            gridcbClient.DisplayMember = "clientt";
            gridcbClient.DataSource = ClientBUS.Select();
            //
            DateTime _now = DateTime.Now;
            DateTime _from = new DateTime(_now.Year, _now.Month, 1);
            DateTime _to = new DateTime(_now.Year, _now.Month, DateTime.DaysInMonth(_now.Year, _now.Month));
            dtFrom.Value = _from;
            dtTo.Value = _to;

            isLoad = true;
            HienThiDanhSach();
        }
        int typeTicket
        {
            get { return (int)cbTypeFilter.SelectedValue; }
        }
        void HienThiDanhSach()
        {
            if (isLoad == false)
            {
                return;
            }
            DataTable _dt = new DataTable();
            if (checkBoxType.Checked == true)
            {
                _dt = TicketBUS.ReportTicket(dtFrom.Value, dtTo.Value, typeTicket);
            }
            else
            {
                _dt = TicketBUS.ReportTicket(dtFrom.Value, dtTo.Value);
            }
            gridView.DataSource = _dt;

        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            string oldPath = Directory.GetCurrentDirectory();
            SaveFileDialog sf = new SaveFileDialog();
            sf.ShowDialog();
            string strFileName = sf.FileName;
            if (strFileName == "")
            {
                return;
            }
            Directory.SetCurrentDirectory(oldPath);
            ExcelWrite myExcel = new ExcelWrite();
            List<string> list = myExcel.DGVToExcel(gridView);
            String filePath = Directory.GetCurrentDirectory() + strFileName;
            myExcel.WriteDateToExcel(strFileName, list, "A1", "D1", "A2");
            MessageBox.Show("Export dữ liệu thành công...", "Thông báo");
            string[] split = strFileName.Split(new char[]{'.'});
            if (split.Length > 1)
            {
                Process.Start(strFileName);
            }
            else
            {
                Process.Start(strFileName + ".xls");
            }
        }
        DataTable GetDataExport()
        {
            DataTable _dt = new DataTable();
            if (checkBoxType.Checked == true)
            {
                _dt = TicketBUS.ReportTicket(dtFrom.Value, dtTo.Value, typeTicket);
            }
            else
            {
                _dt = TicketBUS.ReportTicket(dtFrom.Value, dtTo.Value);
            }
            return _dt;
        }
        public string Puntos(string strValor)
        {

            string strAux = null;
            string strPuntos = null;

            if (strValor.Length == 0) return "";
            strValor = strValor.Replace(Application.CurrentCulture.NumberFormat.NumberGroupSeparator, "");
            strAux = strValor;

            if (strAux.Substring(0, 1) == Application.CurrentCulture.NumberFormat.NegativeSign)
            {
                strAux = strAux.Substring(1);
            }
            strPuntos = strAux;
            strAux = "";
            while (strPuntos.Length > 3)
            {
                strAux = Application.CurrentCulture.NumberFormat.NumberGroupSeparator + strPuntos.Substring(strPuntos.Length - 3, 3) + strAux;
                strPuntos = strPuntos.Substring(0, strPuntos.Length - 3);
            }
            strAux = strPuntos + strAux;
            return strAux;
        }

        private void checkBoxType_CheckedChanged(object sender, EventArgs e)
        {
            cbTypeFilter.Enabled = checkBoxType.Checked;
            HienThiDanhSach();
        }

        private void dtFrom_ValueChanged_1(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void dtTo_ValueChanged_1(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
    }
}
