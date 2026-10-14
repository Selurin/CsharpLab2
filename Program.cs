
internal class Program
{
    static void Main(string[] args)
    {
        string choice;
        do
        {
            PrintMenu();
            Console.Write("Введите номер задачи (например, 1.1 или 11) или 0 для выхода: ");
            choice = Console.ReadLine()?.Trim() ?? "";
            switch (choice)
            {
                case "0":
                    Console.WriteLine("До свидания!");
                    break;

                case "1.3":
                case "13":
                    Name name1 = new Name("", "Клеопатра", "");
                    Name name2 = new Name("Пушкин", "Александр", "Сергеевич");
                    Name name3 = new Name("Маяковский", "Владимир", "");

                    Console.WriteLine(name1);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    break;

                case "1.4":
                case "14":
                    if (TryReadInt("Введите количество секунд: ", out int seconds))
                    {
                        Time time = new Time(seconds);
                        Console.WriteLine("Текстовая форма: " + time.ToString());
                    }
                    break;
            }


        } while (choice != "0");
    }

    private static void PrintMenu()
    {
        Console.WriteLine("\n--- Меню задач ---");
        Console.WriteLine("1.3 - Имена");
        Console.WriteLine("1.4 - Время");
        Console.WriteLine("0 - Выход");
        Console.WriteLine("------------------");
    }

    private static bool TryReadInt(string prompt, out int value)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out value))
        {
            return true;
        }
        Console.WriteLine("Неверное значение! Ожидалось целое число.");
        return false;
    }
}
