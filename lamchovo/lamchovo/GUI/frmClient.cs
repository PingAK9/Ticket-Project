using lamchovo.BUS;
using lamchovo.DAO;
using lamchovo.DTO;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace lamchovo.GUI
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        public void refeshForm()
        {
            HienThiDanhSach();
        }
        private void frmClient_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        void HienThiDanhSach()
        {
            gridView.DataSource = ClientBUS.SelectTrim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClientDTO _item = new ClientDTO();
            _item.client = txtClient.Text;
            if (ClientBUS.Insert(_item) == false)
            {
                MessageBox.Show("Dữ liệu nhập vào đã có trong cơ sở dữ liệu", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                HienThiDanhSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ClientDTO _item = new ClientDTO();
            _item.ID = int.Parse(txtID.Text);
            _item.client = txtClient.Text;
            if (ClientBUS.Delete(_item.ID) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                HienThiDanhSach();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ClientDTO _item = new ClientDTO();
            _item.client = txtClient.Text;
            _item.ID = int.Parse(txtID.Text);
            ClientBUS.Update(_item);
            MessageBox.Show("Cập nhật thành công", "Thông báo");
            HienThiDanhSach();
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int row = gridView.SelectedCells[0].RowIndex;
                txtID.Text = gridView.Rows[row].Cells[0].Value.ToString();
                txtClient.Text = gridView.Rows[row].Cells[1].Value.ToString();
            }
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmTicket.instance.refreshFormClient();
        }

        int rowCount;
        int errorCount;
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                rowCount = 0;
                errorCount = 0;
                string oldPath = Directory.GetCurrentDirectory();
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                string strPathName = of.FileName;
                Directory.SetCurrentDirectory(oldPath);
                DataTable dt = ExcelRead.getSheet(strPathName, "Sheet1");
                foreach (DataRow row in dt.Rows)
                {
                    AddRow(row);
                }
                MessageBox.Show("Import " + rowCount + "khách hàng.", "Thông báo");
                //
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đọc file.", "Thông báo");
            }
        }
        void AddRow(DataRow row)
        {
            try
            {
                string _value = row.ItemArray[0].ToString();
                if (_value.Length == 0)
                {
                    errorCount++;
                    return;
                }
                ClientDTO _item = new ClientDTO();
                _item.client = _value;
                if (ClientBUS.Insert(_item))
                {
                    rowCount++;
                }
                else
                {
                    errorCount++;
                }
                
            }
            catch (Exception)
            {
                errorCount++;
            }
        }
    }
}
