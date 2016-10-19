using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project04_Jernigan_C
{
    public partial class PersonnelFind : Form
    {
        public PersonnelFind()
        {
            InitializeComponent();
        }

        private void employeeInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void PersonnelFind_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.EmployeeInfo' table. You can move, or remove it, as needed.
            this.employeeInfoTableAdapter.Fill(this.personnelDataSet.EmployeeInfo);

        }
    }
}
