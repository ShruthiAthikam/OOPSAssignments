using System;


namespace Tools
{
   public class Calculator
    {
        public void Add(double operand1 , double operand2 , out double answer )
		{
            answer = operand1 + operand2;
        }
        public void Sub(double operand1, double operand2, out double answer)
        {
            answer = operand1 - operand2;
        }
        public void Mul(double operand1, double operand2, out double answer)
        {
            answer = operand1 * operand2;
        }
        public void Div(double operand1, double operand2, out double answer)
        {
            answer = operand1 / operand2;
        }
        public void Mod(double operand1, double operand2, out double answer)
        {
            answer = operand1 % operand2;
        }
        public void Pow(double operand1, double operand2, out double answer)
        {
            answer = Math.Pow(operand1,operand2);
        }
    }
}