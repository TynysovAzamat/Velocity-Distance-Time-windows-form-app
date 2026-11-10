using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorOfVDT.Scripts;

namespace CalculatorOfVDT.Forms
{
    public partial class DistanceCalculator : Form
    {
        public float Velocity { get; set; } = 0;

        public float Distance { get; set; } = 0;

        public float Time { get; set; } = 0;
        private AppExitFeature appExitFeature = new AppExitFeature();
        public DistanceCalculator()
        {
            InitializeComponent();
            Velocity = Result_TBX.Text == "" ? 0 : float.Parse(Result_TBX.Text);
            Distance = Number_1_TBX.Text == "" ? 0 : float.Parse(Number_1_TBX.Text);
            Time = Number_2_TBX.Text == "" ? 0 : float.Parse(Number_2_TBX.Text);
            Result_TBX.ReadOnly = true;
            this.FormClosed += new FormClosedEventHandler(appExitFeature.ApplicationExit);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (float.TryParse(Number_1_TBX.Text, out float velocity) && float.TryParse(Number_2_TBX.Text, out float time))
            {
                try
                {
                    Velocity = Calculate(velocity, time);
                    Result_TBX.Text = Velocity.ToString();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для расстояния и времени.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VarriableChecks(float velocity, float time)
        {
            if (velocity < 0 || time < 0)
            {
                MessageBox.Show("Distance and time cannot be negative.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (time == 0 || velocity == 0)
            {
                MessageBox.Show("Distance and time cannot be zero when calculating velocity.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public float Calculate(float velocity, float time)
        {
            VarriableChecks(velocity, time);
            return velocity * time;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainFormCalculator mainMenu = new MainFormCalculator();
            mainMenu.Show();
        }
    }
}
