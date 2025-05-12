using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.IO;

namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    public static class SoundManager
    {
        [DllImport("winmm.dll")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        private static float soundVolume = 1.0f;
        private static float musicVolume = 1.0f;
        private static MediaPlayer backgroundMusic;

        public static float SoundVolume
        {
            get { return soundVolume; }
            set
            {
                soundVolume = Math.Max(0, Math.Min(1, value));
                // Convert volume to Windows volume format (0-65535)
                uint windowsVolume = (uint)(soundVolume * 65535);
                // Set both left and right channels to the same volume
                uint fullVolume = (windowsVolume << 16) | windowsVolume;
                waveOutSetVolume(IntPtr.Zero, fullVolume);
            }
        }

        public static float MusicVolume
        {
            get { return musicVolume; }
            set
            {
                musicVolume = Math.Max(0, Math.Min(1, value));
                if (backgroundMusic != null)
                {
                    backgroundMusic.Volume = musicVolume;
                }
            }
        }

        public static void InitializeBackgroundMusic()
        {
            try
            {
                if (backgroundMusic == null)
                {
                    backgroundMusic = new MediaPlayer();
                    string musicPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "Main theme.mp3");
                    backgroundMusic.Open(new Uri(musicPath, UriKind.Absolute));
                    backgroundMusic.MediaEnded += (s, e) => {
                        backgroundMusic.Position = TimeSpan.Zero;
                        backgroundMusic.Play();
                    };
                    backgroundMusic.Volume = musicVolume;
                    backgroundMusic.Play();
                }
            }
            catch
            {
                // Игнорируем ошибки воспроизведения
            }
        }

        public static void StopBackgroundMusic()
        {
            try
            {
                if (backgroundMusic != null)
                {
                    backgroundMusic.Stop();
                    backgroundMusic.Close();
                    backgroundMusic = null;
                }
            }
            catch
            {
                // Игнорируем ошибки остановки
            }
        }

        public static void PlayClick()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(Properties.Resources.Click))
                {
                    player.Play();
                }
            }
            catch
            {
                // Игнорируем ошибки воспроизведения
            }
        }

        public static void PlaySelect()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(Properties.Resources.Select))
                {
                    player.Play();
                }
            }
            catch
            {
                // Игнорируем ошибки воспроизведения
            }
        }

        public static void Initialize()
        {
            SoundVolume = (float)Properties.Settings.Default.SoundVolume;
            MusicVolume = (float)Properties.Settings.Default.MusicVolume;
        }
    }
}