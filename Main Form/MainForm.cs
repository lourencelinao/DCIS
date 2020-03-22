using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Initialize();
            this.Text = "";
        }

        public void Initialize()
        {
            employeesBtn.FlatAppearance.BorderSize = 0;
            itemBtn.FlatAppearance.BorderSize = 0;
            productBtn.FlatAppearance.BorderSize = 0;
        }

        private void employeesBtn_MouseClick(object sender, MouseEventArgs e)
        {
            EmployeesForm employee = new EmployeesForm();
            employee.ShowDialog();
        }

        private void itemBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ItemForm item = new ItemForm();
            item.ShowDialog();
        }

        private void productBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ProductForm product = new ProductForm();
            product.ShowDialog();
        }

        ////background color
        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    using (var brush = new LinearGradientBrush
        //               (DisplayRectangle, Color.SkyBlue, Color.Blue, LinearGradientMode.Vertical))
        //    {
        //        e.Graphics.FillRectangle(brush, DisplayRectangle);
        //    }
        //}

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    Invalidate(); // Force repainting on resize
        //}
    }
}
