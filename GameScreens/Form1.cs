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
        public Form1()
        {
            InitializeComponent();

            //create instance of MainScreen
            MainScreen ms = new MainScreen();

            //give focus to form
            this.Controls.Add(ms);
            ms.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
