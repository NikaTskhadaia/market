using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Client
{
    public interface IListForm
    {
        void Reload();

        Form GetAddForm();

        Form GetEditForm();

        void Delete();
    }
}
