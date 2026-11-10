using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorOfVDT.Scripts;

namespace CalculatorOfVDT
{
    public partial class TimeCalculator : Form
    {

        public float Velocity { get; set; } = 0;

        public float Distance { get; set; } = 0;

        public float Time { get; set; } = 0;

        private AppExitFeature appExitFeature = new AppExitFeature();

        public TimeCalculator()
        {
            InitializeComponent();
            Velocity = Number_2_TBX.Text == "" ? 0 : float.Parse(Number_2_TBX.Text);
            Distance = Number_1_TBX.Text == "" ? 0 : float.Parse(Number_1_TBX.Text);
            Time = Result_TBX.Text == "" ? 0 : float.Parse(Result_TBX.Text);
            Result_TBX.ReadOnly = true;
            this.FormClosed += new FormClosedEventHandler(appExitFeature.ApplicationExit);
        }

        private void VelocityCalculator_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (float.TryParse(Number_1_TBX.Text, out float distance) && float.TryParse(Number_2_TBX.Text, out float velocity))
            {
                try
                {
                    Time = Calculate(distance, velocity);
                    Result_TBX.Text = Time.ToString();
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

        public void VarriableChecks(float distance, float velocity)
        {
            if (distance < 0 || velocity < 0)
            {
                MessageBox.Show("Distance and velocity cannot be negative.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (velocity == 0 || distance == 0)
            {
                MessageBox.Show("Distance and velocity cannot be zero when calculating velocity.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public float Calculate(float distance, float velocity)
        {
            VarriableChecks(distance, velocity);
            return distance / velocity;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainFormCalculator mainMenu = new MainFormCalculator();
            mainMenu.Show();
        }
    }
}
