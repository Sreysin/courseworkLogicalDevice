
namespace Курсовая___приложение_версия_1._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateScheme = new System.Windows.Forms.Button();
            this.buttonSchemeLoading = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listViewFrame = new System.Windows.Forms.ListView();
            this.buttonSimulation = new System.Windows.Forms.Button();
            this.buttonStopSimulate = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutcome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEntrance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewStatus = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonReference = new System.Windows.Forms.Button();
            this.pictureBoxScheme = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.groupBoxDevice = new System.Windows.Forms.GroupBox();
            this.checkBoxAnd = new System.Windows.Forms.CheckBox();
            this.checkBoxOr = new System.Windows.Forms.CheckBox();
            this.checkBoxNot = new System.Windows.Forms.CheckBox();
            this.checkBoxXor = new System.Windows.Forms.CheckBox();
            this.checkBoxNand = new System.Windows.Forms.CheckBox();
            this.checkBoxNor = new System.Windows.Forms.CheckBox();
            this.panelInstruments1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScheme)).BeginInit();
            this.groupBoxDevice.SuspendLayout();
            this.panelInstruments1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateScheme
            // 
            this.buttonCreateScheme.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCreateScheme.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateScheme.Name = "buttonCreateScheme";
            this.buttonCreateScheme.Size = new System.Drawing.Size(111, 45);
            this.buttonCreateScheme.TabIndex = 0;
            this.buttonCreateScheme.Text = "Создать новую схему";
            this.buttonCreateScheme.UseVisualStyleBackColor = true;
            this.buttonCreateScheme.Click += new System.EventHandler(this.buttonCreateScheme_Click);
            // 
            // buttonSchemeLoading
            // 
            this.buttonSchemeLoading.Location = new System.Drawing.Point(132, 12);
            this.buttonSchemeLoading.Name = "buttonSchemeLoading";
            this.buttonSchemeLoading.Size = new System.Drawing.Size(111, 45);
            this.buttonSchemeLoading.TabIndex = 1;
            this.buttonSchemeLoading.Text = "Загрузить схему";
            this.buttonSchemeLoading.UseVisualStyleBackColor = true;
            this.buttonSchemeLoading.Click += new System.EventHandler(this.buttonSchemeLoading_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(249, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 45);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listViewFrame
            // 
            this.listViewFrame.HideSelection = false;
            this.listViewFrame.Location = new System.Drawing.Point(12, 196);
            this.listViewFrame.Name = "listViewFrame";
            this.listViewFrame.Size = new System.Drawing.Size(509, 234);
            this.listViewFrame.TabIndex = 11;
            this.listViewFrame.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSimulation.Location = new System.Drawing.Point(12, 436);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(245, 29);
            this.buttonSimulation.TabIndex = 18;
            this.buttonSimulation.Text = "Запустить симуляцию";
            this.buttonSimulation.UseVisualStyleBackColor = true;
            this.buttonSimulation.Click += new System.EventHandler(this.buttonSimulation_Click);
            // 
            // buttonStopSimulate
            // 
            this.buttonStopSimulate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStopSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonStopSimulate.Location = new System.Drawing.Point(263, 436);
            this.buttonStopSimulate.Name = "buttonStopSimulate";
            this.buttonStopSimulate.Size = new System.Drawing.Size(245, 29);
            this.buttonStopSimulate.TabIndex = 19;
            this.buttonStopSimulate.Text = "Остановить симуляцию";
            this.buttonStopSimulate.UseVisualStyleBackColor = true;
            this.buttonStopSimulate.Click += new System.EventHandler(this.buttonStopSimulate_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(12, 507);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(509, 134);
            this.listViewResult.TabIndex = 20;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результаты симуляции:";
            // 
            // textBoxOutcome
            // 
            this.textBoxOutcome.Location = new System.Drawing.Point(211, 516);
            this.textBoxOutcome.Name = "textBoxOutcome";
            this.textBoxOutcome.ReadOnly = true;
            this.textBoxOutcome.Size = new System.Drawing.Size(297, 22);
            this.textBoxOutcome.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(136, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Входы:";
            // 
            // textBoxEntrance
            // 
            this.textBoxEntrance.Location = new System.Drawing.Point(211, 554);
            this.textBoxEntrance.Name = "textBoxEntrance";
            this.textBoxEntrance.ReadOnly = true;
            this.textBoxEntrance.Size = new System.Drawing.Size(297, 22);
            this.textBoxEntrance.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(126, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выходы:";
            // 
            // textBoxExits
            // 
            this.textBoxExits.Location = new System.Drawing.Point(211, 589);
            this.textBoxExits.Name = "textBoxExits";
            this.textBoxExits.ReadOnly = true;
            this.textBoxExits.Size = new System.Drawing.Size(297, 22);
            this.textBoxExits.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Рабочая область";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Вывод результатов";
            // 
            // listViewStatus
            // 
            this.listViewStatus.HideSelection = false;
            this.listViewStatus.Location = new System.Drawing.Point(12, 677);
            this.listViewStatus.Name = "listViewStatus";
            this.listViewStatus.Size = new System.Drawing.Size(509, 48);
            this.listViewStatus.TabIndex = 29;
            this.listViewStatus.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(129, 692);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Статус:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(211, 692);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(297, 22);
            this.textBoxStatus.TabIndex = 31;
            // 
            // buttonReference
            // 
            this.buttonReference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.buttonReference.Location = new System.Drawing.Point(410, 12);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(111, 45);
            this.buttonReference.TabIndex = 32;
            this.buttonReference.Text = "Справка";
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // pictureBoxScheme
            // 
            this.pictureBoxScheme.InitialImage = null;
            this.pictureBoxScheme.Location = new System.Drawing.Point(22, 209);
            this.pictureBoxScheme.Name = "pictureBoxScheme";
            this.pictureBoxScheme.Size = new System.Drawing.Size(490, 210);
            this.pictureBoxScheme.TabIndex = 33;
            this.pictureBoxScheme.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(13, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Введите название файла:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(231, 150);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(293, 22);
            this.textBoxFileName.TabIndex = 36;
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDisplay.Location = new System.Drawing.Point(77, 81);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(377, 48);
            this.labelDisplay.TabIndex = 37;
            this.labelDisplay.Text = "Нажмите кнопку \"Создать новую схему\" \r\nдля отображения панели инструментов\r\n";
            // 
            // groupBoxDevice
            // 
            this.groupBoxDevice.Controls.Add(this.checkBoxAnd);
            this.groupBoxDevice.Controls.Add(this.checkBoxOr);
            this.groupBoxDevice.Controls.Add(this.checkBoxNot);
            this.groupBoxDevice.Controls.Add(this.checkBoxXor);
            this.groupBoxDevice.Controls.Add(this.checkBoxNand);
            this.groupBoxDevice.Controls.Add(this.checkBoxNor);
            this.groupBoxDevice.Location = new System.Drawing.Point(15, 63);
            this.groupBoxDevice.Name = "groupBoxDevice";
            this.groupBoxDevice.Size = new System.Drawing.Size(509, 87);
            this.groupBoxDevice.TabIndex = 34;
            this.groupBoxDevice.TabStop = false;
            this.groupBoxDevice.Text = "Панель иструментов";
            // 
            // checkBoxAnd
            // 
            this.checkBoxAnd.Location = new System.Drawing.Point(159, 21);
            this.checkBoxAnd.Name = "checkBoxAnd";
            this.checkBoxAnd.Size = new System.Drawing.Size(103, 21);
            this.checkBoxAnd.TabIndex = 0;
            this.checkBoxAnd.Text = "AND";
            this.checkBoxAnd.UseVisualStyleBackColor = true;
            // 
            // checkBoxOr
            // 
            this.checkBoxOr.AutoSize = true;
            this.checkBoxOr.Location = new System.Drawing.Point(159, 48);
            this.checkBoxOr.Name = "checkBoxOr";
            this.checkBoxOr.Size = new System.Drawing.Size(51, 21);
            this.checkBoxOr.TabIndex = 13;
            this.checkBoxOr.Text = "OR";
            this.checkBoxOr.UseVisualStyleBackColor = true;
            // 
            // checkBoxNot
            // 
            this.checkBoxNot.AutoSize = true;
            this.checkBoxNot.Location = new System.Drawing.Point(288, 21);
            this.checkBoxNot.Name = "checkBoxNot";
            this.checkBoxNot.Size = new System.Drawing.Size(60, 21);
            this.checkBoxNot.TabIndex = 14;
            this.checkBoxNot.Text = "NOT";
            this.checkBoxNot.UseVisualStyleBackColor = true;
            // 
            // checkBoxXor
            // 
            this.checkBoxXor.AutoSize = true;
            this.checkBoxXor.Location = new System.Drawing.Point(288, 48);
            this.checkBoxXor.Name = "checkBoxXor";
            this.checkBoxXor.Size = new System.Drawing.Size(60, 21);
            this.checkBoxXor.TabIndex = 15;
            this.checkBoxXor.Text = "XOR";
            this.checkBoxXor.UseVisualStyleBackColor = true;
            // 
            // checkBoxNand
            // 
            this.checkBoxNand.AutoSize = true;
            this.checkBoxNand.Location = new System.Drawing.Point(413, 21);
            this.checkBoxNand.Name = "checkBoxNand";
            this.checkBoxNand.Size = new System.Drawing.Size(69, 21);
            this.checkBoxNand.TabIndex = 16;
            this.checkBoxNand.Text = "NAND";
            this.checkBoxNand.UseVisualStyleBackColor = true;
            // 
            // checkBoxNor
            // 
            this.checkBoxNor.AutoSize = true;
            this.checkBoxNor.Location = new System.Drawing.Point(413, 48);
            this.checkBoxNor.Name = "checkBoxNor";
            this.checkBoxNor.Size = new System.Drawing.Size(61, 21);
            this.checkBoxNor.TabIndex = 17;
            this.checkBoxNor.Text = "NOR";
            this.checkBoxNor.UseVisualStyleBackColor = true;
            // 
            // panelInstruments1
            // 
            this.panelInstruments1.BackColor = System.Drawing.SystemColors.Info;
            this.panelInstruments1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInstruments1.Controls.Add(this.groupBoxDevice);
            this.panelInstruments1.Controls.Add(this.labelDisplay);
            this.panelInstruments1.Controls.Add(this.textBoxFileName);
            this.panelInstruments1.Controls.Add(this.label1);
            this.panelInstruments1.Controls.Add(this.pictureBoxScheme);
            this.panelInstruments1.Controls.Add(this.buttonReference);
            this.panelInstruments1.Controls.Add(this.textBoxStatus);
            this.panelInstruments1.Controls.Add(this.label7);
            this.panelInstruments1.Controls.Add(this.listViewStatus);
            this.panelInstruments1.Controls.Add(this.label6);
            this.panelInstruments1.Controls.Add(this.label5);
            this.panelInstruments1.Controls.Add(this.textBoxExits);
            this.panelInstruments1.Controls.Add(this.label4);
            this.panelInstruments1.Controls.Add(this.textBoxEntrance);
            this.panelInstruments1.Controls.Add(this.label3);
            this.panelInstruments1.Controls.Add(this.textBoxOutcome);
            this.panelInstruments1.Controls.Add(this.label2);
            this.panelInstruments1.Controls.Add(this.listViewResult);
            this.panelInstruments1.Controls.Add(this.buttonStopSimulate);
            this.panelInstruments1.Controls.Add(this.buttonSimulation);
            this.panelInstruments1.Controls.Add(this.listViewFrame);
            this.panelInstruments1.Controls.Add(this.buttonSave);
            this.panelInstruments1.Controls.Add(this.buttonSchemeLoading);
            this.panelInstruments1.Controls.Add(this.buttonCreateScheme);
            this.panelInstruments1.Location = new System.Drawing.Point(5, 0);
            this.panelInstruments1.Name = "panelInstruments1";
            this.panelInstruments1.Size = new System.Drawing.Size(533, 733);
            this.panelInstruments1.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(543, 738);
            this.Controls.Add(this.panelInstruments1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(3000, 1800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исследование логических устройств";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScheme)).EndInit();
            this.groupBoxDevice.ResumeLayout(false);
            this.groupBoxDevice.PerformLayout();
            this.panelInstruments1.ResumeLayout(false);
            this.panelInstruments1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateScheme;
        private System.Windows.Forms.Button buttonSchemeLoading;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListView listViewFrame;
        private System.Windows.Forms.Button buttonSimulation;
        private System.Windows.Forms.Button buttonStopSimulate;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEntrance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxExits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.PictureBox pictureBoxScheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.GroupBox groupBoxDevice;
        private System.Windows.Forms.CheckBox checkBoxAnd;
        private System.Windows.Forms.CheckBox checkBoxOr;
        private System.Windows.Forms.CheckBox checkBoxNot;
        private System.Windows.Forms.CheckBox checkBoxXor;
        private System.Windows.Forms.CheckBox checkBoxNand;
        private System.Windows.Forms.CheckBox checkBoxNor;
        private System.Windows.Forms.Panel panelInstruments1;
    }
}

