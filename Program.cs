using Microsoft.VisualBasic;
using System.Text;

namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\saivignesh\Desktop\Rainbowschools.txt");
            System.Console.WriteLine("Contents of Rainbowschools.txt = \n{0}", text);
            Console.ReadLine();
        }
    }
}