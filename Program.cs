
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
                    Console.WriteLine("Выберите способ ввода времени:");
                    Console.WriteLine("1 - ввести количество секунд");
                    Console.WriteLine("2 - ввести часы, минуты, секунды через пробел");
                    string? choice14 = Console.ReadLine();

                    if (choice14 == "1")
                    {
                        if (TryReadInt("Введите количество секунд: ", out int seconds))
                        {
                            Time time = new Time(seconds);
                            Console.WriteLine("Текстовая форма: " + time.ToString());
                        }
                    }
                    else if (choice14 == "2")
                    {
                        Console.Write("Введите часы, минуты, секунды через пробел: ");
                        string? input = Console.ReadLine();
                        if (input != null)
                        {
                            string[] parts = input.Split(' ');

                            if (parts.Length != 3)
                            {
                                Console.WriteLine("Ошибка: нужно ввести ровно 3 числа через пробел");
                            }
                            else
                            {
                                bool isValid1 = int.TryParse(parts[0], out int hours);
                                bool isValid2 = int.TryParse(parts[1], out int minutes);
                                bool isValid3 = int.TryParse(parts[2], out int secs);

                                if (isValid1 && isValid2 && isValid3)
                                {
                                    Time time = new Time(hours, minutes, secs);
                                    Console.WriteLine("Текстовая форма: " + time.ToString());

                                    Console.WriteLine("Проверка для заданных значений:");

                                    Time t1 = new Time(10000);
                                    Console.WriteLine("10000 секунд = " + t1.ToString());

                                    Time t2 = new Time(2, 3, 5);
                                    Console.WriteLine("2 часа, 3 минуты, 5 секунд = " + t2.ToString());
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка: введены некорректные значения");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор");
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
