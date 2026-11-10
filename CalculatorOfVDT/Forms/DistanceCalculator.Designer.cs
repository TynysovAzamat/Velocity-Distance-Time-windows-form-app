namespace CalculatorOfVDT.Forms
{
    partial class DistanceCalculator
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
            this.Number_2_TBX = new System.Windows.Forms.TextBox();
            this.Number_1_TBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(21, 62);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(68, 16);
            this.VelocityLabel.TabIndex = 19;
            this.VelocityLabel.Text = "Скорость";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(266, 62);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(48, 16);
            this.TimeLabel.TabIndex = 18;
            this.TimeLabel.Text = "Время";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(537, 62);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(77, 16);
            this.DistanceLabel.TabIndex = 17;
            this.DistanceLabel.Text = "Растояние";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(457, 310);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Выйти в главное меню";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(136, 187);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(398, 51);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Провести расчёт";
            this.calculateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Result_TBX
            // 
            this.Result_TBX.Location = new System.Drawing.Point(522, 100);
            this.Result_TBX.Name = "Result_TBX";
            this.Result_TBX.Size = new System.Drawing.Size(110, 22);
            this.Result_TBX.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(444, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 76);
            this.label2.TabIndex = 13;
            this.label2.Text = "=";
            // 
            // Number_2_TBX
            // 
            this.Number_2_TBX.Location = new System.Drawing.Point(301, 100);
            this.Number_2_TBX.Name = "Number_2_TBX";
            this.Number_2_TBX.Size = new System.Drawing.Size(137, 22);
            this.Number_2_TBX.TabIndex = 11;
            // 
            // Number_1_TBX
            // 
            this.Number_1_TBX.Location = new System.Drawing.Point(60, 100);
            this.Number_1_TBX.Name = "Number_1_TBX";
            this.Number_1_TBX.Size = new System.Drawing.Size(137, 22);
            this.Number_1_TBX.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(236, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            // 
            // DistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(675, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.Result_TBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Number_2_TBX);
            this.Controls.Add(this.Number_1_TBX);
            this.KeyPreview = true;
            this.Name = "DistanceCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistanceCalculator";
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
        private System.Windows.Forms.TextBox Number_2_TBX;
        private System.Windows.Forms.TextBox Number_1_TBX;
        private System.Windows.Forms.Label label1;
    }
}