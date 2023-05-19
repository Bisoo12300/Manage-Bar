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
    public partial class KiemTraSLForm : Form
    {
        public KiemTraSLForm()
        {
            InitializeComponent();
        }
        HoaDon hoadon = new HoaDon();
        private void KiemTraSLForm_Load(object sender, EventArgs e)
        {
            //lay thong tin tenmon
            comboBoxTenMon.DataSource = hoadon.getHoaDon(new SqlCommand("SELECT * FROM QLMonAn"));
            comboBoxTenMon.DisplayMember = "tenmon";
            comboBoxTenMon.ValueMember = "Id";

        }

        private void comboBoxTenMon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTenMon.Text.Trim() == "Cocktal Martini")
            {
                labelCongThuc.Text = "Mỗi Ly Cocktal Martini Được Làm Từ: 2 Cục Đá, 4ml Whiskey, 5ml Vodka";
            }
            else if (comboBoxTenMon.Text.Trim() == "Mojito")
            {
                labelCongThuc.Text = "Mỗi Ly Mojito Được Làm Từ:  3 Cục Đá, 2ml Whiskey, 7ml Vodka";
            }
            else if (comboBoxTenMon.Text.Trim() == "Cosmopolitan")
            {
                labelCongThuc.Text = "Mỗi Ly Cosmopolitan Được Làm Từ: 1 Cục Đá, 4ml Whiskey, 3ml Vodka";
            }
            else
            {
                labelCongThuc.Text = "Mỗi Ly " + comboBoxTenMon.Text.Trim() + " Được Làm Từ: 3 Cục Đá, 5ml Whiskey, 5ml Vodka";
            }
        }
        public int TimMin(int a, int b, int c)
        {
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }
        private void buttonKtraSL_Click(object sender, EventArgs e)
        {
            if (textBoxTinhBot.Text == "" || textBoxThit.Text == "" || textBoxRau.Text == "")
            {
                MessageBox.Show("Không Thể Để Trống Dữ Liệu Input Kiểm Tra");
            }
            else if (textBoxRau.Text != "" && textBoxThit.Text != "" && textBoxRau.Text != "")
            {
                if (comboBoxTenMon.Text.Trim() == "Cocktail Martini")
                {
                    if (Convert.ToInt32(textBoxRau.Text) < 2 || Convert.ToInt32(textBoxTinhBot.Text) < 4 || Convert.ToInt32(textBoxThit.Text) < 5)
                    {
                        labelKtra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện " + comboBoxTenMon.Text.Trim();
                    }
                    else if (Convert.ToInt32(textBoxRau.Text) >= 2 && Convert.ToInt32(textBoxTinhBot.Text) >= 4 && Convert.ToInt32(textBoxThit.Text) >= 5)
                    {
                        int slrau = Convert.ToInt32(textBoxRau.Text) / 2;
                        int sltinhbot = Convert.ToInt32(textBoxTinhBot.Text) / 4;
                        int slthit = Convert.ToInt32(textBoxThit.Text) / 5;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        labelKtra.Text = "Ta Có Thể Tạo Ra " + kq + " Ly " + comboBoxTenMon.Text.Trim();

                    }
                }
                else if (comboBoxTenMon.Text.Trim() == "Mojito")
                {
                    if (Convert.ToInt32(textBoxRau.Text) < 3 || Convert.ToInt32(textBoxTinhBot.Text) < 2 || Convert.ToInt32(textBoxThit.Text) < 7)
                    {
                        labelKtra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện " + comboBoxTenMon.Text.Trim();
                    }
                    else if (Convert.ToInt32(textBoxRau.Text) >= 3 || Convert.ToInt32(textBoxTinhBot.Text) >= 2 || Convert.ToInt32(textBoxThit.Text) >= 7)
                    {
                        int slrau = Convert.ToInt32(textBoxRau.Text) / 3;
                        int sltinhbot = Convert.ToInt32(textBoxTinhBot.Text) / 2;
                        int slthit = Convert.ToInt32(textBoxThit.Text) / 7;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        labelKtra.Text = "Ta Có Thể Tạo Ra " + kq + " Ly " + comboBoxTenMon.Text.Trim();

                    }
                }
                else if (comboBoxTenMon.Text.Trim() == "Cosmopolitan")
                {
                    if (Convert.ToInt32(textBoxRau.Text) < 1 || Convert.ToInt32(textBoxTinhBot.Text) < 4 || Convert.ToInt32(textBoxThit.Text) < 3)
                    {
                        labelKtra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện " + comboBoxTenMon.Text.Trim();
                    }
                    else if (Convert.ToInt32(textBoxRau.Text) >= 1 || Convert.ToInt32(textBoxTinhBot.Text) >= 4 || Convert.ToInt32(textBoxThit.Text) >= 3)
                    {
                        int slrau = Convert.ToInt32(textBoxRau.Text) / 1;
                        int sltinhbot = Convert.ToInt32(textBoxTinhBot.Text) / 4;
                        int slthit = Convert.ToInt32(textBoxThit.Text) / 3;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        labelKtra.Text = "Ta Có Thể Tạo Ra " + kq + " Ly " + comboBoxTenMon.Text.Trim();

                    }
                }
                else
                {
                    if (Convert.ToInt32(textBoxRau.Text) < 3 || Convert.ToInt32(textBoxTinhBot.Text) < 5 || Convert.ToInt32(textBoxThit.Text) < 5)
                    {
                        labelKtra.Text = "Nguyên Liệu Không Đủ Để Thực Hiện Phần Ăn " + comboBoxTenMon.Text.Trim();
                    }
                    else if (Convert.ToInt32(textBoxRau.Text) >= 3 || Convert.ToInt32(textBoxTinhBot.Text) >= 5 || Convert.ToInt32(textBoxThit.Text) >= 5)
                    {
                        int slrau = Convert.ToInt32(textBoxRau.Text) / 3;
                        int sltinhbot = Convert.ToInt32(textBoxTinhBot.Text) / 5;
                        int slthit = Convert.ToInt32(textBoxThit.Text) / 5;
                        int kq = TimMin(slrau, sltinhbot, slthit);
                        labelKtra.Text = "Ta Có Thể Tạo Ra " + kq + " Ly " + comboBoxTenMon.Text.Trim();

                    }
                }
            }
        }
    }
}
