
namespace CK_QLNH
{
    partial class Menu_UC
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
            this.dataGridViewThucDon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewThucDon
            // 
            this.dataGridViewThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThucDon.Location = new System.Drawing.Point(77, 126);
            this.dataGridViewThucDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewThucDon.Name = "dataGridViewThucDon";
            this.dataGridViewThucDon.RowHeadersWidth = 51;
            this.dataGridViewThucDon.RowTemplate.Height = 24;
            this.dataGridViewThucDon.Size = new System.Drawing.Size(635, 325);
            this.dataGridViewThucDon.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(219, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 39);
            this.label4.TabIndex = 132;
            this.label4.Text = "THƯC ĐƠN MÓN";
            // 
            // Menu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewThucDon);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu_UC";
            this.Size = new System.Drawing.Size(816, 487);
            this.Load += new System.EventHandler(this.Menu_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThucDon;
        private System.Windows.Forms.Label label4;
    }
}
