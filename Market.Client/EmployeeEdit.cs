using Market.Models;
using Market.Repository;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Market.Client
{
    public partial class EmployeeEdit : Form, IEditForm
    {
        private EmployeeRepository _employeeRepository;
        private EmployeesListForm _employeesListForm;
        private Employee _employee;
        private int _empId;

        public EmployeeEdit(Form form, int Id)
        {
            InitializeComponent();
            _empId = Id;
            _employeesListForm = form as EmployeesListForm;
            _employeeRepository = new(@"server = NIKAS-THINKPAD\SQLEXPRESS;database=Market;integrated security=true");
        }


        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            
            _employee = _employeeRepository.Get(_empId);

            txtFirstName.Text = _employee.FirstName;
            txtLastName.Text = _employee.LastName;
            txtPosition.Text = _employee.Position;
            txtEmail.Text = _employee.Email;
            txtPhoneNumber.Text = _employee.PhoneNumber;
            if (_employee.Photo is not null)
                pictureBox.Image = ConvertByteArrayToImage(_employee.Photo);

            btnEdit.Enabled = true;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            _employee.FirstName = txtFirstName.Text;
            _employee.LastName = txtLastName.Text;
            _employee.Email = txtEmail.Text;
            _employee.PhoneNumber = txtPhoneNumber.Text;
            _employee.Position = txtPosition.Text;

            try
            {
                _employeeRepository.Update(_employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _employeesListForm.Reload();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(opnfd.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private Image ConvertByteArrayToImage(byte[] image)
        {
            using (MemoryStream memoryStream = new(image))
            {
                return Image.FromStream(memoryStream);
            }
        }
    }
}
