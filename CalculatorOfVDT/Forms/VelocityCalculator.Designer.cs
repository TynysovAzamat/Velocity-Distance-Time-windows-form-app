namespace CalculatorOfVDT
{
    partial class VelocityCalculator
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
            this.Number_1_TBX = new System.Windows.Forms.TextBox();
            this.Number_2_TBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result_TBX = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number_1_TBX
            // 
            this.Number_1_TBX.Location = new System.Drawing.Point(69, 83);
            this.Number_1_TBX.Name = "Number_1_TBX";
            this.Number_1_TBX.Size = new System.Drawing.Size(137, 22);
            this.Number_1_TBX.TabIndex = 0;
            // 
            // Number_2_TBX
            // 
            this.Number_2_TBX.Location = new System.Drawing.Point(69, 185);
            this.Number_2_TBX.Name = "Number_2_TBX";
            this.Number_2_TBX.Size = new System.Drawing.Size(137, 22);
            this.Number_2_TBX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(66, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "---------------------------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(268, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 76);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // Result_TBX
            // 
            this.Result_TBX.Location = new System.Drawing.Point(370, 129);
            this.Result_TBX.Name = "Result_TBX";
            this.Result_TBX.Size = new System.Drawing.Size(85, 22);
            this.Result_TBX.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(110, 246);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(326, 51);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Провести расчёт";
            this.calculateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(312, 323);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выйти в главное меню";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(40, 45);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(77, 16);
            this.DistanceLabel.TabIndex = 7;
            this.DistanceLabel.Text = "Растояние";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(40, 152);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(48, 16);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Время";
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(346, 103);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(68, 16);
            this.VelocityLabel.TabIndex = 9;
            this.VelocityLabel.Text = "Скорость";
            // 
            // VelocityCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 369);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.Result_TBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number_2_TBX);
            this.Controls.Add(this.Number_1_TBX);
            this.Name = "VelocityCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VelocityCalculator";
            this.Load += new System.EventHandler(this.VelocityCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number_1_TBX;
        private System.Windows.Forms.TextBox Number_2_TBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Result_TBX;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label VelocityLabel;
    }
}