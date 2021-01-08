using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseJiggler2021.Extensions.Controls
{
    public class ExNumUpDwn : NumericUpDown
    {
        public double ValueDbl
        {
            get
            {
                return Convert.ToDouble(this.Value);
            }
            set
            {
                this.Value = Convert.ToDecimal(value);
            }
        }

        public int ValueInt
        {
            get
            {
                return Convert.ToInt32(this.Value);
            }
            set
            {
                this.Value = value;
            }
        }
        
    }
}
