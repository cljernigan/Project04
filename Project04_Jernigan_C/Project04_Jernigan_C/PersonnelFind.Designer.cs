namespace Project04_Jernigan_C
{
    partial class PersonnelFind
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
            System.Windows.Forms.Label employeeIdLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NamseLabel;
            System.Windows.Forms.Label departmentIDLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label hourlyRateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelFind));
            this.personnelDataSet = new Project04_Jernigan_C.PersonnelDataSet();
            this.employeeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeInfoTableAdapter = new Project04_Jernigan_C.PersonnelDataSetTableAdapters.EmployeeInfoTableAdapter();
            this.tableAdapterManager = new Project04_Jernigan_C.PersonnelDataSetTableAdapters.TableAdapterManager();
            this.employeeInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NamseTextBox = new System.Windows.Forms.TextBox();
            this.departmentIDTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRateTextBox = new System.Windows.Forms.TextBox();
            employeeIdLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NamseLabel = new System.Windows.Forms.Label();
            departmentIDLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            hourlyRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingNavigator)).BeginInit();
            this.employeeInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new System.Drawing.Point(89, 387);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(68, 13);
            employeeIdLabel.TabIndex = 2;
            employeeIdLabel.Text = "Employee Id:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(89, 413);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 4;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NamseLabel
            // 
            last_NamseLabel.AutoSize = true;
            last_NamseLabel.Location = new System.Drawing.Point(89, 439);
            last_NamseLabel.Name = "last_NamseLabel";
            last_NamseLabel.Size = new System.Drawing.Size(66, 13);
            last_NamseLabel.TabIndex = 6;
            last_NamseLabel.Text = "Last Namse:";
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Location = new System.Drawing.Point(89, 465);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(79, 13);
            departmentIDLabel.TabIndex = 8;
            departmentIDLabel.Text = "Department ID:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(89, 491);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 10;
            positionLabel.Text = "Position:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(89, 517);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 12;
            locationLabel.Text = "Location:";
            // 
            // hourlyRateLabel
            // 
            hourlyRateLabel.AutoSize = true;
            hourlyRateLabel.Location = new System.Drawing.Point(89, 543);
            hourlyRateLabel.Name = "hourlyRateLabel";
            hourlyRateLabel.Size = new System.Drawing.Size(66, 13);
            hourlyRateLabel.TabIndex = 14;
            hourlyRateLabel.Text = "Hourly Rate:";
            // 
            // personnelDataSet
            // 
            this.personnelDataSet.DataSetName = "PersonnelDataSet";
            this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeInfoBindingSource
            // 
            this.employeeInfoBindingSource.DataMember = "EmployeeInfo";
            this.employeeInfoBindingSource.DataSource = this.personnelDataSet;
            // 
            // employeeInfoTableAdapter
            // 
            this.employeeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeInfoTableAdapter = this.employeeInfoTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project04_Jernigan_C.PersonnelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeInfoBindingNavigator
            // 
            this.employeeInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeInfoBindingNavigator.BindingSource = this.employeeInfoBindingSource;
            this.employeeInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeInfoBindingNavigatorSaveItem});
            this.employeeInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeInfoBindingNavigator.Name = "employeeInfoBindingNavigator";
            this.employeeInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeInfoBindingNavigator.Size = new System.Drawing.Size(468, 25);
            this.employeeInfoBindingNavigator.TabIndex = 0;
            this.employeeInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employeeInfoBindingNavigatorSaveItem
            // 
            this.employeeInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeInfoBindingNavigatorSaveItem.Image")));
            this.employeeInfoBindingNavigatorSaveItem.Name = "employeeInfoBindingNavigatorSaveItem";
            this.employeeInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeeInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeInfoBindingNavigatorSaveItem_Click);
            // 
            // employeeInfoDataGridView
            // 
            this.employeeInfoDataGridView.AutoGenerateColumns = false;
            this.employeeInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.employeeInfoDataGridView.DataSource = this.employeeInfoBindingSource;
            this.employeeInfoDataGridView.Location = new System.Drawing.Point(12, 44);
            this.employeeInfoDataGridView.Name = "employeeInfoDataGridView";
            this.employeeInfoDataGridView.Size = new System.Drawing.Size(434, 106);
            this.employeeInfoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Namse";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Namse";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn5.HeaderText = "Position";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn6.HeaderText = "Location";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HourlyRate";
            this.dataGridViewTextBoxColumn7.HeaderText = "HourlyRate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeInfoBindingSource, "EmployeeId", true));
            this.employeeIdTextBox.Location = new System.Drawing.Point(174, 384);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIdTextBox.TabIndex = 3;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeInfoBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(174, 410);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(130, 20);
            this.first_NameTextBox.TabIndex = 5;
            // 
            // last_NamseTextBox
            // 
            this.last_NamseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeInfoBindingSource, "Last Namse", true));
            this.last_NamseTextBox.Location = new System.Drawing.Point(174, 436);
            this.last_NamseTextBox.Name = "last_NamseTextBox";
            this.last_NamseTextBox.Size = new System.Drawing.Size(130, 20);
            this.last_NamseTextBox.TabIndex = 7;
            // 
            // departmentIDTextBox
            // 
            this.departmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeInfoBindingSource, "DepartmentID", true));
            this.departmentIDTextBox.Location = new System.Drawing.Point(174, 462);
            this.departmentIDTextBox.Name = "departmentIDTextBox";
            this.departmentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentIDTextBox.TabIndex = 9;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeInfoBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(174, 488);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 11;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeInfoBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(174, 514);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 13;
            // 
            // hourlyRateTextBox
            // 
            this.hourlyRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeInfoBindingSource, "HourlyRate", true));
            this.hourlyRateTextBox.Location = new System.Drawing.Point(174, 540);
            this.hourlyRateTextBox.Name = "hourlyRateTextBox";
            this.hourlyRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.hourlyRateTextBox.TabIndex = 15;
            // 
            // PersonnelFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 580);
            this.Controls.Add(employeeIdLabel);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NamseLabel);
            this.Controls.Add(this.last_NamseTextBox);
            this.Controls.Add(departmentIDLabel);
            this.Controls.Add(this.departmentIDTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(hourlyRateLabel);
            this.Controls.Add(this.hourlyRateTextBox);
            this.Controls.Add(this.employeeInfoDataGridView);
            this.Controls.Add(this.employeeInfoBindingNavigator);
            this.Name = "PersonnelFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnel Locator - Christopher  Jernigan";
            this.Load += new System.EventHandler(this.PersonnelFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingNavigator)).EndInit();
            this.employeeInfoBindingNavigator.ResumeLayout(false);
            this.employeeInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonnelDataSet personnelDataSet;
        private System.Windows.Forms.BindingSource employeeInfoBindingSource;
        private PersonnelDataSetTableAdapters.EmployeeInfoTableAdapter employeeInfoTableAdapter;
        private PersonnelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView employeeInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NamseTextBox;
        private System.Windows.Forms.TextBox departmentIDTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox hourlyRateTextBox;
    }
}

