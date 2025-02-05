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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();

            ms.Location = new Point((this.Width - ms.Width)/2, (this.Height - ms.Height) / 2);

            this.Controls.Add(ms);
            ms.Focus();
        }
    }
}
