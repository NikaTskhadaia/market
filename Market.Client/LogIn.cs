using Market.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Client
{
    public partial class LogIn : Form
    {
        private readonly UserRepository _userRepository;

        public LogIn()
        {
            InitializeComponent();
            _userRepository = new(@"server = localhost\SQLEXPRESS01;database=Market;integrated security=true");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LocalStorage.LoggedUserId = _userRepository.Login(txtUsername.Text, txtPassword.Text);

            if (LocalStorage.LoggedUserId == -1)
            {
                MessageBox.Show("Log in failed.");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}