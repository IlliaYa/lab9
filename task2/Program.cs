using System;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        var collection = new ListyIterator<string>();
        var choose = Console.ReadLine();
        int Count = 0;
        while (choose is not ("END") || Count <= 100)
        {
            var lineArgs = choose.Split();
            try
            {
                if (lineArgs[0] is ("Create"))
                {
                    collection.Create(lineArgs.Skip(1).ToList());
                }
                else if (lineArgs[0] is ("Move"))
                {
                    Console.WriteLine(collection.Move());
                }
                else if (lineArgs[0] is ("Print"))
                {
                    collection.Print();
                }
                else if (lineArgs[0] is ("HasNext"))
                {
                    Console.WriteLine(collection.HasNext());
                }
                else if (lineArgs[0] is ("PrintAll"))
                {
                    Console.WriteLine(collection.PrintAll());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            choose = Console.ReadLine();
            Count += 1;
        }


    }
}
