using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_QLNH
{
    public partial class QLMon_UC : UserControl
    {
        public QLMon_UC()
        {
            InitializeComponent();
        }
        DOUONG monan = new DOUONG();
        public void fillGrid(SqlCommand command)
        {

            dataGridViewQlMon.ReadOnly = true;

            dataGridViewQlMon.RowTemplate.Height = 80;
            dataGridViewQlMon.DataSource = monan.getMonAn(command);


            dataGridViewQlMon.AllowUserToAddRows = false;

            
            labelSoMon.Text = "Số món ăn: " + dataGridViewQlMon.Rows.Count;
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            int s = 1 + dataGridViewQlMon.Rows.Count;
            textBoxIdMon.Text = "TD" + s;
            textBoxIdMon.Enabled = false;
            
            buttonEdit.Enabled = false;
            ButtonRemove.Enabled = false;
            buttonTim.Enabled = false;
            textBoxSearch.Enabled = false;
        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = textBoxIdMon.Text;
                string tenban = TextBoxTenMon.Text;
                float giaban = Convert.ToInt32(textBoxGiaThanh.Text);
                string nguyenlieu = TextBoxNguyenLieu.Text;
                int soluong = Convert.ToInt32(TextBoxSL.Text);


                if (tenban.Trim() == "")
                {
                    MessageBox.Show("Thêm tên món ăn", "Add Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (monan.checkTenMonAn(tenban))
                {
                    if (monan.insertMonAn(Id, tenban, giaban, nguyenlieu, soluong))
                    {
                        MessageBox.Show("Món ăn mới đã được thêm vào", "Add Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Món ăn chưa được thêm", "Add Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Món ăn này đã có", "Add Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Menu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT Id as N'Mã Món Ăn', tenmon as N'Tên Món', giamon as N'Giá Món', nguyenlieu as N'Nguyên Liệu', soluong as N'Số Lượng' FROM QLMonAn"));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            


            try
            {
                string tenban = TextBoxTenMon.Text;
                float giaban = Convert.ToInt32(textBoxGiaThanh.Text);
                string nguyenlieu = TextBoxNguyenLieu.Text;
                int soluong = Convert.ToInt32(TextBoxSL.Text);
                if (monan.updateMonAn(tenban, giaban, nguyenlieu, soluong))
                {
                    MessageBox.Show("Thông tin món ăn đã được cập nhật", "Edit Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Món ăn chưa được cập nhật", "Edit Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Menu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid(new SqlCommand("SELECT Id as N'Mã Món Ăn', tenmon as N'Tên Món', giamon as N'Giá Món', nguyenlieu as N'Nguyên Liệu', soluong as N'Số Lượng' FROM QLMonAn"));
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string tenmon = TextBoxTenMon.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá món ăn này ??", "Delete Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    if (monan.deleteMonAn(tenmon))
                    {
                        MessageBox.Show("Món ăn đã xoá thành công", "Remove Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Món ăn chưa được xoá", "Remove Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy nhập ID hợp lệ", "Remove Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid(new SqlCommand("SELECT Id as N'Mã Món Ăn', tenmon as N'Tên Món', giamon as N'Giá Món', nguyenlieu as N'Nguyên Liệu', soluong as N'Số Lượng' FROM QLMonAn"));
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBoxIdMon.Text = "";
            TextBoxTenMon.Text = "";
            TextBoxSL.Text = "";
            textBoxGiaThanh.Text = "";
            TextBoxNguyenLieu.Text = "";
            buttonEdit.Enabled = true;
            ButtonRemove.Enabled = true;
            buttonTim.Enabled = true;
            textBoxSearch.Enabled = true;

            fillGrid(new SqlCommand("SELECT Id as N'Mã Món Ăn', tenmon as N'Tên Món', giamon as N'Giá Món', nguyenlieu as N'Nguyên Liệu', soluong as N'Số Lượng' FROM QLMonAn"));
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            if (search.Trim() == "Nhập Tên_SL_Giá")
            {
                MessageBox.Show("Nhập Tên_SL_Giá", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT Id as N'Mã Món Ăn', tenmon as N'Tên Món', giamon as N'Giá Món', nguyenlieu as N'Nguyên Liệu', soluong as N'Số Lượng' FROM QLMonAn WHERE CONCAT(tenmon,giamon,soluong) LIKE '%" + textBoxSearch.Text + "%'");
                fillGrid(command);
                TextBoxTenMon.Text = dataGridViewQlMon.CurrentRow.Cells[1].Value.ToString();
                textBoxGiaThanh.Text = dataGridViewQlMon.CurrentRow.Cells[2].Value.ToString();
                TextBoxNguyenLieu.Text = dataGridViewQlMon.CurrentRow.Cells[3].Value.ToString();
                TextBoxSL.Text = dataGridViewQlMon.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void textBoxIdMon_Leave(object sender, EventArgs e)
        {
            if (textBoxIdMon.Text == "")
            {
                textBoxIdMon.Text = "New ID";
                textBoxIdMon.ForeColor = Color.Black;
            }
        }

        private void textBoxIdMon_Enter(object sender, EventArgs e)
        {
            if (textBoxIdMon.Text == "New ID")
            {
                textBoxIdMon.Text = "";
                textBoxIdMon.ForeColor = Color.Black;
            }
        }

        private void TextBoxTenMon_Leave(object sender, EventArgs e)
        {
            if (TextBoxTenMon.Text == "")
            {
                TextBoxTenMon.Text = "Tên Món";
                TextBoxTenMon.ForeColor = Color.Black;
            }
        }

        private void TextBoxTenMon_Enter(object sender, EventArgs e)
        {
            if (TextBoxTenMon.Text == "Tên Món")
            {
                TextBoxTenMon.Text = "";
                TextBoxTenMon.ForeColor = Color.Black;
            }
        }

        private void textBoxGiaThanh_Leave(object sender, EventArgs e)
        {
            if (textBoxGiaThanh.Text == "")
            {
                textBoxGiaThanh.Text = "Giá Thành";
                textBoxGiaThanh.ForeColor = Color.Black;
            }
        }

        private void textBoxGiaThanh_Enter(object sender, EventArgs e)
        {
            if (textBoxGiaThanh.Text == "Giá Thành")
            {
                textBoxGiaThanh.Text = "";
                textBoxGiaThanh.ForeColor = Color.Black;
            }
        }

        private void TextBoxNguyenLieu_Leave(object sender, EventArgs e)
        {
            if (TextBoxNguyenLieu.Text == "")
            {
                TextBoxNguyenLieu.Text = "Nguyên Liệu";
                TextBoxNguyenLieu.ForeColor = Color.Black;
            }
        }

        private void TextBoxNguyenLieu_Enter(object sender, EventArgs e)
        {
            if (TextBoxNguyenLieu.Text == "Nguyên Liệu")
            {
                TextBoxNguyenLieu.Text = "";
                TextBoxNguyenLieu.ForeColor = Color.Black;
            }
        }

        private void TextBoxSL_Leave(object sender, EventArgs e)
        {
            if (TextBoxSL.Text == "")
            {
                TextBoxSL.Text = "Số Lượng";
                TextBoxSL.ForeColor = Color.Black;
            }
        }

        private void TextBoxSL_Enter(object sender, EventArgs e)
        {
            if (TextBoxSL.Text == "Số Lượng")
            {
                TextBoxSL.Text = "";
                TextBoxSL.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Nhập Tên_SL_Giá";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Nhập Tên_SL_Giá")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void QLMon_UC_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT Id as N'Mã Món Ăn', tenmon as N'Tên Món', giamon as N'Giá Món', nguyenlieu as N'Nguyên Liệu', soluong as N'Số Lượng' FROM QLMonAn"));


            textBoxIdMon.ForeColor = Color.Black;
            textBoxIdMon.Text = "New ID";
            textBoxIdMon.Leave += new EventHandler(textBoxIdMon_Leave);
            textBoxIdMon.Enter += new EventHandler(textBoxIdMon_Enter);

            YeuCau();
        }
        public void YeuCau()
        {
            TextBoxTenMon.ForeColor = Color.Black;
            TextBoxTenMon.Text = "Tên Món";
            TextBoxTenMon.Leave += new EventHandler(TextBoxTenMon_Leave);
            TextBoxTenMon.Enter += new EventHandler(TextBoxTenMon_Enter);

            TextBoxSL.ForeColor = Color.Black;
            TextBoxSL.Text = "Số Lượng";
            TextBoxSL.Leave += new EventHandler(TextBoxSL_Leave);
            TextBoxSL.Enter += new EventHandler(TextBoxSL_Enter);

            textBoxGiaThanh.ForeColor = Color.Black;
            textBoxGiaThanh.Text = "Giá Thành";
            textBoxGiaThanh.Leave += new EventHandler(textBoxGiaThanh_Leave);
            textBoxGiaThanh.Enter += new EventHandler(textBoxGiaThanh_Enter);

            TextBoxNguyenLieu.ForeColor = Color.Black;
            TextBoxNguyenLieu.Text = "Nguyên Liệu";
            TextBoxNguyenLieu.Leave += new EventHandler(TextBoxNguyenLieu_Leave);
            TextBoxNguyenLieu.Enter += new EventHandler(TextBoxNguyenLieu_Enter);

            textBoxSearch.ForeColor = Color.Black;
            textBoxSearch.Text = "Nhập Tên_SL_Giá";
            textBoxSearch.Leave += new EventHandler(textBoxSearch_Leave);
            textBoxSearch.Enter += new EventHandler(textBoxSearch_Enter);
        }
        private void buttonKtraSL_Click(object sender, EventArgs e)
        {
            KiemTraSLForm ktra = new KiemTraSLForm();
            ktra.Show(this);
        }

        private void dataGridViewQlMon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxTenMon.Text = dataGridViewQlMon.CurrentRow.Cells[1].Value.ToString();
            TextBoxSL.Text = dataGridViewQlMon.CurrentRow.Cells[4].Value.ToString();
            textBoxGiaThanh.Text = dataGridViewQlMon.CurrentRow.Cells[2].Value.ToString();
            TextBoxNguyenLieu.Text = dataGridViewQlMon.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
