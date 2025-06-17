
namespace Курсовая___приложение_версия_1._0
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxListPoint = new System.Windows.Forms.GroupBox();
            this.radioButtonFunction = new System.Windows.Forms.RadioButton();
            this.radioButtonGuide = new System.Windows.Forms.RadioButton();
            this.radioButtonDescription = new System.Windows.Forms.RadioButton();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInstruments2 = new System.Windows.Forms.Panel();
            this.groupBoxListPoint.SuspendLayout();
            this.panelInstruments2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxListPoint
            // 
            this.groupBoxListPoint.Controls.Add(this.radioButtonFunction);
            this.groupBoxListPoint.Controls.Add(this.radioButtonGuide);
            this.groupBoxListPoint.Controls.Add(this.radioButtonDescription);
            this.groupBoxListPoint.Location = new System.Drawing.Point(16, 33);
            this.groupBoxListPoint.Name = "groupBoxListPoint";
            this.groupBoxListPoint.Size = new System.Drawing.Size(429, 166);
            this.groupBoxListPoint.TabIndex = 0;
            this.groupBoxListPoint.TabStop = false;
            // 
            // radioButtonFunction
            // 
            this.radioButtonFunction.AutoSize = true;
            this.radioButtonFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFunction.Location = new System.Drawing.Point(97, 111);
            this.radioButtonFunction.Name = "radioButtonFunction";
            this.radioButtonFunction.Size = new System.Drawing.Size(235, 24);
            this.radioButtonFunction.TabIndex = 2;
            this.radioButtonFunction.TabStop = true;
            this.radioButtonFunction.Text = "Функции и возможности";
            this.radioButtonFunction.UseVisualStyleBackColor = true;
            // 
            // radioButtonGuide
            // 
            this.radioButtonGuide.AutoSize = true;
            this.radioButtonGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonGuide.Location = new System.Drawing.Point(97, 65);
            this.radioButtonGuide.Name = "radioButtonGuide";
            this.radioButtonGuide.Size = new System.Drawing.Size(263, 24);
            this.radioButtonGuide.TabIndex = 1;
            this.radioButtonGuide.TabStop = true;
            this.radioButtonGuide.Text = "Руководство пользователя";
            this.radioButtonGuide.UseVisualStyleBackColor = true;
            // 
            // radioButtonDescription
            // 
            this.radioButtonDescription.AutoSize = true;
            this.radioButtonDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonDescription.Location = new System.Drawing.Point(97, 21);
            this.radioButtonDescription.Name = "radioButtonDescription";
            this.radioButtonDescription.Size = new System.Drawing.Size(211, 24);
            this.radioButtonDescription.TabIndex = 0;
            this.radioButtonDescription.TabStop = true;
            this.radioButtonDescription.Text = "Описание программы";
            this.radioButtonDescription.UseVisualStyleBackColor = true;
            // 
            // buttonBackward
            // 
            this.buttonBackward.Location = new System.Drawing.Point(16, 227);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(168, 42);
            this.buttonBackward.TabIndex = 1;
            this.buttonBackward.Text = "НАЗАД";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(277, 227);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(168, 42);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "ОТКРЫТЬ";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберете пункт:";
            // 
            // panelInstruments2
            // 
            this.panelInstruments2.BackColor = System.Drawing.SystemColors.Info;
            this.panelInstruments2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInstruments2.Controls.Add(this.label1);
            this.panelInstruments2.Controls.Add(this.buttonOpen);
            this.panelInstruments2.Controls.Add(this.groupBoxListPoint);
            this.panelInstruments2.Controls.Add(this.buttonBackward);
            this.panelInstruments2.Location = new System.Drawing.Point(13, 13);
            this.panelInstruments2.Name = "panelInstruments2";
            this.panelInstruments2.Size = new System.Drawing.Size(461, 279);
            this.panelInstruments2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 298);
            this.Controls.Add(this.panelInstruments2);
            this.Name = "Form2";
            this.Text = "Справка по использованию";
            this.groupBoxListPoint.ResumeLayout(false);
            this.groupBoxListPoint.PerformLayout();
            this.panelInstruments2.ResumeLayout(false);
            this.panelInstruments2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListPoint;
        private System.Windows.Forms.RadioButton radioButtonFunction;
        private System.Windows.Forms.RadioButton radioButtonGuide;
        private System.Windows.Forms.RadioButton radioButtonDescription;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInstruments2;
    }
}