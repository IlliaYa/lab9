using System;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        var stack = new Stack<int>();

        var comand = Console.ReadLine();
        while (!comand.Equals("END"))
        {
            var comandArgs = comand.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (comandArgs[0] is "Push")
            {
                var numbers = comandArgs.Skip(1).ToList().Select(int.Parse).ToList();
                foreach (var number in numbers)
                {
                    stack.Push(number);
                }
            }
            else if (comandArgs[0] is "Pop")
            {
                try
                {
                    stack.Pop();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                continue;
            }
            comand = Console.ReadLine();
        }

        var result = GetStringResult(stack);

        if (result != string.Empty)
        {
            Console.WriteLine($"{result}{Environment.NewLine}{result}");
        }
    }

    private static string GetStringResult(Stack<int> stack)
    {
        var sb = new StringBuilder();
        while (stack.Count() != 0)
        {
            sb.AppendLine($"{stack.Pop()}");
        }

        return sb.ToString().Trim();
    }
}
