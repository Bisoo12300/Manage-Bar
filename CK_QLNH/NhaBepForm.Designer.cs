
namespace CK_QLNH
{
    partial class NhaBepForm
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
            this.dataGridViewOder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOder
            // 
            this.dataGridViewOder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOder.Location = new System.Drawing.Point(28, 90);
            this.dataGridViewOder.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOder.Name = "dataGridViewOder";
            this.dataGridViewOder.RowHeadersWidth = 51;
            this.dataGridViewOder.RowTemplate.Height = 24;
            this.dataGridViewOder.Size = new System.Drawing.Size(474, 300);
            this.dataGridViewOder.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 39);
            this.label1.TabIndex = 142;
            this.label1.Text = "QUẦY";
            // 
            // NhaBepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhaBepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NhaBepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOder;
        private System.Windows.Forms.Label label1;
    }
}