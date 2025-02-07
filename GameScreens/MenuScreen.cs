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

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //make button find out which form it's on
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //add instance of gamescreen
            GameScreen gs = new GameScreen();

            //centre
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

            //uc and focus
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            //make button find out which form it's on
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //add instance of instruction screen
            InstructionScreen IS = new InstructionScreen();

            //centre
            IS.Location = new Point((f.Width - IS.Width) / 2, (f.Height - IS.Height) / 2);

            //uc and focus
            f.Controls.Add(IS);
            IS.Focus();
        }
    }
}
