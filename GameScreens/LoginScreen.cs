using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScreens
{
    public partial class LoginScreen : UserControl
    {
        string user = "bob";
        string password = "1234";

        string userAttempt;
        string passwordAttempt;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userAttempt = usernameInput.Text;
            passwordAttempt = passwordInput.Text;

            if (userAttempt == user && passwordAttempt == password)
            {
                //make button find out which form it's on
                Form f = this.FindForm();
                f.Controls.Remove(this);

                //add instance of menuscreen
                MenuScreen ms = new MenuScreen();

                //centre
                ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

                //uc and focus
                f.Controls.Add(ms);
                ms.Focus();
            }
            else
            {
                usernameInput.Clear();
                passwordInput.Clear();
                wrongLoginLabel.Text = "login or password incorrect";
            }
        }
    }
}
