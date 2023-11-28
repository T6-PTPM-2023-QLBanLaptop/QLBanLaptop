namespace GUI
{
    partial class FormSanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maSPLabel;
            System.Windows.Forms.Label tenSPLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label maNCCLabel;
            this.qLShoplaptopDataSet = new GUI.QLShoplaptopDataSet();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager();
            this.maSPTextBox = new System.Windows.Forms.TextBox();
            this.tenSPTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTextBox = new System.Windows.Forms.TextBox();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.maNCCComboBox = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_showallsp = new System.Windows.Forms.Button();
            this.sANPHAMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maSPLabel = new System.Windows.Forms.Label();
            tenSPLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.Location = new System.Drawing.Point(74, 42);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(97, 17);
            maSPLabel.TabIndex = 2;
            maSPLabel.Text = "Mã sản phẩm:";
            // 
            // tenSPLabel
            // 
            tenSPLabel.AutoSize = true;
            tenSPLabel.Location = new System.Drawing.Point(74, 91);
            tenSPLabel.Name = "tenSPLabel";
            tenSPLabel.Size = new System.Drawing.Size(103, 17);
            tenSPLabel.TabIndex = 4;
            tenSPLabel.Text = "Tên sản phẩm:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(74, 140);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(68, 17);
            soLuongLabel.TabIndex = 6;
            soLuongLabel.Text = "Số lượng:";
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Location = new System.Drawing.Point(481, 37);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(62, 17);
            giaBanLabel.TabIndex = 8;
            giaBanLabel.Text = "Giá bán:";
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(481, 82);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(121, 17);
            maNCCLabel.TabIndex = 10;
            maNCCLabel.Text = "Mã nhà cung cấp:";
            // 
            // qLShoplaptopDataSet
            // 
            this.qLShoplaptopDataSet.DataSetName = "QLShoplaptopDataSet";
            this.qLShoplaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.qLShoplaptopDataSet;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maSPTextBox
            // 
            this.maSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MaSP", true));
            this.maSPTextBox.Location = new System.Drawing.Point(235, 39);
            this.maSPTextBox.Name = "maSPTextBox";
            this.maSPTextBox.Size = new System.Drawing.Size(174, 22);
            this.maSPTextBox.TabIndex = 3;
            // 
            // tenSPTextBox
            // 
            this.tenSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "TenSP", true));
            this.tenSPTextBox.Location = new System.Drawing.Point(235, 88);
            this.tenSPTextBox.Name = "tenSPTextBox";
            this.tenSPTextBox.Size = new System.Drawing.Size(174, 22);
            this.tenSPTextBox.TabIndex = 5;
            // 
            // soLuongTextBox
            // 
            this.soLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "SoLuong", true));
            this.soLuongTextBox.Location = new System.Drawing.Point(235, 137);
            this.soLuongTextBox.Name = "soLuongTextBox";
            this.soLuongTextBox.Size = new System.Drawing.Size(174, 22);
            this.soLuongTextBox.TabIndex = 7;
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "GiaBan", true));
            this.giaBanTextBox.Location = new System.Drawing.Point(654, 34);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(172, 22);
            this.giaBanTextBox.TabIndex = 9;
            // 
            // maNCCComboBox
            // 
            this.maNCCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MaNCC", true));
            this.maNCCComboBox.FormattingEnabled = true;
            this.maNCCComboBox.Location = new System.Drawing.Point(654, 79);
            this.maNCCComboBox.Name = "maNCCComboBox";
            this.maNCCComboBox.Size = new System.Drawing.Size(172, 24);
            this.maNCCComboBox.TabIndex = 11;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(77, 206);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 53);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(252, 206);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(130, 53);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(532, 206);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(130, 53);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(696, 206);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(130, 53);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_showallsp
            // 
            this.btn_showallsp.Location = new System.Drawing.Point(654, 130);
            this.btn_showallsp.Name = "btn_showallsp";
            this.btn_showallsp.Size = new System.Drawing.Size(172, 37);
            this.btn_showallsp.TabIndex = 12;
            this.btn_showallsp.Text = "Hiển thị tất cả sản phẩm";
            this.btn_showallsp.UseVisualStyleBackColor = true;
            this.btn_showallsp.Click += new System.EventHandler(this.btn_showallsp_Click);
            // 
            // sANPHAMDataGridView
            // 
            this.sANPHAMDataGridView.AutoGenerateColumns = false;
            this.sANPHAMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sANPHAMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sANPHAMDataGridView.DataSource = this.sANPHAMBindingSource;
            this.sANPHAMDataGridView.Location = new System.Drawing.Point(77, 289);
            this.sANPHAMDataGridView.Name = "sANPHAMDataGridView";
            this.sANPHAMDataGridView.RowTemplate.Height = 24;
            this.sANPHAMDataGridView.Size = new System.Drawing.Size(749, 231);
            this.sANPHAMDataGridView.TabIndex = 147;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSP";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenSP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiaBan";
            this.dataGridViewTextBoxColumn4.HeaderText = "GiaBan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaNCC";
            this.dataGridViewTextBoxColumn5.HeaderText = "MaNCC";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 553);
            this.Controls.Add(this.sANPHAMDataGridView);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_showallsp);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(maNCCLabel);
            this.Controls.Add(this.maNCCComboBox);
            this.Controls.Add(giaBanLabel);
            this.Controls.Add(this.giaBanTextBox);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.soLuongTextBox);
            this.Controls.Add(tenSPLabel);
            this.Controls.Add(this.tenSPTextBox);
            this.Controls.Add(maSPLabel);
            this.Controls.Add(this.maSPTextBox);
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLShoplaptopDataSet qLShoplaptopDataSet;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private QLShoplaptopDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private QLShoplaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maSPTextBox;
        private System.Windows.Forms.TextBox tenSPTextBox;
        private System.Windows.Forms.TextBox soLuongTextBox;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.ComboBox maNCCComboBox;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_showallsp;
        private System.Windows.Forms.DataGridView sANPHAMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}