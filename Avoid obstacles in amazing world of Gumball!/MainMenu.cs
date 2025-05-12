using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Кнопка выхода из игры
        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Кнопка перехода на репозиторий GIT
        private void gitBTN_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/UstyantsewaME/Avoid-obstacles-in-amazing-world-of-Gumball-.git";
            System.Diagnostics.Process.Start(url);
        }

    }
}
