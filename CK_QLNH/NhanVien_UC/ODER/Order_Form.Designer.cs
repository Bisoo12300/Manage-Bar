
namespace CK_QLNH
{
    partial class Order_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Form));
            this.DateTimePickerBirthTG = new System.Windows.Forms.DateTimePicker();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.comboBoxTenMon = new System.Windows.Forms.ComboBox();
            this.dataGridViewOder = new System.Windows.Forms.DataGridView();
            this.textBoxIdBan = new System.Windows.Forms.TextBox();
            this.buttonNhaBep = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.ButtonLuuHD = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOder)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePickerBirthTG
            // 
            this.DateTimePickerBirthTG.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerBirthTG.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerBirthTG.Location = new System.Drawing.Point(563, 120);
            this.DateTimePickerBirthTG.Name = "DateTimePickerBirthTG";
            this.DateTimePickerBirthTG.Size = new System.Drawing.Size(117, 21);
            this.DateTimePickerBirthTG.TabIndex = 146;
            // 
            // textBoxSL
            // 
            this.textBoxSL.BackColor = System.Drawing.Color.White;
            this.textBoxSL.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSL.ForeColor = System.Drawing.Color.Black;
            this.textBoxSL.Location = new System.Drawing.Point(295, 120);
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(110, 21);
            this.textBoxSL.TabIndex = 145;
            this.textBoxSL.TextChanged += new System.EventHandler(this.textBoxSL_TextChanged);
            // 
            // textBoxGia
            // 
            this.textBoxGia.BackColor = System.Drawing.Color.White;
            this.textBoxGia.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGia.ForeColor = System.Drawing.Color.Black;
            this.textBoxGia.Location = new System.Drawing.Point(436, 121);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(102, 21);
            this.textBoxGia.TabIndex = 144;
            // 
            // labelTongTien
            // 
            this.labelTongTien.BackColor = System.Drawing.Color.White;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.ForeColor = System.Drawing.Color.Black;
            this.labelTongTien.Location = new System.Drawing.Point(52, 448);
            this.labelTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(628, 32);
            this.labelTongTien.TabIndex = 143;
            this.labelTongTien.Text = "Tổng Tiền Thanh Toán";
            this.labelTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxTenMon
            // 
            this.comboBoxTenMon.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTenMon.FormattingEnabled = true;
            this.comboBoxTenMon.Location = new System.Drawing.Point(162, 120);
            this.comboBoxTenMon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTenMon.Name = "comboBoxTenMon";
            this.comboBoxTenMon.Size = new System.Drawing.Size(107, 21);
            this.comboBoxTenMon.TabIndex = 142;
            this.comboBoxTenMon.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenMon_SelectedIndexChanged);
            // 
            // dataGridViewOder
            // 
            this.dataGridViewOder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOder.Location = new System.Drawing.Point(55, 145);
            this.dataGridViewOder.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOder.Name = "dataGridViewOder";
            this.dataGridViewOder.RowHeadersWidth = 51;
            this.dataGridViewOder.RowTemplate.Height = 24;
            this.dataGridViewOder.Size = new System.Drawing.Size(625, 300);
            this.dataGridViewOder.TabIndex = 140;
            this.dataGridViewOder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOder_CellDoubleClick);
            // 
            // textBoxIdBan
            // 
            this.textBoxIdBan.BackColor = System.Drawing.Color.White;
            this.textBoxIdBan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdBan.ForeColor = System.Drawing.Color.Black;
            this.textBoxIdBan.Location = new System.Drawing.Point(55, 121);
            this.textBoxIdBan.Name = "textBoxIdBan";
            this.textBoxIdBan.Size = new System.Drawing.Size(85, 21);
            this.textBoxIdBan.TabIndex = 155;
            // 
            // buttonNhaBep
            // 
            this.buttonNhaBep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonNhaBep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhaBep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhaBep.ForeColor = System.Drawing.Color.White;
            this.buttonNhaBep.Image = global::CK_QLNH.Properties.Resources.Edit_icon__the_Noun_Project_30184__svg;
            this.buttonNhaBep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNhaBep.Location = new System.Drawing.Point(563, 87);
            this.buttonNhaBep.Name = "buttonNhaBep";
            this.buttonNhaBep.Size = new System.Drawing.Size(116, 27);
            this.buttonNhaBep.TabIndex = 156;
            this.buttonNhaBep.Text = "Quầy";
            this.buttonNhaBep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNhaBep.UseVisualStyleBackColor = false;
            this.buttonNhaBep.Click += new System.EventHandler(this.buttonNhaBep_Click);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.Transparent;
            this.buttonback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonback.Image = global::CK_QLNH.Properties.Resources.Go_back_icon1;
            this.buttonback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonback.Location = new System.Drawing.Point(10, 14);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(78, 27);
            this.buttonback.TabIndex = 154;
            this.buttonback.Text = "Back";
            this.buttonback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.Color.White;
            this.buttonHuy.Image = global::CK_QLNH.Properties.Resources.Windows_Close_Program_icon1;
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(436, 88);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(100, 27);
            this.buttonHuy.TabIndex = 150;
            this.buttonHuy.Text = "Hủy Oder";
            this.buttonHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Image = global::CK_QLNH.Properties.Resources.pencil_icon;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(295, 87);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(109, 27);
            this.buttonEdit.TabIndex = 149;
            this.buttonEdit.Text = "Chỉnh Sửa";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // ButtonLuuHD
            // 
            this.ButtonLuuHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.ButtonLuuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLuuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLuuHD.ForeColor = System.Drawing.Color.White;
            this.ButtonLuuHD.Image = global::CK_QLNH.Properties.Resources.Save_icon;
            this.ButtonLuuHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLuuHD.Location = new System.Drawing.Point(55, 87);
            this.ButtonLuuHD.Name = "ButtonLuuHD";
            this.ButtonLuuHD.Size = new System.Drawing.Size(84, 27);
            this.ButtonLuuHD.TabIndex = 148;
            this.ButtonLuuHD.Text = "Thêm ";
            this.ButtonLuuHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonLuuHD.UseVisualStyleBackColor = false;
            this.ButtonLuuHD.Click += new System.EventHandler(this.ButtonLuuHD_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRemove.Image")));
            this.ButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRemove.Location = new System.Drawing.Point(162, 87);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(106, 27);
            this.ButtonRemove.TabIndex = 147;
            this.ButtonRemove.Text = "Xóa Món";
            this.ButtonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 512);
            this.Controls.Add(this.buttonNhaBep);
            this.Controls.Add(this.textBoxIdBan);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.ButtonLuuHD);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.DateTimePickerBirthTG);
            this.Controls.Add(this.textBoxSL);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.comboBoxTenMon);
            this.Controls.Add(this.dataGridViewOder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_Form";
            this.Load += new System.EventHandler(this.Oder_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button ButtonLuuHD;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.DateTimePicker DateTimePickerBirthTG;
        private System.Windows.Forms.TextBox textBoxSL;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.ComboBox comboBoxTenMon;
        private System.Windows.Forms.DataGridView dataGridViewOder;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.TextBox textBoxIdBan;
        private System.Windows.Forms.Button buttonNhaBep;
    }
}