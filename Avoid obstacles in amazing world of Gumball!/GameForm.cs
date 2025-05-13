using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            SubscribeAllButtons(this);
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

        //Воспроизведение звука при наведении на кнопки
        private DateTime lastHoverTime = DateTime.MinValue;
        private void BTN_MouseEnter(object sender, EventArgs e)
        {
            if ((DateTime.Now - lastHoverTime).TotalMilliseconds < 100)
                return;

            lastHoverTime = DateTime.Now;
            SoundManager.PlaySelect();
        }

        private async void returnBTN_Click(object sender, EventArgs e)
        {
            // Плавно скрываем текущую форму
            for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(20);
            }

            MainMenu mainMenu = new MainMenu();
            mainMenu.Opacity = 0;
            mainMenu.Show();

            // Плавно показываем главное меню
            for (double opacity = 0; opacity <= 1.0; opacity += 0.1)
            {
                mainMenu.Opacity = opacity;
                await Task.Delay(20);
            }

            SoundManager.InitializeBackgroundMusic();
            this.Close();
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
