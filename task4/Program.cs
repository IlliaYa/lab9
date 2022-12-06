using System;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        var row_numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

        var stones = new Lake(row_numbers.ToList());

        Console.WriteLine(string.Join(", ", stones));
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
