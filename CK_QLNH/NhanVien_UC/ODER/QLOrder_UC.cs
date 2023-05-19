using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_QLNH
{
    public partial class QLOrder_UC : UserControl
    {
        public QLOrder_UC()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu_UC menu = new Menu_UC();
            panelShowOder.Controls.Clear();
            panelShowOder.Controls.Add(menu);
        }

        private void buttonGoiMon_Click(object sender, EventArgs e)
        {
            
            Order_Form oder = new Order_Form();
            oder.Show(this);
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            TinhTien_Form tinhtien = new TinhTien_Form();
            tinhtien.Show(this);
        }

        private void buttonban_Click(object sender, EventArgs e)
        {
            Ban_Form ban = new Ban_Form();
            ban.Show(this);

        }
    }
}
