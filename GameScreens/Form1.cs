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
    public partial class Form1 : Form
    {
        //adding public static vairables allows all forms to access variables
        //format ex.: Form1.counter++;

        public static int plays = 0;
        public Form1()
        {
            InitializeComponent();

            //add instance of menuscreen
            LoginScreen ls = new LoginScreen();

            //centre
            ls.Location = new Point((this.Width - ls.Width) / 2, (this.Height - ls.Height) / 2);

            //uc and focus
            this.Controls.Add(ls);
        }
    }
}
