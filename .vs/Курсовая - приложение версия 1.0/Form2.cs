﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая___приложение_версия_1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Icon = SystemIcons.Information; // Установка иконки
            this.CenterToScreen(); // Центрирование формы
            this.Resize += Form2_Resize;
        }
        private void CenterPanel(int panelWidth, int panelHeight) // Функция центрирования панели элементов
        {
            int centerX = (this.ClientSize.Width - panelWidth) / 2;
            int centerY = (this.ClientSize.Height - panelHeight) / 2;
            panelInstruments2.Location = new Point(centerX, centerY);
        }

        private void Form2_Resize(object sender, EventArgs e) // Функция для центрирования в случае сворачивания или разворачивания окна
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
                CenterPanel(panelInstruments2.Width, panelInstruments2.Height);
        }
        private void buttonBackward_Click(object sender, EventArgs e) // Закрытие формы
        {
            this.Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e) // Выбор раздела информации для отображения его в messageBox
        {
            string title;
            string message;
            if (radioButtonDescription.Checked == true)
            {
                title = "Описание программы";
                // Вербатим строка описания программы
                message = @"                  Л О Г И Ч Е С К И Е      У С Т Р О Й С Т В А
--------------------------------------------------------------------------------
        Название программы: ПО ""Логические устройства""
        Язык программирования: C#
        Платформа: Visual Studio
        Проект: Windows Forms
        Разработчик: студент группы 23ИСП-1 Синиченко С. А.
        Версия приложения: 1.2.4
        Программа представляет собой простое графическое приложение, Разработанное на языке программирования C# с использованием Windows Forms. Она позволяет пользователю исследовать работу логических устройств с помощью построения логических схем, которые позволяют визуально отобразить их работу.
        Цель программы:
        В программе реализованы функции, с помощью которых можно загружать свои схемы логических устройств, строить и сохранять построенные схемы на диск компьютера, а также симулировать работу устройств и получать результаты симуляции.
--------------------------------------------------------------------------------";
            }  
            else if (radioButtonGuide.Checked == true)
            {
                title = "Рукодоство пользователя";
                // Вербатим строка руководства пользователя
                message = @"                                                                                                   Р У К О В О Д С Т В О       П О Л Ь З О В А Т Е Л Я
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	            Алгоритм работы программы:
	Для того, чтобы составить новую схему логических устройств, нажмите кнопку ""Создать новую схему"", которая расположена в левом верхнем углу окна. Появится ""Панель инструментов"", где вы можете выбрать соответствующую вариацию логических устройств, из которых будет построена схема после нажатия на кнопку ""Запустить симуляцию"", которая располагается ниже рабочей области. После нажатия на кнопку на рабочей области отобразится схема логических устройств, которые вы выбрали на панели инструментов. Также в нижней части окна можно просмотреть вывод результатов симуляции:
                - Результаты симуляции(состоят только из бинарных ""1"" и ""0"")
                - Входы
                - Выходы
    Вместе с выводом результатов симуляции можно просмотреть статус работы компьютера, который отображается ниже вывода результатов симуляции.
Симуляцию можно остановить, нажав на кнопку ""Остановить симуляцию""(которая располагается правее кнопки ""Запустить симуляцию""), тем самым очистить текстовые поля вывода результатов, статуса компьютера и поле рабочей области.
                Функционал программы:
        1) Загрузка схемы из вне
    Для того, чтобы загрузить схему из другого носителя или импортировать схему, нужно нажать на кнопку ""Загрузить схему"", которая расположена в верхней панели окна рядом с кнопкой ""Создать новую схему"".После чего откроется диалоговое окно, в котором вы можете выбрать место, где хранится ваша схема, которая обязательно должна быть следующих форматов:
                - .jpg
                - .jpeg
                - .png
                - .bmp
После выбора соответствующего файла вы можете нажать на кнопку ""Открыть"" и схема будет загружена на рабочую область.
        2) Сохранение схемы
    Для того, чтобы сохранить построенную схему, вам необходимо нажать на кнопку ""Сохранить"", которая находится справа от кнопки ""Загрузить схему"".Откроется диалоговое окно, где можно выбрать место хранения файла с соответствующим расширением и вписать название файла, после чего нажать на кнопку ""Сохранить"".Расширения остаются теми же, что и при загрузке схемы из вне, но добавляется возможность сохранения схемы с расширением "".gif"".В программе реализована возможность вписать имя файла в специальное текстовое поле, которое находится под панелью инструментов справа и сопровождается надписью: ""Введите название файла:"".Вписав имя файла вы можете нажать на кнопку ""Сохранить"" и не вписывать в диалоговом окне сохранения файла его название.
        3) Справка
    Вы можете зайти в справку нажав на кнопку ""Справка"".В ней находятся три пункта:
-Описание программы
- Руководство пользователя
- Функции и возможности
Выбрав один из пунктов, нажмите на кнопку ""ОТКРЫТЬ"".Вы перейдёте в новое окно, в котором будет отражена вся необходимая информация по соответствующим пунктам.
        4) Статус компьютера
    Статус компьютера может быть либо в состоянии ""Готов к работе"", либо ""Не готов к работе"".Он зависит от результатов симуляции и как правило, в редких случаях, он может быть ""не готовым к работе"", так как обычно в программах такого рода редко возникают сбои. Главное чтобы схема, которую вы импортируете в программу, была читабельной для неё, иначе будет выводиться статус ""Не готов к работе"".
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            }
            else
            {
                title = "Функции и возможности";
                // Вербатим строка функций и возможностей программы
                message = @"                                                                                                     Ф У Н К Ц И И      И      В О З М О Ж Н О С Т И
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	        В данном программном продукте реализованы следующие функции:
    1) Функция создания схемы. Программа позволяет создавать свои собственные схемы логических устройств с помощью выбираемых вариаций компонентов компьютера. Каждая индивидуальная вариация создаёт свою, отличную от другой, схему, которая в итоге позволяет получить результаты симуляции этих вариаций. Также можно просмотреть состояние компьютера, которое зависит от результатов симуляции.
    2) Функция импортирования схемы в программу. В функционале программы присутствует функция загрузки посторонних файлов в программу, что позволяет анализировать не только вариации устройств, которые программа предоставляет пользователю, но и посторонние схемы. Нельзя загружать схемы, которые не содержат логических устройств, предоставляемых программой пользователю.
Список устройств, которые присутствуют на панели инструментов:
        - AND
        - OR
        - NOT
        - XOR
        - NAND
        - NOR
    3) Функция сохранения построенной схемы. Пользователь может сохранять схемы, построенные на основе выбранной вариации логических устройств. Сохранить схему можно на любой носитель или место, где предоставляется возможным сохранить файл соответствующего расширения. Сохраняется только схема, без результатов симуляции и состояния компьютера. Если вам будут нужны данные, которые получаются после симуляции схемы, загрузите её в программу - она обработает и выдаст вам необходимую информацию.
	        В программном приложении присутствуют следующие возможности:
    1) Возможность остановить симуляцию работы логических устройств. Эта возможность позволяет удалить любую схему, которая отображается на рабочей области, а также стереть все результаты симуляции и состояние компьютера. Возможность реализована через нажатие кнопки ""Остановить симуляцию"" и удобна, когда поработал с конкретной схемой, проанализировал работу устройств и хочешь построить новую схему. Этой возможностью можно не пользоваться, а построить новую схему или импортировать из вне, ведь в любом случае у вас пропадёт вся информация о прошлой схеме, если вы начнёте делать новую или загрузите с компьютера другую.
    2) Возможность создавать большое количество схем. Эта возможность является самой главной среди остальных, так как она позволяет проанализировать работу логических устройств компьютера в различных ситуациях, в различной компановке. В панели инструментов можно выбирать любую вариацию задействования логических устройств. Всего вариантов схем, построенных вами в этой программе может быть 61.Данный факт позволяет понять, что именно это программа даёт возможности для подробного изучения построения схем логических устройств.
    3) Возможность анализа получаемых результатов симуляции работы логических устройств компьютера.В этой программе демонстрируются результаты симуляций устройств, что помогает улучшить понимание работы логических устройств.Данная возможность необходима в программах такого рода, так как без результатов вы не сможете сделать выводов по работе схемы, а просто увидите в одном из возможных представлений набор устройств, которые выбрали на панели инструментов.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            }
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information); // Отображение раздела информации
        }
    }
}
