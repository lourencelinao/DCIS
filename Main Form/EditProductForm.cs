using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class EditProductForm : Form
    {
        public EditProductForm()
        {
            InitializeComponent();
            this.Text = "Edit Product";
        }

        private void cancelEditProductBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
