using System.Drawing.Printing;
using Lab01;

public class Calculator
{
    public Calculator()
    {
    }

    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
        // Use a switch statement to do the maths.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1, num2);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }

        return result;
    }

    public double BinaryAdd(String num1, String num2)
    {
        double res = 0;
        String num1Str = num1;
        String num2Str = num2;
        Console.WriteLine(">>>" + num1);
        if (num1Str.Contains("0.") && num2Str.Contains("0."))
        {

            String num1StrSplit = num1Str.Split(".")[1];
            String num2StrSplit = num2Str.Split(".")[1];

            String num3 = Reverse(num1StrSplit + num2StrSplit);

            Console.WriteLine(num3 + " is made of " + num2StrSplit + " and " + num1StrSplit);
            for (int pow = 0; pow < num3.Length; pow++)
            {
                double powSum = 0;
                if (num3[pow].Equals('1'))
                {
                    Console.WriteLine("pow = " + pow);
                    powSum = Math.Pow(2, pow);
                }

                res += powSum;
            }

            Console.WriteLine(res);
            return res;
        }

        return -1;
    }

    public string Reverse(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }

        return reverse;
    }

    public double Add(double num1, double num2)
    {
        return (num1 + num2);
    }

    public double AvailAdd(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0)
        {
            return Double.PositiveInfinity;
        }

        return (num1 + num2);
    }

    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }

    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }

    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            return Double.PositiveInfinity;
        }

        return (num1 / num2);
    }

    public double BasicReliabilityCfi(double num1, double num2, double num3)
    {
        if (num1 < 0 || num2 < 0 || num3 < 0)
        {
            return Double.PositiveInfinity;
        }

        return Math.Round(num1 * (1 - (num2 / num3)), 1);
    }
    
    public double BasicReliabilityFailureAtTime(double num1, double num2, double num3)
    {
        if (num1 < 0 || num2 < 0 || num3 < 0)
        {
            return Double.PositiveInfinity;
        }

        double var = num1 * (1 - Math.Exp((-num2 / num1) * num3));
        return Math.Round(var, 0);
    }
    public double DivideAvail(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0)
        {
            return Double.PositiveInfinity;
        }

        if (Double.IsPositiveInfinity(num2))
        {
            return Double.PositiveInfinity;
        }
        return (num1 / num2);
    }

    public double DefectDensityChange(double num1, double num2)
    {
        if (num1 <= 0)
        {
            return Double.NegativeInfinity;
        }
        return Math.Round((num1 - num2) / num1, 1);
    }

    public double Factorial(double num, double foo)
    {
        if (num < 0)
        {
            return Double.NegativeInfinity;

        }

        if ((int)num != num)
        {
            return Double.PositiveInfinity;
        }
        double res = 1;
        for (double i = num; i > 0; i--)
        {
            res *= i;
        }
        return res;
    }
    
    public double GenMagicNum(double input, IFileReader fileReader)
    {
        double result = 0;
        int choice = Convert.ToInt16(input);
//Dependency------------------------------
        // FileReader getTheMagic = new FileReader();
//----------------------------------------
        string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
        Console.WriteLine(root);
        string[] magicStrings = fileReader.Read(root + "/MagicNumbers.txt");
        if ((choice >= 0) && (choice < magicStrings.Length))
        {
            result = Convert.ToDouble(magicStrings[choice]);
        }
        result = (result > 0) ? (2 * result) : (-2 * result);
        Console.WriteLine(result);
        return result;
    }

    public double Fact(double num)
    {
        double res = 1;
        for (double i = num; i > 0; i--)
        {
            res *= i;
        }
        return res;
    }

    public double UnknownFunctionA(double num1, double num2)
    {
        double diff = num1 - num2;

        if (diff < 0 || num1 < 0)
        {
            throw new ArgumentException("Trying to factorial a negative number error.");
        }

        double diff_factorial = Fact(diff);
        double num1_factorial = Fact(num1);

        return num1_factorial / diff_factorial;

        //double res = 1;
        //if (num2 > num1)
        //{
        //    throw new ArgumentException("num2 must be smaller than num1.");
        //}
        //if (num1 < 0)
        //{
        //    throw new ArgumentException("num1 cannot be smaller than 0.");
        //}

        //for (double i = 0; i < num2; i++)
        //{
        //    res *= num1;
        //    num1--;
        //}

        //return res;
    }

    public double UnknownFunctionB(double num1, double num2)
    {
        double diff = num1 - num2;

        if (diff < 0 || num1 < 0)
        {
            throw new ArgumentException("Trying to factorial a negative number error.");
        }


        double diff_factorial = Fact(diff);
        double num1_factorial = Fact(num1);
        double num2_factorial = Fact(num2);

        return num1_factorial / (num2_factorial * diff_factorial);

        //if (num2 > num1)
        //{
        //    throw new ArgumentException("num2 must be smaller than num1.");
        //}
        //if (num1 < 0)
        //{
        //    throw new ArgumentException("num1 cannot be smaller than 0.");
        //}
        //if (num2 == num1)
        //{
        //    return 1;
        //}

        //return diff * num1;

    }

    public double Triangle(double b, double h)
    {
        if (b <= 0 || h <= 0)
        {
            throw new ArgumentException("Invalid Triangle Params");
        }
        return 0.5 * b * h;
    }

    public double Circle(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("Invalid Circle");
        }

        return Math.PI * r * r;
    }
}

