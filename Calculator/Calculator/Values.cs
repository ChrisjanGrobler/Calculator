using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Values
    {
        private float num1;
        private float num2;

        public float _num1 { get { return num1; } set { num1 = value; } }
        public float _num2 { get { return num2; } set { num2 = value; } }

        public Values() { }
        public Values(float num1, float num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
}
