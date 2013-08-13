/* *Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
Real numbers, e.g. 5, 18.33, 3.14159, 12.6
Arithmetic operators: +, -, *, / (standard priorities)
Mathematical functions: ln(x), sqrt(x), pow(x,y)
Brackets (for changing the default priorities)
	Examples:
	(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
	pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  ~ 21.22
	Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Text;

class CalculateArithmeticalExpression
{
    private static List<char> brackets = new List<char>() { '(', ')'};
    private static List<char> arithmeticalOperations = new List<char>() { '+', '-', '*', '/'};
    private static List<string> functions = new List<string>() { "ln", "pow", "sqrt"};

    private static List<string> SeparateTokens(string input)
    {
        List<string> tokensList = new List<string>();
        StringBuilder number = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-' && (i == 0 || input[i - 1] == '(' || arithmeticalOperations.Contains(input[i - 1]) || input[i - 1] == ','))
            {
                number.Append(input[i]);
            }
            else if (char.IsDigit(input[i]) || input[i] == '.')
            {
                number.Append(input[i]);
            }
            else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
            {
                tokensList.Add(number.ToString());
                number.Clear();
                i--;
            }
            else if (brackets.Contains(input[i]))
            {
                tokensList.Add(input[i].ToString());
            }
            else if (arithmeticalOperations.Contains(input[i]))
            {
                tokensList.Add(input[i].ToString());
            }
            else if (i + 1 < input.Length && input.Substring(i, 2) == "ln")
            {
                tokensList.Add("ln");
                i++;
            }
            else if (i + 2 < input.Length && input.Substring(i, 3) == "pow")
            {
                tokensList.Add("pow");
                i += 2;
            }
            else if (i + 3 < input.Length && input.Substring(i, 4) == "sqrt")
            {
                tokensList.Add("sqrt");
                i += 3;
            }
            else if (input[i] == ',')
            {
                tokensList.Add(input[i].ToString());
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
        }

        if (number.Length != 0)
        {
            tokensList.Add(number.ToString()); 
        }

        return tokensList;
    }
    private static double calculateRPN(Queue<string> queue)
    {
        Stack<double> stack = new Stack<double>();

        while ( queue.Count != 0)
        {
            string currentToken = queue.Dequeue();
            double number;

            if (double.TryParse(currentToken, out number))
            {
                stack.Push(number);
            }
            else if (arithmeticalOperations.Contains(currentToken[0]) || functions.Contains(currentToken))
            {
                if (currentToken == "+")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression!");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(firstValue + secondValue);
                }
                else if (currentToken == "-")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression!");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue - firstValue);
                }
                else if (currentToken == "*")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression!");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue * firstValue);
                }
                else if (currentToken == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression!");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue / firstValue);
                }
                else if (currentToken == "pow")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression!");
                    }

                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(Math.Pow(secondValue, firstValue));
                }
                else if (currentToken == "sqrt")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid expression!");
                    }

                    double value = stack.Pop();

                    stack.Push(Math.Sqrt(value));
                }
                else if (currentToken == "ln")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid expression!");
                    }

                    double value = stack.Pop();

                    stack.Push(Math.Log(value));
                }
            }
            
        }
        if (stack.Count == 1)
        {
            return stack.Pop();
        }
        else
        {
            throw new ArgumentException("Invalid expression!");
        }
    }
    private static Queue<string> ShuntingYardConvertToReversedPolishNotation(List<string> inputList)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();

        for (int i = 0; i < inputList.Count; i++)
        {
            double number;

            if (double.TryParse(inputList[i], out number))
            {
                queue.Enqueue(inputList[i]);
            }
            else if (functions.Contains(inputList[i]))
            {
                stack.Push(inputList[i]);
            }
            else if (inputList[i] == ",")
            {
                if (!stack.Contains("(") || stack.Count == 0 )
                {
                    throw new ArgumentException("Invalid brackets or function separator!");
                }

                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }
            }
            else if (inputList[i] == "(")
            {
                stack.Push(inputList[i]);
            }
            else if (arithmeticalOperations.Contains(inputList[i][0]))
            {
                while (stack.Count != 0 && arithmeticalOperations.Contains(stack.Peek()[0]) && Precedence(inputList[i]) <= Precedence(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Push(inputList[i]); 
            }
            else if (inputList[i] == ")")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Invalid brackets position!");
                }

                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Pop();

                // tuk da vidq posle na ivo e razlichno
                if (stack.Count != 0 && functions.Contains(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
            }
        }

        while (stack.Count != 0)
        {
            if (brackets.Contains(stack.Peek()[0]))
            {
                throw new ArgumentException("Invalid brackets position!");
            }

            queue.Enqueue(stack.Pop());
        }

        return queue;
    }
    private static int Precedence(string arithmeticOperator)
    {
        if (arithmeticOperator == "+" || arithmeticOperator == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter your expression:");
        string input = Console.ReadLine().Replace(" ", null).ToLower();
        List<string> separatedTokens = SeparateTokens(input);
        Queue<string> reversedPolishNotation = ShuntingYardConvertToReversedPolishNotation(separatedTokens);
        double result = calculateRPN(reversedPolishNotation);

        Console.WriteLine("The result is : {0}", result);

        Main();
    }
}
