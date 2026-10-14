namespace CsharpLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name name1 = new Name();
            Name name2 = new Name("ff", "ss","df");
            Name name3 = new Name("ff", "", "df");
            Name name4 = new Name("          ff                             ", "", "df");

            Console.WriteLine(name2);
            Console.WriteLine(name3);
            Console.WriteLine(name4);
        }
    }
}
// в имени может быть фио (разделены пробелом) т.е. делать проверку 
// проверка если поле null то не доавбляемs
