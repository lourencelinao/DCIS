using DB;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Log in";
            //this.MinimumSize = new Size(800, 600);
        }

        //background color override

        //private void loginPanel_Paint(object sender, PaintEventArgs e)
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

        private void logInButton_MouseClick(object sender, MouseEventArgs e)
        {          
            try
            {
                if(string.IsNullOrEmpty(usernameTB.Text) || string.IsNullOrEmpty(passwordTB.Text))
                {
                    MessageBox.Show("Enter a username and a password", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    string username = usernameTB.Text;
                    string password = passwordTB.Text;

                    //query
                    string query = "SELECT * FROM users WHERE username = '" + username + "' AND password='" + password + "' ";
                    DBConnect dbc = new DBConnect();
                    string result = dbc.checkUser(query);

                    if (result == password)
                    {
                        MainForm main = new MainForm();
                        this.Hide();
                        main.Show();
                        main.FormClosing += (obj, args) => { this.Close(); };
                    }
                    else if (result == null)
                    {
                        MessageBox.Show("Username or password is incorrect!");
                    }
                    else
                    {
                        MessageBox.Show("Account is inactive! Please consult the ADMIN to activate the account!");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
