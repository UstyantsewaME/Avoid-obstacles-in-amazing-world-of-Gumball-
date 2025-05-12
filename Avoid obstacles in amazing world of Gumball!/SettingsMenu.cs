using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    public partial class SettingsMenu : Form
    {
        private SoundPlayer clickSound;
        public SettingsMenu()
        {
            InitializeComponent();
            clickSound = new SoundPlayer(Properties.Resources.Click);
            clickSound.Load();
            SubscribeAllButtons(this);
            
            // Устанавливаем значения из настроек
            btnSoundBar.Value = (int)(Properties.Settings.Default.SoundVolume * 10);
            musicBar.Value = (int)(Properties.Settings.Default.MusicVolume * 10);
            
            btnSoundBar.ValueChanged += BtnSoundBar_ValueChanged;
            musicBar.ValueChanged += MusicBar_ValueChanged;
        }

        private void BtnSoundBar_ValueChanged(object sender, EventArgs e)
        {
            float value = btnSoundBar.Value / 10.0f;
            SoundManager.SoundVolume = value;
            Properties.Settings.Default.SoundVolume = (decimal)value;
            Properties.Settings.Default.Save();
        }

        private void MusicBar_ValueChanged(object sender, EventArgs e)
        {
            float value = musicBar.Value / 10.0f;
            SoundManager.MusicVolume = value;
            Properties.Settings.Default.MusicVolume = (decimal)value;
            Properties.Settings.Default.Save();
        }

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

        private void GlobalButtonClick(object sender, EventArgs e)
        {
            SoundManager.PlayClick();
            Button clickedButton = sender as Button;
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
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
    }
}
