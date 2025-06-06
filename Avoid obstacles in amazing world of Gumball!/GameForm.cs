﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    public partial class GameForm : Form
    {
        private List<string> instructions = new List<string>();
        private int instructionIndex = 0;

        public GameForm()
        {
            InitializeComponent();
            SubscribeAllButtons(this);
            this.Opacity = 0;
            instructionIMG.Visible = true;
            tableLayoutPanel1.Visible = false;
            nextBTN.Visible = true;
            FadeInForm();

            // Загружаем инструкции из ресурсов
            var rawText = Properties.Resources.insrtuction;
            if (!string.IsNullOrWhiteSpace(rawText))
            {
                instructions = rawText
                    .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(line => line.Trim())
                    .Where(line => !string.IsNullOrWhiteSpace(line) && !line.EndsWith(":"))
                    .ToList();
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

        //Воспроизведение звука при наведении на кнопки
        private DateTime lastHoverTime = DateTime.MinValue;
        private void BTN_MouseEnter(object sender, EventArgs e)
        {
            if ((DateTime.Now - lastHoverTime).TotalMilliseconds < 100)
                return;

            lastHoverTime = DateTime.Now;
            SoundManager.PlaySelect();
        }

        private async void FadeInForm()
        {
            for (double opacity = 0; opacity <= 1.0; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(20);
            }
        }

        // Скрытие инструкции по нажатию на nextBTN
        private void nextBTN_Click(object sender, EventArgs e)
        {
            if (instructionIMG.Visible)
            {
                instructionIMG.Visible = false;
                tableLayoutPanel1.Visible = true;
                instructionLabel.Visible = true;
                instructionIndex = 0;
                ShowNextInstructionAsync();
            }
            else
            {
                ShowNextInstructionAsync();
            }
        }

        private async Task ShowNextInstructionAsync()
        {
            if (instructionIndex < instructions.Count)
            {
                instructionLabel.Visible = true;
                instructionLabel.Text = instructions[instructionIndex];
                nextBTN.Visible = true;

                // Показываем изображение персонажа на нужных шагах
                switch (instructionIndex)
                {
                    case 2: // 3-я строка (индексация с 0)
                        characterIMG.Image = Properties.Resources.Gumball;
                        characterIMG.Visible = true;
                        break;
                    case 3: // 4-я строка
                        characterIMG.Image = Properties.Resources.Darwin;
                        characterIMG.Visible = true;
                        break;
                    case 4: // 5-я строка
                        characterIMG.Image = Properties.Resources.Richard;
                        characterIMG.Visible = true;
                        break;
                    default:
                        characterIMG.Visible = false;
                        break;
                }

                instructionIndex++;
            }
            else
            {
                instructionLabel.Visible = false;
                nextBTN.Visible = false;
                characterIMG.Visible = false;
                tableLayoutPanel1.Visible = false;
                await SoundManager.FadeOutBackgroundMusic();
                // Здесь можно запустить игру или показать другие элементы
            }
        }

        private async void returnBTN_Click(object sender, EventArgs e)
        {
            // Если показывается инструкция (не первая)
            if (instructionLabel.Visible && instructionIndex > 1)
            {
                instructionIndex -= 2; // Шаг назад (т.к. после показа всегда ++)
                ShowNextInstructionAsync();
            }
            // Если показывается первая инструкция
            else if (instructionLabel.Visible && instructionIndex == 1)
            {
                instructionLabel.Visible = false;
                tableLayoutPanel1.Visible = false;
                instructionIMG.Visible = true;
                nextBTN.Visible = true;
            }
            // Если показывается картинка
            else if (instructionIMG.Visible)
            {
                var result = MessageBox.Show(
                    "Вы точно хотите выйти в главное меню?",
                    "Подтверждение выхода",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
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
            }
        }
    }
}
