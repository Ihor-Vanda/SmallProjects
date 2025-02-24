// See https://aka.ms/new-console-template for more information
using System.Text;
using FibonacciSequence;

Console.WriteLine(string.Join(", ", FibonacciNumbers.GetNumbers(0)));
Console.WriteLine(string.Join(", ", FibonacciNumbers.GetNumbers(1)));

try
{
    Console.WriteLine(FibonacciNumbers.GetNumbers(-1));
}
catch
{

}
Console.WriteLine(string.Join(", ", FibonacciNumbers.GetNumbers(5)));
Console.WriteLine(string.Join(", ", FibonacciNumbers.GetNumbers(19)));

