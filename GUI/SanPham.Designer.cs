namespace GUI
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            System.Windows.Forms.Label maSPLabel;
            System.Windows.Forms.Label tenSPLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label maNCCLabel;
            this.qLShoplaptopDataSet = new GUI.QLShoplaptopDataSet();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new GUI.QLShoplaptopDataSetTableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new GUI.QLShoplaptopDataSetTableAdapters.TableAdapterManager();
            this.sANPHAMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sANPHAMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sANPHAMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPTextBox = new System.Windows.Forms.TextBox();
            this.tenSPTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTextBox = new System.Windows.Forms.TextBox();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.maNCCComboBox = new System.Windows.Forms.ComboBox();
            maSPLabel = new System.Windows.Forms.Label();
            tenSPLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingNavigator)).BeginInit();
            this.sANPHAMBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // sANPHAMBindingNavigator
            // 
            this.sANPHAMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sANPHAMBindingNavigator.BindingSource = this.sANPHAMBindingSource;
            this.sANPHAMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sANPHAMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sANPHAMBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sANPHAMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sANPHAMBindingNavigatorSaveItem});
            this.sANPHAMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sANPHAMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sANPHAMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sANPHAMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sANPHAMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sANPHAMBindingNavigator.Name = "sANPHAMBindingNavigator";
            this.sANPHAMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sANPHAMBindingNavigator.Size = new System.Drawing.Size(799, 27);
            this.sANPHAMBindingNavigator.TabIndex = 0;
            this.sANPHAMBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sANPHAMBindingNavigatorSaveItem
            // 
            this.sANPHAMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sANPHAMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sANPHAMBindingNavigatorSaveItem.Image")));
            this.sANPHAMBindingNavigatorSaveItem.Name = "sANPHAMBindingNavigatorSaveItem";
            this.sANPHAMBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.sANPHAMBindingNavigatorSaveItem.Text = "Save Data";
            this.sANPHAMBindingNavigatorSaveItem.Click += new System.EventHandler(this.sANPHAMBindingNavigatorSaveItem_Click);
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
            this.sANPHAMDataGridView.Location = new System.Drawing.Point(55, 217);
            this.sANPHAMDataGridView.Name = "sANPHAMDataGridView";
            this.sANPHAMDataGridView.RowTemplate.Height = 24;
            this.sANPHAMDataGridView.Size = new System.Drawing.Size(702, 220);
            this.sANPHAMDataGridView.TabIndex = 1;
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
            // maSPLabel
            // 
            maSPLabel.AutoSize = true;
            maSPLabel.Location = new System.Drawing.Point(114, 74);
            maSPLabel.Name = "maSPLabel";
            maSPLabel.Size = new System.Drawing.Size(53, 17);
            maSPLabel.TabIndex = 2;
            maSPLabel.Text = "Ma SP:";
            // 
            // maSPTextBox
            // 
            this.maSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MaSP", true));
            this.maSPTextBox.Location = new System.Drawing.Point(173, 71);
            this.maSPTextBox.Name = "maSPTextBox";
            this.maSPTextBox.Size = new System.Drawing.Size(152, 22);
            this.maSPTextBox.TabIndex = 3;
            // 
            // tenSPLabel
            // 
            tenSPLabel.AutoSize = true;
            tenSPLabel.Location = new System.Drawing.Point(108, 121);
            tenSPLabel.Name = "tenSPLabel";
            tenSPLabel.Size = new System.Drawing.Size(59, 17);
            tenSPLabel.TabIndex = 4;
            tenSPLabel.Text = "Ten SP:";
            // 
            // tenSPTextBox
            // 
            this.tenSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "TenSP", true));
            this.tenSPTextBox.Location = new System.Drawing.Point(173, 118);
            this.tenSPTextBox.Name = "tenSPTextBox";
            this.tenSPTextBox.Size = new System.Drawing.Size(152, 22);
            this.tenSPTextBox.TabIndex = 5;
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(397, 72);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(73, 17);
            soLuongLabel.TabIndex = 6;
            soLuongLabel.Text = "So Luong:";
            // 
            // soLuongTextBox
            // 
            this.soLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "SoLuong", true));
            this.soLuongTextBox.Location = new System.Drawing.Point(476, 69);
            this.soLuongTextBox.Name = "soLuongTextBox";
            this.soLuongTextBox.Size = new System.Drawing.Size(171, 22);
            this.soLuongTextBox.TabIndex = 7;
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Location = new System.Drawing.Point(407, 119);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(63, 17);
            giaBanLabel.TabIndex = 8;
            giaBanLabel.Text = "Gia Ban:";
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "GiaBan", true));
            this.giaBanTextBox.Location = new System.Drawing.Point(476, 116);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(171, 22);
            this.giaBanTextBox.TabIndex = 9;
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(438, 168);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(63, 17);
            maNCCLabel.TabIndex = 10;
            maNCCLabel.Text = "Ma NCC:";
            // 
            // maNCCComboBox
            // 
            this.maNCCComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MaNCC", true));
            this.maNCCComboBox.FormattingEnabled = true;
            this.maNCCComboBox.Location = new System.Drawing.Point(507, 165);
            this.maNCCComboBox.Name = "maNCCComboBox";
            this.maNCCComboBox.Size = new System.Drawing.Size(140, 24);
            this.maNCCComboBox.TabIndex = 11;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 504);
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
            this.Controls.Add(this.sANPHAMDataGridView);
            this.Controls.Add(this.sANPHAMBindingNavigator);
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLShoplaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingNavigator)).EndInit();
            this.sANPHAMBindingNavigator.ResumeLayout(false);
            this.sANPHAMBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLShoplaptopDataSet qLShoplaptopDataSet;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private QLShoplaptopDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private QLShoplaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sANPHAMBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sANPHAMBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sANPHAMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox maSPTextBox;
        private System.Windows.Forms.TextBox tenSPTextBox;
        private System.Windows.Forms.TextBox soLuongTextBox;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.ComboBox maNCCComboBox;
    }
}

