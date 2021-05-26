using Market.Models;
using Market.Repository;
using System;
using System.Windows.Forms;

namespace Market.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuEmployeeList_Click(object sender, EventArgs e)
        {
            ShowChildForm<EmployeesListForm>();
        }

        private void mnuUsersList_Click(object sender, EventArgs e)
        {
            ShowChildForm<UsersListForm>();
        }

        private void ShowChildForm<T>() where T : Form, new()
        {
            T form = new();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as IListForm).GetAddForm().ShowDialog();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as IListForm).GetEditForm().ShowDialog();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as IListForm).Delete();
        }

        private void mnuEmployeeAdd_Click(object sender, EventArgs e)
        {
            EmployeesListForm empListForm = null;

            foreach (var mdiChild in MdiChildren)
            {
                if (mdiChild is EmployeesListForm)
                {
                    empListForm = mdiChild as EmployeesListForm;
                }
            }
            empListForm.GetAddForm().ShowDialog();
        }
    }
}
