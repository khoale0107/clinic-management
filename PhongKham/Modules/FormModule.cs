using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace PhongKham.Modules
{
    internal class FormModule
    {
        int a;
        public static void openForm(Form form)
        {
            if (Application.OpenForms[form.Name] != null)
            {
                //Form is already open
                Application.OpenForms[form.Name].BringToFront();
            }
            else
            {
                // Form is not open
                form.Show();
            }
        }
    }
}
