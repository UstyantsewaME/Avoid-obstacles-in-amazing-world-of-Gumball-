using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    public static class SoundManager
    {
        [DllImport("winmm.dll")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        private static float soundVolume = 1.0f;
        private static float musicVolume = 1.0f;
        private static MediaPlayer backgroundMusic;
        private static bool isFadingOut = false;

        //Громкость звуков 
        public static float SoundVolume
        {
            get { return soundVolume; }
            set
            {
                soundVolume = Math.Max(0, Math.Min(1, value));
                uint windowsVolume = (uint)(soundVolume * 65535);
                uint fullVolume = (windowsVolume << 16) | windowsVolume;
                waveOutSetVolume(IntPtr.Zero, fullVolume);
            }
        }

        //Громкость музыки 
        public static float MusicVolume
        {
            get { return musicVolume; }
            set
            {
                musicVolume = Math.Max(0, Math.Min(1, value));
                if (backgroundMusic != null && !isFadingOut)
                {
                    backgroundMusic.Volume = musicVolume;
                }
            }
        }

        //Инициализация фоновой музыки
        public static void InitializeBackgroundMusic()
        {
            try
            {
                if (backgroundMusic == null)
                {
                    backgroundMusic = new MediaPlayer();

                    // Создаем временный файл из ресурсов
                    string tempFile = Path.Combine(Path.GetTempPath(), "Main_theme.wav");

                    // Преобразуем ресурс в byte[] и сохраняем во временный файл
                    using (var stream = Properties.Resources.Main_theme)
                    {
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        File.WriteAllBytes(tempFile, buffer);
                    }

                    backgroundMusic.Open(new Uri(tempFile));
                    backgroundMusic.MediaEnded += (s, e) => {
                        backgroundMusic.Position = TimeSpan.Zero;
                        backgroundMusic.Play();
                    };
                    backgroundMusic.Volume = musicVolume;
                    backgroundMusic.Play();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ошибка инициализации музыки: " + ex.Message);
            }
        }

        //Плавное затухание и остановка фоновой музыки
        public static async Task FadeOutBackgroundMusic(int fadeDurationMs = 1000)
        {
            if (backgroundMusic == null || isFadingOut)
                return;

            try
            {
                isFadingOut = true;
                float startVolume = (float)backgroundMusic.Volume;
                float volumeStep = (float)(startVolume / (fadeDurationMs / 50)); // Update every 50ms

                while (backgroundMusic.Volume > 0)
                {
                    backgroundMusic.Volume = Math.Max(0, backgroundMusic.Volume - volumeStep);
                    await Task.Delay(50);
                }

                StopBackgroundMusic();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ошибка затухания музыки: " + ex.Message);
            }
            finally
            {
                isFadingOut = false;
            }
        }

        //Остановка фоновой музыки
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

        //Проигрывание звука клика
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

        //Проигрывание звука при наведении
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

        //Инициализация настроек звука
        public static void Initialize()
        {
            SoundVolume = (float)Properties.Settings.Default.SoundVolume;
            MusicVolume = (float)Properties.Settings.Default.MusicVolume;
        }
    }
}