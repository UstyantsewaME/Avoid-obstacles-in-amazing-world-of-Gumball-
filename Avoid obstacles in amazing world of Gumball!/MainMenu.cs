using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    public partial class MainMenu : Form
    {
        private SoundPlayer clickSound;
        public MainMenu()
        {
            InitializeComponent();
            clickSound = new SoundPlayer(Properties.Resources.Click);
            clickSound.Load();

            // Подписываем все кнопки на событие
            SubscribeAllButtons(this);
        }

        private void SubscribeAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Если это кнопка
                if (c is Button button)
                {
                    button.Click += GlobalButtonClick;
                }
                // Если это контейнер (Panel, GroupBox и т.д.)
                else if (c.HasChildren)
                {
                    SubscribeAllButtons(c);
                }
            }
        }

        private void GlobalButtonClick(object sender, EventArgs e)
        {
            clickSound.Play();

            // Дополнительно: можно получить конкретную кнопку
            Button clickedButton = sender as Button;
            // clickedButton.Text - текст кнопки и т.д.
        }
        //Кнопка выхода из игры
        private void exitBTN_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Click);
            player.Play();

            if (DialogResult.Yes == MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        //Кнопка перехода на репозиторий GIT
        private void gitBTN_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/UstyantsewaME/Avoid-obstacles-in-amazing-world-of-Gumball-.git";
            System.Diagnostics.Process.Start(url);
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            SettingsMenu settingsMenu = new SettingsMenu();
            settingsMenu.Show();
            this.Hide();
        }

        private DateTime lastHoverTime = DateTime.MinValue;
        private void BTN_MouseEnter(object sender, EventArgs e)
        {
            if ((DateTime.Now - lastHoverTime).TotalMilliseconds < 100)
                return;

            lastHoverTime = DateTime.Now;

            SoundPlayer player = new SoundPlayer(Properties.Resources.Select);
            player.Play();
        }
    }
}
