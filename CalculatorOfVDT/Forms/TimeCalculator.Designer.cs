namespace CalculatorOfVDT
{
    partial class TimeCalculator
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
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.Result_TBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Number_2_TBX = new System.Windows.Forms.TextBox();
            this.Number_1_TBX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(36, 141);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(68, 16);
            this.VelocityLabel.TabIndex = 19;
            this.VelocityLabel.Text = "Скорость";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(342, 92);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(48, 16);
            this.TimeLabel.TabIndex = 18;
            this.TimeLabel.Text = "Время";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(36, 34);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(77, 16);
            this.DistanceLabel.TabIndex = 17;
            this.DistanceLabel.Text = "Растояние";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(308, 312);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Выйти в главное меню";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(106, 235);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(326, 51);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Провести расчёт";
            this.calculateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Result_TBX
            // 
            this.Result_TBX.Location = new System.Drawing.Point(366, 118);
            this.Result_TBX.Name = "Result_TBX";
            this.Result_TBX.Size = new System.Drawing.Size(85, 22);
            this.Result_TBX.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(264, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 76);
            this.label2.TabIndex = 13;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(62, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "---------------------------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Number_2_TBX
            // 
            this.Number_2_TBX.Location = new System.Drawing.Point(65, 174);
            this.Number_2_TBX.Name = "Number_2_TBX";
            this.Number_2_TBX.Size = new System.Drawing.Size(137, 22);
            this.Number_2_TBX.TabIndex = 11;
            // 
            // Number_1_TBX
            // 
            this.Number_1_TBX.Location = new System.Drawing.Point(65, 72);
            this.Number_1_TBX.Name = "Number_1_TBX";
            this.Number_1_TBX.Size = new System.Drawing.Size(137, 22);
            this.Number_1_TBX.TabIndex = 10;
            // 
            // TimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 369);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.Result_TBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number_2_TBX);
            this.Controls.Add(this.Number_1_TBX);
            this.Name = "TimeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox Result_TBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Number_2_TBX;
        private System.Windows.Forms.TextBox Number_1_TBX;
    }
}