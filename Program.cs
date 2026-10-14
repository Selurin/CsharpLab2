namespace CsharpLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name name1 = new Name("","Клеопатра","");
            Name name2 = new Name("Пушкин", "Александр","Сергеевич");
            Name name3 = new Name("Маяковский", "Владимир", "");

            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(name3);

        }
    }
}

