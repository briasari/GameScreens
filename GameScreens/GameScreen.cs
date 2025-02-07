﻿using System;
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
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.plays++;

            playsLabel.Text = $"plays: {Form1.plays}";
        }

        private void gameBackButton_Click(object sender, EventArgs e)
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
    }
}
