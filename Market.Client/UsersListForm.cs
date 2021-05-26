using Market.Models;
using Market.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Market.Client
{
    public partial class UsersListForm : Form, IListForm
    {
        private readonly UserRepository _userRepository;
        private int _userId = 0;

        public UsersListForm()
        {
            InitializeComponent();
            empDGV.AutoGenerateColumns = false;
            _userRepository = new(@"server = NIKAS-THINKPAD\SQLEXPRESS;database=Market;integrated security=true");
        }

        public void Delete()
        {
            var result = MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _userRepository.Delete(_userId);
                Reload();
            }
        }

        public Form GetAddForm()
        {
            return new UserAdd();
        }

        public Form GetEditForm()
        {
            return new UserEdit();
        }

        public void Reload()
        {
            empDGV.DataSource = _userRepository.Select();
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void empDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _userId = int.Parse((Controls[0] as DataGridView).SelectedRows[0].Cells[0].FormattedValue.ToString());
        }
    }
}
