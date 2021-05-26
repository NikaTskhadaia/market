using Market.Models;
using Market.Repository;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Market.Client
{
    public partial class EmployeeAdd : Form, IAddForm
    {
        private EmployeeRepository _employeeRepository;
        private EmployeesListForm _employeesListForm;
        private Employee _employee;

        public EmployeeAdd(EmployeesListForm form)
        {
            InitializeComponent();
            _employeeRepository = new(@"server = NIKAS-THINKPAD\SQLEXPRESS;database=Market;integrated security=true");
            _employeesListForm = form;
            _employee = new();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            _employee.FirstName = txtFirstName.Text;
            _employee.LastName = txtLastName.Text;
            _employee.Position = txtPosition.Text;
            _employee.PhoneNumber = txtPhoneNumber.Text;
            _employee.Email = txtEmail.Text;

            try
            {
                _employeeRepository.Insert(_employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _employeesListForm.Reload();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(opnfd.FileName);
                _employee.Photo = ImageToByteArray(pictureBox.Image);
            }
        }

        private byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
