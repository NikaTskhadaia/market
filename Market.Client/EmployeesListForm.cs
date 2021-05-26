using System;
using System.Windows.Forms;
using Market.Repository;

namespace Market.Client
{
    public partial class EmployeesListForm : Form, IListForm
    {
        private readonly EmployeeRepository _employeeRepository;
        private int _empId = 0;


        public EmployeesListForm()
        {
            InitializeComponent();
            empDGV.AutoGenerateColumns = false;
            _employeeRepository = new(@"server = NIKAS-THINKPAD\SQLEXPRESS;database=Market;integrated security=true");
        }

        private void EmployeesListForm_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void empDGV_DoubleClick(object sender, EventArgs e)
        {
            GetEditForm().ShowDialog();
        }

        private void empDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _empId = int.Parse((Controls[0] as DataGridView).SelectedRows[0].Cells[0].FormattedValue.ToString());
        }

        public void Reload()
        {
            empDGV.DataSource = _employeeRepository.Select();
        }

        public void Delete()
        {
            var result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _employeeRepository.Delete(_empId);
                Reload();
            }
        }

        public Form GetAddForm()
        {
            return new EmployeeAdd(this);
        }

        public Form GetEditForm()
        {
            return new EmployeeEdit(this, _empId);
        }
    }
}
