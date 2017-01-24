using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lamchovo.BUS;
using lamchovo.DAO;
using lamchovo.DTO;

namespace lamchovo.GUI
{
    public partial class frmPrice : Form
    {
        public frmPrice()
        {
            InitializeComponent();
        }

        public void refeshForm()
        {
            HienThiDanhSach();
        }
        private void frmPrice_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        void HienThiDanhSach()
        {
            gridView.DataSource = PriceBUS.Select();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            PriceDTO _item = new PriceDTO();
            _item.price = int.Parse(txtPrice.Text);
            if (PriceBUS.Insert(_item) == false)
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
            PriceDTO _item = new PriceDTO();
            _item.price = int.Parse(txtPrice.Text);
            if (PriceBUS.Delete(_item) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                HienThiDanhSach();
            }
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            if (gridView.SelectedCells.Count > 0)
            {
                int row = gridView.SelectedCells[0].RowIndex;
                txtPrice.Text = gridView.Rows[row].Cells[0].Value.ToString();
            }
        }

        private void frmPrice_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmTicket.instance.refreshFormPrice();
        }
    }
}
