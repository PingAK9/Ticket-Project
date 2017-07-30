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
    public partial class frmTicket : Form
    {
        static frmTicket _instance;
        public static frmTicket instance { get { return _instance; } }
        public frmTicket()
        {
            _instance = this;
            InitializeComponent();
        }
        bool isLoad = false;
        private void frmTicket_Load(object sender, EventArgs e)
        {
            cbType.ValueMember = "ID";
            cbType.DisplayMember = "typet";
            cbType.DataSource = TypeTicketBUS.Select();
            cbTypeFilter.ValueMember = "ID";
            cbTypeFilter.DisplayMember = "typet";
            cbTypeFilter.DataSource = TypeTicketBUS.Select();
            //
            refreshFormPrice();
            //
            cbClient.ValueMember = "ID";
            cbClient.DisplayMember = "clientt";
            cbClient.DataSource = ClientBUS.Select();
            //
            cbFileFilter.ValueMember = "ID";
            cbFileFilter.DisplayMember = "filet";
            cbFileFilter.DataSource = FileBUS.Select();
            //
            cbFile.ValueMember = "ID";
            cbFile.DisplayMember = "filet";
            cbFile.DataSource = FileBUS.Select();
            //
            gridTypet.ValueMember = "ID";
            gridTypet.DisplayMember = "typet";
            gridTypet.DataSource = TypeTicketBUS.Select();
            gridcbClient.ValueMember = "ID";
            gridcbClient.DisplayMember = "clientt";
            gridcbClient.DataSource = ClientBUS.Select();
            //
            checkClientExport.DataSource = ClientBUS.Select();
            checkClientExport.ValueMember = "ID";
            checkClientExport.DisplayMember = "clientt";
            //
            DateTime _now = DateTime.Now;
            DateTime _from = new DateTime(_now.Year, _now.Month, 1);
            DateTime _to = new DateTime(_now.Year, _now.Month, DateTime.DaysInMonth(_now.Year, _now.Month));
            dtFrom.Value = _from;
            dtTo.Value = _to;

            cbFilter.SelectedIndex = 0;
            isLoad = true;
            HienThiDanhSach();
        }
        public void refreshFormPrice()
        {
            cbPrice.ValueMember = "price";
            cbPrice.DisplayMember = "display";
            DataTable dt = PriceBUS.Select();
            PriceDTO[] item = new PriceDTO[dt.Rows.Count];
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                item[i] = new PriceDTO((int)row.ItemArray[0]);
                i++;
            }
            cbPrice.DataSource = item;
            cbPrice.SelectedIndex = 0;

        }
        public void refreshFormFile()
        {
            cbFileFilter.DataSource = FileBUS.Select();
            cbFile.DataSource = FileBUS.Select();
        }
        public void refreshFormClient()
        {
            cbClient.DataSource = ClientBUS.Select();
            checkClientExport.DataSource = ClientBUS.Select();
            checkClientExport.ValueMember = "ID";
            checkClientExport.DisplayMember = "clientt";
            gridcbClient.DataSource = ClientBUS.Select();
        }
        public void refeshFormType()
        {
            cbType.DataSource = TypeTicketBUS.Select();
            cbTypeFilter.DataSource = TypeTicketBUS.Select();
        }
        public void refeshForm()
        {
            cbType.DataSource = TypeTicketBUS.Select();
            cbTypeFilter.DataSource = TypeTicketBUS.Select();
            refreshFormPrice();
            cbFileFilter.DataSource = FileBUS.Select();
            cbClient.DataSource = ClientBUS.Select();
            cbFile.DataSource = FileBUS.Select();
            checkClientExport.DataSource = ClientBUS.Select();
            checkClientExport.ValueMember = "ID";
            checkClientExport.DisplayMember = "clientt";
            gridcbClient.DataSource = ClientBUS.Select();
        }
        int typeTicket {
            get { return (int)cbTypeFilter.SelectedValue; }
        }
        void HienThiDanhSach()
        {
            if (isLoad == false)
            {
                return;
            }
            DataTable _dt = new DataTable();
            DataTable _dtTotal = new DataTable();
            if (checkBoxType.Checked == true)
            {
                switch (filterBy)
                {
                    case FilterBy.filename:
                        try
                        {
                            _dt = TicketBUS.SelectFile((int)cbFileFilter.SelectedValue, typeTicket);
                            _dtTotal = TicketBUS.SelectFileTotal((int)cbFileFilter.SelectedValue, typeTicket);
                        }
                        catch (Exception)
                        {
                            // file empty
                        }
                        break;
                    case FilterBy.dayTicket:
                        if (checkBoxClient.Checked == true)
                        {
                            _dt = TicketBUS.SelectDayTicket(dtFrom.Value, dtTo.Value, typeTicket);
                            _dtTotal = TicketBUS.SelectDayTicketTotal(dtFrom.Value, dtTo.Value, typeTicket);
                        }
                        else
                        {
                            _dt = TicketBUS.SelectDayTicket(dtFrom.Value, dtTo.Value, typeTicket, ClientCheck());
                            _dtTotal = TicketBUS.SelectDayTicketTotal(dtFrom.Value, dtTo.Value, typeTicket, ClientCheck());
                        }
                        break;
                    case FilterBy.dayOn:
                        if (checkBoxClient.Checked == true)
                        {
                            _dt = TicketBUS.SelectDayOnTicket(dtFrom.Value, dtTo.Value, typeTicket);
                            _dtTotal = TicketBUS.SelectDayOnTicketTotal(dtFrom.Value, dtTo.Value, typeTicket);
                        }
                        else
                        {
                            _dt = TicketBUS.SelectDayOnTicket(dtFrom.Value, dtTo.Value, typeTicket, ClientCheck());
                            _dtTotal = TicketBUS.SelectDayOnTicketTotal(dtFrom.Value, dtTo.Value, typeTicket, ClientCheck());
                        }
                        break;
                }
            }
            else
            {

                switch (filterBy)
                {
                    case FilterBy.filename:
                        try
                        {
                            _dt = TicketBUS.SelectFile((int)cbFileFilter.SelectedValue);
                            _dtTotal = TicketBUS.SelectFileTotal((int)cbFileFilter.SelectedValue);
                        }
                        catch (Exception)
                        {
                            // file empty
                        }
                        break;
                    case FilterBy.dayTicket:
                        if (checkBoxClient.Checked == true)
                        {
                            _dt = TicketBUS.SelectDayTicket(dtFrom.Value, dtTo.Value);
                            _dtTotal = TicketBUS.SelectDayTicketTotal(dtFrom.Value, dtTo.Value);
                        }
                        else
                        {
                            _dt = TicketBUS.SelectDayTicket(dtFrom.Value, dtTo.Value, ClientCheck());
                            _dtTotal = TicketBUS.SelectDayTicketTotal(dtFrom.Value, dtTo.Value, ClientCheck());
                        }
                        break;
                    case FilterBy.dayOn:
                        if (checkBoxClient.Checked == true)
                        {
                            _dt = TicketBUS.SelectDayOnTicket(dtFrom.Value, dtTo.Value);
                            _dtTotal = TicketBUS.SelectDayOnTicketTotal(dtFrom.Value, dtTo.Value);
                        }
                        else
                        {
                            _dt = TicketBUS.SelectDayOnTicket(dtFrom.Value, dtTo.Value, ClientCheck());
                            _dtTotal = TicketBUS.SelectDayOnTicketTotal(dtFrom.Value, dtTo.Value, ClientCheck());
                        }
                        break;
                }
            }
            gridView.DataSource = _dt;
            if (_dtTotal.Rows.Count > 0)
            {
                txtCountTotal.Text = _dtTotal.Rows[0].ItemArray[0].ToString();
                txtPriceTotal.Text = _dtTotal.Rows[0].ItemArray[1].ToString();
            }
            else
            {
                txtCountTotal.Text = "0";
                txtPriceTotal.Text = "0";
            }
            
        }
        public void HienThiDanhSachFileImport(int _id)
        {
            refreshFormPrice();
            cbFileFilter.DataSource = FileBUS.Select();
            cbFile.DataSource = FileBUS.Select();
            cbFilter.SelectedValue = 0;
            cbFileFilter.SelectedValue = _id;
            checkBoxType.Checked = false;
            DataTable _dt = TicketBUS.SelectFile((int)cbFileFilter.SelectedValue);
            DataTable _dtTotal = TicketBUS.SelectFileTotal((int)cbFileFilter.SelectedValue);
            gridView.DataSource = _dt;
            if (_dtTotal.Rows.Count > 0)
            {
                txtCountTotal.Text = _dtTotal.Rows[0].ItemArray[0].ToString();
                txtPriceTotal.Text = _dtTotal.Rows[0].ItemArray[1].ToString();
            }
            else
            {
                txtCountTotal.Text = "0";
                txtPriceTotal.Text = "0";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TicketDTO _item = new TicketDTO();
            _item.day = dtDay.Value;
            try
            {
                _item.count = int.Parse(txtCount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng không đúng", "Thông báo");
                return;
            }
            try
            {
                _item.file = (int)cbFile.SelectedValue;
            }
            catch (FormatException)
            {
                MessageBox.Show("File không đúng", "Thông báo");
                return;
            }
            _item.price = (int)cbPrice.SelectedValue;
            _item.client = (int)cbClient.SelectedValue;
            _item.type = (int)cbType.SelectedValue;
            _item.dayon = dtDayOn.Value;
            if (TicketBUS.Insert(_item) == false)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            HienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int _id;
            try
            {
                _id = int.Parse(txtID.Text);
            }
            catch
            {
                MessageBox.Show("ID không đúng", "Thông báo");
                return;
            }
            if (TicketBUS.Delete(_id) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                HienThiDanhSach();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TicketDTO _item = new TicketDTO();
            try
            {
                _item.ID = int.Parse(txtID.Text);
            }
            catch
            {
                MessageBox.Show("ID không đúng", "Thông báo");
                return;
            }
            _item.day = dtDay.Value;
            try
            {
                _item.count = int.Parse(txtCount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng không đúng", "Thông báo");
                return;
            }

            _item.price = int.Parse(cbPrice.SelectedValue.ToString());
            _item.client = (int)cbClient.SelectedValue;
            _item.file = (int)cbFile.SelectedValue;
            _item.type = (int)cbType.SelectedValue;
            _item.dayon = dtDayOn.Value;

            if (TicketBUS.Update(_item))
            {
                MessageBox.Show("Cập nhật thành công");
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("ID không tồn tại trong CSDL");
            }
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
            ExcelFileWriterTicket myExcel = new ExcelFileWriterTicket();
            DataTable dtMega = GetDataExport(1);
            DataTable dtMax = GetDataExport(2);
            DataTable dtPower = GetDataExport(3);
            String filePath = Directory.GetCurrentDirectory() + strFileName;
            myExcel.WriteDateToExcel(strFileName, dtMega, dtMax, dtPower, "A5", 5);
            MessageBox.Show("Export dữ liệu thành công...", "Thông báo");
            Process.Start(strFileName + ".xlsx");
        }
        DataTable GetDataExport(int _type)
        {
            DataTable _dt = new DataTable();
            switch (filterBy)
            {
                case FilterBy.filename:
                    _dt = TicketBUS.SelectFileExport((int)cbFileFilter.SelectedValue, _type);
                    break;
                case FilterBy.dayTicket:
                    if (checkClientExport.GetItemCheckState(0) == CheckState.Checked)
                    {
                        _dt = TicketBUS.SelectDayTicketExport(dtFrom.Value, dtTo.Value, _type);
                    }
                    else
                    {
                        _dt = TicketBUS.SelectDayTicketExport(dtFrom.Value, dtTo.Value, _type, ClientCheck());
                    }
                    break;
                case FilterBy.dayOn:
                    if (checkClientExport.GetItemCheckState(0) == CheckState.Checked)
                    {
                        _dt = TicketBUS.SelectDayOnTicketExport(dtFrom.Value, dtTo.Value, _type);
                    }
                    else
                    {
                        _dt = TicketBUS.SelectDayOnTicketExport(dtFrom.Value, dtTo.Value, _type, ClientCheck());
                    }
                    break;
            }
            return _dt;
        }

        private void btnXoaFilter_Click(object sender, EventArgs e)
        {
            string _title = "Xóa";
            if (MessageBox.Show(_title, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                switch (filterBy)
                {
                    case FilterBy.filename:
                        TicketBUS.DeleteFile((int)cbFileFilter.SelectedValue);
                        FileBUS.Delete((int)cbFileFilter.SelectedValue);
                        break;
                    case FilterBy.dayTicket:
                        if (checkClientExport.GetItemCheckState(0) == CheckState.Checked)
                        {
                            TicketBUS.DeleteDayTicket(dtFrom.Value, dtTo.Value, typeTicket);
                        }
                        else
                        {
                            TicketBUS.DeleteDayTicket(dtFrom.Value, dtTo.Value, typeTicket, ClientCheck());
                        }
                        break;
                    case FilterBy.dayOn:
                        if (checkClientExport.GetItemCheckState(0) == CheckState.Checked)
                        {
                            TicketBUS.DeleteDayOnTicket(dtFrom.Value, dtTo.Value, typeTicket);
                        }
                        else
                        {
                            TicketBUS.DeleteDayOnTicket(dtFrom.Value, dtTo.Value, typeTicket, ClientCheck());
                        }
                        break;
                }
            }
            MessageBox.Show("Xóa thành công", "Xác nhận", MessageBoxButtons.OK);
            HienThiDanhSach();
        }
        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int row = gridView.SelectedCells[0].RowIndex;
                TicketDTO _item = TicketBUS.Select((int)gridView.Rows[row].Cells[0].Value);
                if (_item != null)
                {
                    txtID.Text = _item.ID.ToString();
                    dtDay.Value = _item.day;
                    txtCount.Text = _item.count.ToString();
                    cbPrice.SelectedValue = _item.price;
                    cbClient.SelectedValue = _item.client;
                    cbFile.SelectedValue = _item.file;
                    cbType.SelectedValue = _item.type;
                    dtDayOn.Value = _item.dayon;
                }
            }
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        FilterBy filterBy {
            get {
                switch (cbFilter.SelectedIndex)
                {
                    case 0:
                        return FilterBy.filename;
                    case 1:
                        return FilterBy.dayTicket;
                    case 2:
                        return FilterBy.dayOn;
                    default:
                        return FilterBy.dayTicket;
                }
            }
        }
        List<int> ClientCheck()
        {
            List<int> _s = new List<int>();
            for (int i = 0; i < checkClientExport.Items.Count; i++)
            {
                if (checkClientExport.GetItemCheckState(i) == CheckState.Checked)
                {
                    DataRowView _dr = (DataRowView)checkClientExport.Items[i];
                    _s.Add((int)_dr.Row.ItemArray[0]);
                }
            }
            return _s;
        }

        private void cbFileFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowUIFilter();
            HienThiDanhSach();
        }
        void ShowUIFilter()
        {
            switch (filterBy)
            {
                case FilterBy.filename:
                    cbFileFilter.Visible = true;
                    checkClientExport.Visible = false;
                    dtFrom.Visible = false;
                    dtTo.Visible = false;
                    lblFrom.Visible = false;
                    lblTo.Visible = false;
                    labelFileName.Visible = true;
                    checkBoxClient.Visible = false;
                    break;
                case FilterBy.dayTicket:
                    cbFileFilter.Visible = false;
                    checkClientExport.Visible = true;
                    dtFrom.Visible = true;
                    dtTo.Visible = true;
                    lblFrom.Visible = true;
                    lblTo.Visible = true;
                    labelFileName.Visible = false;
                    checkBoxClient.Visible = true;
                    break;
                case FilterBy.dayOn:
                    cbFileFilter.Visible = false;
                    checkClientExport.Visible = true;
                    dtFrom.Visible = true;
                    dtTo.Visible = true;
                    lblFrom.Visible = true;
                    lblTo.Visible = true;
                    labelFileName.Visible = false;
                    checkBoxClient.Visible = true;
                    break;
                default:
                    cbFileFilter.Visible = false;
                    checkClientExport.Visible = false;
                    dtFrom.Visible = false;
                    dtTo.Visible = false;
                    lblFrom.Visible = false;
                    lblTo.Visible = false;
                    labelFileName.Visible = true;
                    checkBoxClient.Visible = false;
                    break;
            }
        }

        private void checkClientExport_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkClientExport.SelectedIndex != e.Index)
            {
                return;
            }
            int count = 0;
            if (e.NewValue == CheckState.Checked && checkBoxClient.Checked == false)
            {
                for (int i = 0; i < checkClientExport.Items.Count; i++)
                {
                    if (checkClientExport.GetItemCheckState(i) != CheckState.Checked && e.Index != i)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    checkBoxClient.Checked = true;
                }
            }
            else if (e.NewValue != CheckState.Checked && checkBoxClient.Checked == true)
            {
                checkBoxClient.Checked = false;
            }

            this.BeginInvoke((MethodInvoker)(
            () =>
            HienThiDanhSach()));
        }
        private void checkBoxClient_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxClient.Checked == true)
            {
                for (int i = 0; i < checkClientExport.Items.Count; i++)
                {
                    if (checkClientExport.GetItemCheckState(i) != CheckState.Checked)
                    {
                        checkClientExport.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
            else
            {
                for (int i = 0; i < checkClientExport.Items.Count; i++)
                {
                    if (checkClientExport.GetItemCheckState(i) == CheckState.Checked)
                    {
                        checkClientExport.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImport _frm = new frmImport();
            _frm.ShowDialog();
        }

        private void xóaHếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa toàn bộ vé!", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TicketBUS.DeleteAll();
                FileBUS.DeleteAll();
                refreshFormFile();
                HienThiDanhSach();
            }
        }
        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTicketDetail _frm = new frmTicketDetail();
            _frm.ShowDialog();
        }
        private void fileNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFile _frm = new frmFile();
            _frm.ShowDialog();
        }

        private void giáVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrice _frm = new frmPrice();
            _frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient _frm = new frmClient();
            _frm.ShowDialog();
        }

        private void loạiVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType _frm = new frmType();
            _frm.ShowDialog();
        }

        private void txtPriceTotal_TextChanged(object sender, EventArgs e)
        {
            txtPriceTotal.Text = Puntos(txtPriceTotal.Text);
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
        private void gridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridView.Columns[e.ColumnIndex].DataPropertyName != "pricet")
            {
                return;
            }

            DataView dv = null;
            CurrencyManager cm = (CurrencyManager)(gridView.BindingContext[gridView.DataSource, gridView.DataMember]);

            if (cm.List is BindingSource)
            {
                // In case of BindingSource it may be chain of BindingSources+relations
                BindingSource bs = (BindingSource)cm.List;
                while (bs.List is BindingSource)
                { bs = bs.List as BindingSource; }

                if (bs.List is DataView)
                { dv = bs.List as DataView; }
            }
            else if (cm.List is DataView)
            {
                // dgv bind to the DataView, Table or DataSet+"tablename"
                dv = cm.List as DataView;
            }

            if (dv != null)
            {
                dv.Sort = "pricet ASC, dayt ASC";
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }

    public enum FilterBy
    {
        filename,
        dayTicket,
        dayOn
    }
}
