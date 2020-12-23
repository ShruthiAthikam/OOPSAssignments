using System;
using Tools;
using Tools.Support;

 class Ass2
{
  
    public static void Main(String[] input)
    {
        double ans;
        Calculator c = new Calculator();
        Screen s = new Screen();
        
        double operand1 = double.Parse(input[0]);
        double operand2 = double.Parse(input[2]);

       
        if(input[1]=="+")
			c.Add(operand1, operand2, out ans); 
		else if(input[1]=="-")
			c.Sub(operand1, operand2, out ans);
		else if(input[1]=="*")
			c.Mul(operand1, operand2, out ans);
		else if(input[1]=="/")
			c.Div(operand1, operand2, out ans);
		else if(input[1]=="%")
			c.Mod(operand1, operand2, out ans);
		else
			c.Pow(operand1, operand2, out ans);
		
		
		if ((input[1] == "/" || input[1] == "%") && operand2 == 0)
        {
            String errormessage = "ERROR: Cannot divide by zero! Program stopped.";
			s.Display(errormessage);
        }
		
        else
        {
		    s.Display("Answer is: " + ans.ToString());
        }

    }
}

