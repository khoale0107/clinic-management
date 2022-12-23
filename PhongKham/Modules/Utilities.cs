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
    internal class Utilities
    {
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

        public static void selectDgvRow(DataGridView dgv, string id)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cellValue = row.Cells[0].Value;
                if (cellValue != null && cellValue.ToString() == id)
                {
                    row.Selected = true;
                    
                    break;
                }
            }
        }

        public static string toCurrency(int price)
        {
            return price.ToString("0,# đ");
        }
    }
}
