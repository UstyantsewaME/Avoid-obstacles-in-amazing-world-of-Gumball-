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
            SubscribeAllButtons(this);
            SoundManager.InitializeBackgroundMusic();
        }

        //Обработка события закрытия формы
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                SoundManager.StopBackgroundMusic();
            }
        }

        //Подписка всех кнопок на глобальное событие клика
        private void SubscribeAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button button)
                {
                    button.Click += GlobalButtonClick;
                }
                else if (c.HasChildren)
                {
                    SubscribeAllButtons(c);
                }
            }
        }

        //Глобальное проигрывание звука при нажатии на кнопку
        private void GlobalButtonClick(object sender, EventArgs e)
        {
            SoundManager.PlayClick();
            Button clickedButton = sender as Button;
        }

        //Кнопка выхода из игры
        private void exitBTN_Click(object sender, EventArgs e)
        {
            SoundManager.PlayClick();

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

        //Кнопка перехода в настройки
        private async void settingsBTN_Click(object sender, EventArgs e)
        {
            // Плавно скрываем текущую форму
            for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(20);
            }

            SettingsMenu settingsMenu = new SettingsMenu();
            settingsMenu.Opacity = 0;
            settingsMenu.Show();

            // Плавно показываем форму настроек
            for (double opacity = 0; opacity <= 1.0; opacity += 0.1)
            {
                settingsMenu.Opacity = opacity;
                await Task.Delay(20);
            }

            this.Hide();
        }

        //Воспроизведение звука при наведении на кнопки
        private DateTime lastHoverTime = DateTime.MinValue;
        private void BTN_MouseEnter(object sender, EventArgs e)
        {
            if ((DateTime.Now - lastHoverTime).TotalMilliseconds < 100)
                return;

            lastHoverTime = DateTime.Now;
            SoundManager.PlaySelect();
        }

        private async void playBTN_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Opacity = 0;
            gameForm.Show();

            // Плавно скрываем текущую форму
            for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(20);
            }

            // Плавно показываем новую форму
            for (double opacity = 0; opacity <= 1.0; opacity += 0.1)
            {
                gameForm.Opacity = opacity;
                await Task.Delay(20);
            }

            this.Hide();
        }
    }
}