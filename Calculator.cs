using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Addition()
            { 
            return FirstNumber + SecondNumber; 
        }

        public int Division()
        {
            return FirstNumber / SecondNumber;
        }

        public int Multiplication()
        {
            return FirstNumber * SecondNumber;
        }

        public int Subtraction()
        {
            return FirstNumber - SecondNumber;
        }
    }
}
