using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Библиотека, необходимая для класса Path

namespace Курсовая___приложение_версия_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Computer48x; // Установка иконки для формы
            this.CenterToScreen(); // Центрирование формы
            groupBoxDevice.Hide();
            this.Resize += Form1_Resize;
        }
        private bool isSimulationRunning = false; // Флажок проверки запуска симуляции
        private bool imagesChanged = false; // Флажок проверки смены изображения

        private void CenterPanel(int panelWidth, int panelHeight) // Функция центрирования панели элементов
        {
            int centerX = (this.ClientSize.Width - panelWidth) / 2;
            int centerY = (this.ClientSize.Height - panelHeight) / 2;
            panelInstruments1.Location = new Point(centerX, centerY);
        }

        private void Form1_Resize(object sender, EventArgs e) // Функция для центрирования в случае сворачивания или разворачивания окна
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
                CenterPanel(panelInstruments1.Width, panelInstruments1.Height);
        }
        private void buttonCreateScheme_Click(object sender, EventArgs e) // Кнопка "Создать новую схему"
        {
            groupBoxDevice.Show();
        }

        private void buttonSimulation_Click(object sender, EventArgs e) // Кнопка "Запустить симуляцию"
        {
            // Условие проверки наличия изображения и неактивных елементов checkBox
            if (pictureBoxScheme.Image == null && !checkBoxAnd.Checked == true && !checkBoxOr.Checked == true && !checkBoxNot.Checked == true && !checkBoxXor.Checked == true && !checkBoxNand.Checked == true && !checkBoxNor.Checked == true)
                MessageBox.Show("В рабочей области нету схемы.\n" +
                                "Выберете устройства на панели инструментов, либо загрузите схему из проводника.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (pictureBoxScheme != null && !checkBoxAnd.Checked == true && !checkBoxOr.Checked == true && !checkBoxNot.Checked == true && !checkBoxXor.Checked == true && !checkBoxNand.Checked == true && !checkBoxNor.Checked == true)
            {
                textBoxOutcome.Text = null;
                textBoxEntrance.Text = null;
                textBoxExits.Text = null;
                textBoxStatus.Text = null;
            }
            var mappings = new Dictionary<string, (Image, string)> // Словарь с названиями изображений
            {
                { "AND", (Properties.Resources.AND, "AND") },
                { "OR", (Properties.Resources.OR, "OR") },
                { "NOT", (Properties.Resources.NOT, "NOT") },
                { "XOR", (Properties.Resources.XOR, "XOR") },
                { "NAND", (Properties.Resources.NAND, "NAND") },
                { "NOR", (Properties.Resources.NOR, "NOR") },
                { "AND_OR_NOT_XOR_NAND_NOR", (Properties.Resources.AND_OR_NOT_XOR_NAND_NOR, "AND-OR-NOT-XOR-NAND-NOR") },
                { "AND_OR", (Properties.Resources.AND_OR, "AND-OR") },
                { "AND_NOT", (Properties.Resources.AND_NOT, "AND-NOT") },
                { "AND_XOR", (Properties.Resources.AND_XOR, "AND-XOR") },
                { "AND_NAND", (Properties.Resources.AND_NAND, "AND-NAND") },
                { "AND_NOR", (Properties.Resources.AND_NOR, "AND-NOR") },
                { "OR_NOT", (Properties.Resources.OR_NOT, "OR-NOT") },
                { "OR_XOR", (Properties.Resources.OR_XOR, "OR-XOR") },
                { "OR_NAND", (Properties.Resources.OR_NAND, "OR-NAND") },
                { "OR_NOR", (Properties.Resources.OR_NOR, "OR-NOR") },
                { "NOT_XOR", (Properties.Resources.NOT_XOR, "NOT-XOR") },
                { "NOT_NAND", (Properties.Resources.NOT_NAND, "NOT-NAND") },
                { "NOT_NOR", (Properties.Resources.NOT_NOR, "NOT-NOR") },
                { "XOR_NAND", (Properties.Resources.XOR_NAND, "XOR-NAND") },
                { "XOR_NOR", (Properties.Resources.XOR_NOR, "XOR-NOR") },
                { "NAND_NOR", (Properties.Resources.NAND_NOR, "NAND-NOR") },
                { "AND_OR_NOT", (Properties.Resources.AND_OR_NOT, "AND-OR-NOT") },
                { "AND_OR_XOR", (Properties.Resources.AND_OR_XOR, "AND-OR-XOR") },
                { "AND_OR_NAND", (Properties.Resources.AND_OR_NAND, "AND-OR-NAND") },
                { "AND_OR_NOR", (Properties.Resources.AND_OR_NOR, "AND-OR-NOR") },
                { "OR_NOT_XOR", (Properties.Resources.OR_NOT_XOR, "OR-NOT-XOR") },
                { "OR_NOT_NAND", (Properties.Resources.OR_NOT_NAND, "OR-NOT-NAND") },
                { "OR_NOT_NOR", (Properties.Resources.OR_NOT_NOR, "OR-NOT-NOR") },
                { "NOT_XOR_NAND", (Properties.Resources.NOT_XOR_NAND, "NOT-XOR-NAND") },
                { "NOT_XOR_NOR", (Properties.Resources.NOT_XOR_NOR, "NOT-XOR-NOR") },
                { "XOR_NAND_NOR", (Properties.Resources.XOR_NAND_NOR, "XOR-NAND-NOR") },
                { "AND_NOT_NAND", (Properties.Resources.AND_NOT_NAND, "AND-NOT-NAND") },
                { "AND_NOT_XOR", (Properties.Resources.AND_NOT_XOR, "AND-NOT-XOR") },
                { "AND_NAND_NOR", (Properties.Resources.AND_NAND_NOR, "AND-NAND-NOR") },
                { "AND_NOT_NOR", (Properties.Resources.AND_NOT_NOR, "AND-NOT-NOR") },
                { "AND_XOR_NAND", (Properties.Resources.AND_XOR_NAND, "AND-XOR-NAND") },
                { "OR_XOR_NOR", (Properties.Resources.OR_XOR_NOR, "OR-XOR-NOR") },
                { "OR_NAND_NOR", (Properties.Resources.OR_NAND_NOR, "OR-NAND-NOR") },
                { "NOT_NAND_NOR", (Properties.Resources.NOT_NAND_NOR, "NOT-NAND-NOR") },
                { "AND_OR_NOT_XOR", (Properties.Resources.AND_OR_NOT_XOR, "AND-OR-NOT-XOR") },
                { "AND_OR_NOT_NAND", (Properties.Resources.AND_OR_NOT_NAND, "AND-OR-NOT-NAND") },
                { "AND_OR_NOT_NOR", (Properties.Resources.AND_OR_NOT_NOR, "AND-OR-NOT-NOR") },
                { "AND_OR_NAND_NOR", (Properties.Resources.AND_OR_NAND_NOR, "AND-OR-NAND-NOR") },
                { "AND_OR_XOR_NAND", (Properties.Resources.AND_OR_XOR_NAND, "AND-OR-XOR-NAND") },
                { "AND_OR_XOR_NOR", (Properties.Resources.AND_OR_XOR_NOR, "AND-OR-XOR-NOR") },
                { "AND_NOT_XOR_NAND", (Properties.Resources.AND_NOT_XOR_NAND, "AND-NOT-XOR-NAND") },
                { "AND_NOT_XOR_NOR", (Properties.Resources.AND_NOT_XOR_NOR, "AND-NOT-XOR-NOR") },
                { "AND_NOT_NAND_NOR", (Properties.Resources.AND_NOT_NAND_NOR, "AND-NOT-NAND-NOR") },
                { "AND_XOR_NAND_NOR", (Properties.Resources.AND_XOR_NAND_NOR, "AND-XOR-NAND-NOR") },
                { "OR_NOT_XOR_NAND", (Properties.Resources.OR_NOT_XOR_NAND, "OR-NOT-XOR-NAND") },
                { "OR_NOT_XOR_NOR", (Properties.Resources.OR_NOT_XOR_NOR, "OR-NOT-XOR-NOR") },
                { "OR_NOT_NAND_NOR", (Properties.Resources.OR_NOT_NAND_NOR, "OR-NOT-NAND-NOR") },
                { "OR_XOR_NAND_NOR", (Properties.Resources.OR_XOR_NAND_NOR, "OR-XOR-NAND-NOR") },
                { "NOT_XOR_NAND_NOR", (Properties.Resources.NOT_XOR_NAND_NOR, "NOT_XOR_NAND_NOR") },
                { "OR_NOT_XOR_NAND_NOR", (Properties.Resources.OR_NOT_XOR_NAND_NOR, "OR-NOT-XOR-NAND-NOR") },
                { "AND_NOT_XOR_NAND_NOR", (Properties.Resources.AND_NOT_XOR_NAND_NOR, "AND-NOT-XOR-NAND-NOR") },
                { "AND_OR_XOR_NAND_NOR", (Properties.Resources.AND_OR_XOR_NAND_NOR, "AND-OR-XOR-NAND-NOR") },
                { "AND_OR_NOT_NAND_NOR", (Properties.Resources.AND_OR_NOT_NAND_NOR, "AND-OR-NOT-NAND-NOR") },
                { "AND_OR_NOT_XOR_NOR", (Properties.Resources.AND_OR_NOT_XOR_NOR, "AND-OR-NOT-XOR-NOR") },
                { "AND_OR_NOT_XOR_NAND", (Properties.Resources.AND_OR_NOT_XOR_NAND, "AND-OR-NOT-XOR-NAND") },
            };
            var selectedOperations = new List<string>(); // Список элементов из которых строятся вариации схем
            if (checkBoxAnd.Checked) selectedOperations.Add("AND");
            if (checkBoxOr.Checked) selectedOperations.Add("OR");
            if (checkBoxNot.Checked) selectedOperations.Add("NOT");
            if (checkBoxXor.Checked) selectedOperations.Add("XOR");
            if (checkBoxNand.Checked) selectedOperations.Add("NAND");
            if (checkBoxNor.Checked) selectedOperations.Add("NOR");
            string key = string.Join("_", selectedOperations); // Ключ для удобного инициализирования названий изображений
            if (mappings.TryGetValue(key, out var mapping)) // Проверка на преобразование ключа в название изображений
            {
                isSimulationRunning = false;
                imagesChanged = true;
                pictureBoxScheme.SizeMode = PictureBoxSizeMode.Zoom; // Установка изображения в pictureBox
                pictureBoxScheme.Image = mapping.Item1; // Item1 - название файла
                textBoxFileName.Text = mapping.Item2; // Item2 - текст, вводимый в textBox с названием файла
            }
            else
            {
                pictureBoxScheme.Image = null;
                textBoxFileName.Text = string.Empty;
            }
            if (pictureBoxScheme.Image != null) // Проверка на повторную симуляцию
            {
                if (isSimulationRunning && !imagesChanged)
                    MessageBox.Show("Для данной схемы уже симулированы результаты.\n" +
                                    "Вставьте другую схему.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else // Если повторной симуляции не было, то грузятся результаты симуляции
                {
                    // Генерация данных симуляции в текстовые поля
                    Random randomFigure = new Random();
                    int firstFigure = randomFigure.Next(0, 2);
                    int secondFigure = randomFigure.Next(0, 2);
                    int thirdFigure = randomFigure.Next(0, 2);
                    textBoxOutcome.Text = $"{firstFigure} {secondFigure} {thirdFigure}";
                    textBoxEntrance.Text = $"{firstFigure} {secondFigure}";
                    textBoxExits.Text = $"{firstFigure} {secondFigure}";
                    // Генерация статуса компьютера
                    double probabilityStatus = 0.7;
                    Random randomStatus = new Random();
                    double statusComputer = randomStatus.NextDouble();
                    if (statusComputer < probabilityStatus)
                        textBoxStatus.Text = "Готов к работе";
                    else
                        textBoxStatus.Text = "Не готов к работе";
                    isSimulationRunning = true;
                }
            }
        }

        private void buttonSchemeLoading_Click(object sender, EventArgs e) // Кнопка "Загрузить схему"
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Открытие диалогового окна
            openFileDialog.Title = "Выберите изображение"; openFileDialog.Filter = "Изображения (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK) // Проверка на то, что трансляция диалогового окна закончилась нажатием кнопки "Открыть"
            {
                isSimulationRunning = false;
                imagesChanged = true;
                pictureBoxScheme.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxScheme.Image = Image.FromFile(openFileDialog.FileName); // Загрузка изображения
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(openFileDialog.FileName); // получение имя файла без расширения
                textBoxFileName.Text = fileNameWithoutExtension;
                checkBoxAnd.Checked = false;
                checkBoxOr.Checked = false;
                checkBoxNot.Checked = false;
                checkBoxXor.Checked = false;
                checkBoxNand.Checked = false;
                checkBoxNor.Checked = false;
                textBoxOutcome.Text = null;
                textBoxEntrance.Text = null;
                textBoxExits.Text = null;
                textBoxStatus.Text = null;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) // Кнопка сохранения схемы
        {
            string fileName = textBoxFileName.Text;
            using(SaveFileDialog saveFileDialog = new SaveFileDialog()) // Диалоговое окно с сохранением файла
            {
                saveFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                saveFileDialog.Title = "Сохранить изображение как";
                saveFileDialog.FileName = textBoxFileName.Text;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try // Конструкция обработки исключений
                    {
                        Image image = pictureBoxScheme.Image;
                        if (image != null)
                        {
                            image.Save(saveFileDialog.FileName);
                            MessageBox.Show("Изображение успешно сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Нет схемы для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex) // Если ошибка найдена, то выводится соответствующее сообщение
                    {
                        MessageBox.Show($"Ошибка при сохранении изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonStopSimulate_Click(object sender, EventArgs e) // Кнопка остановки симуляции
        {
            pictureBoxScheme.Image = null;
            textBoxOutcome.Text = null;
            textBoxEntrance.Text = null;
            textBoxExits.Text = null;
            textBoxStatus.Text = null;
            textBoxFileName.Text = null;
            checkBoxAnd.Checked = false;
            checkBoxOr.Checked = false;
            checkBoxNot.Checked = false;
            checkBoxXor.Checked = false;
            checkBoxNand.Checked = false;
            checkBoxNor.Checked = false;
            isSimulationRunning = false;
        }

        private void buttonReference_Click(object sender, EventArgs e) // Справка по программе
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }
    }
}
