namespace CsharpLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name name1 = new Name();
            Name name2 = new Name("ff", "ss");

            Console.WriteLine(name2);
        }
    }
}
