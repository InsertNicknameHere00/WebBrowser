using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebBrowser
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exiting will result in data loss!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string filename = NameBox.Text;
            StreamReader sr = new StreamReader("C:\\Users\\Rosen\\source\repos\\WebBrowser\\" + filename + ".txt");
            String[]lines=System.IO.File.ReadAllLines("C:\\Users\\Rosen\\source\repos\\WebBrowser\\" + filename + ".txt");
            String nickname = lines[0];
            String name = lines[0];
            String password = lines[0];
            try
            {
                if (NicknameBox.Text.Equals(nickname) && NameBox.Text.Equals(nickname) && PasswordBox.Text.Equals(nickname))
                {
                    MessageBox.Show("You have logged in!", "Success!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Data!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }

        private void RegisterLinkLabel_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    }
    }