
namespace CK_QLNH
{
    partial class TienLuongNV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDanhSachNV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachNV
            // 
            this.dataGridViewDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachNV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachNV.Location = new System.Drawing.Point(177, 80);
            this.dataGridViewDanhSachNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDanhSachNV.Name = "dataGridViewDanhSachNV";
            this.dataGridViewDanhSachNV.RowHeadersWidth = 51;
            this.dataGridViewDanhSachNV.RowTemplate.Height = 24;
            this.dataGridViewDanhSachNV.Size = new System.Drawing.Size(756, 210);
            this.dataGridViewDanhSachNV.TabIndex = 151;
            // 
            // TienLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDanhSachNV);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TienLuongNV";
            this.Size = new System.Drawing.Size(1017, 450);
            this.Load += new System.EventHandler(this.TienLuongNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDanhSachNV;
    }
}
