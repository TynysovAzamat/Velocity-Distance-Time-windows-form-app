namespace CalculatorOfVDT
{
    partial class MainFormCalculator
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
            this.OpenVelocityCalculator = new System.Windows.Forms.Button();
            this.OpenDistanceCalculator = new System.Windows.Forms.Button();
            this.OpenTimeCalculator = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenVelocityCalculator
            // 
            this.OpenVelocityCalculator.Location = new System.Drawing.Point(63, 48);
            this.OpenVelocityCalculator.Name = "OpenVelocityCalculator";
            this.OpenVelocityCalculator.Size = new System.Drawing.Size(163, 216);
            this.OpenVelocityCalculator.TabIndex = 0;
            this.OpenVelocityCalculator.Text = "Калькулятор скорости";
            this.OpenVelocityCalculator.UseVisualStyleBackColor = true;
            this.OpenVelocityCalculator.Click += new System.EventHandler(this.OpenVelocityCalculator_Click);
            // 
            // OpenDistanceCalculator
            // 
            this.OpenDistanceCalculator.Location = new System.Drawing.Point(316, 48);
            this.OpenDistanceCalculator.Name = "OpenDistanceCalculator";
            this.OpenDistanceCalculator.Size = new System.Drawing.Size(163, 216);
            this.OpenDistanceCalculator.TabIndex = 1;
            this.OpenDistanceCalculator.Text = "Калькулятор растояния";
            this.OpenDistanceCalculator.UseVisualStyleBackColor = true;
            this.OpenDistanceCalculator.Click += new System.EventHandler(this.OpenDistanceCalculator_Click);
            // 
            // OpenTimeCalculator
            // 
            this.OpenTimeCalculator.Location = new System.Drawing.Point(571, 48);
            this.OpenTimeCalculator.Name = "OpenTimeCalculator";
            this.OpenTimeCalculator.Size = new System.Drawing.Size(163, 216);
            this.OpenTimeCalculator.TabIndex = 2;
            this.OpenTimeCalculator.Text = "Калькулятор времени";
            this.OpenTimeCalculator.UseVisualStyleBackColor = true;
            this.OpenTimeCalculator.Click += new System.EventHandler(this.OpenTimeCalculator_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(608, 374);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(163, 42);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainFormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.OpenTimeCalculator);
            this.Controls.Add(this.OpenDistanceCalculator);
            this.Controls.Add(this.OpenVelocityCalculator);
            this.Name = "MainFormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenVelocityCalculator;
        private System.Windows.Forms.Button OpenDistanceCalculator;
        private System.Windows.Forms.Button OpenTimeCalculator;
        private System.Windows.Forms.Button exitButton;
    }
}

