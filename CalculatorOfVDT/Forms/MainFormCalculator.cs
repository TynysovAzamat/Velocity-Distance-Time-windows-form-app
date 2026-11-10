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
using CalculatorOfVDT.Forms;

namespace CalculatorOfVDT
{
    public partial class MainFormCalculator : Form
    {
        private AppExitFeature appExitFeature = new AppExitFeature();
        public MainFormCalculator()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(appExitFeature.ApplicationExit);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenVelocityCalculator_Click(object sender, EventArgs e)
        {
            VelocityCalculator velocityCalculator = new VelocityCalculator();
            velocityCalculator.Show();
            this.Hide();
        }

        private void OpenDistanceCalculator_Click(object sender, EventArgs e)
        {
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            distanceCalculator.Show();
            this.Hide();
        }

        private void OpenTimeCalculator_Click(object sender, EventArgs e)
        {
            TimeCalculator timeCalculator = new TimeCalculator();
            timeCalculator.Show();
            this.Hide();
        }

    }
}
