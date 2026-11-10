using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOfVDT
{
    public abstract class CalculateVarriables
    {
        public virtual void VarriableChecks(float distance, float time, float velocity)
        {
            MessageBox.Show("Проверка переменных выполнена успешно.", "Проверка переменных", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public abstract float Calculate();
        
    }
}
