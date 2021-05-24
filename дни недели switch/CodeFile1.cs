using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
class Switch
{
    static void Main()
    {
        try
        {
            int number;
            string name;
            number = Int32.Parse(Interaction.InputBox("Введите число дня в неделе:", "Число"));
            switch (number)
            {
                case 1:
                    name = "Сегодня понедельник";
                    break;
                case 2:
                    name = "Сегодня вторник";
                    break;
                case 3:
                    name = "Сегодня среда";
                    break;
                case 4:
                    name = "Сегодня четверг";
                    break;
                case 5:
                    name = "Сегодня пятница";
                    break;
                case 6:
                    name = "Сегодня суббота";
                    break;
                case 7:
                    name = "Сегодня воскресенье";
                    break;
                default:
                    name = "Такого дня в неделе нет!";
                    break;
            }
            MessageBox.Show(name, "Число дня в неделе");
        }
        catch
        {
            MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        MessageBox.Show("Программа завершена", "Завершение");
    }
        }