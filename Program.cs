
internal class Program
{
    static void Main(string[] args)
    {
        string choice;
        do
        {
            PrintMenu();
            Console.Write("Введите номер или имя класса задачи (например, Name или n или 1) или 0 для выхода: ");
            choice = Console.ReadLine()?.Trim() ?? "";
            switch (choice)
            {
                case "0":
                    Console.WriteLine("До свидания!");
                    break;

                case "Name":
                case "n":
                case "Имена":
                case "1":
                    Name name1 = new Name("", "Клеопатра", "");
                    Name name2 = new Name("Пушкин", "Александр", "Сергеевич");
                    Name name3 = new Name("Маяковский", "Владимир", "");

                    Console.WriteLine(name1);
                    Console.WriteLine(name2);
                    Console.WriteLine(name3);
                    break;

                case "Time":
                case "t":
                case "Время":
                case "2":
                    Console.WriteLine("Выберите способ ввода времени:");
                    Console.WriteLine("1 - ввести количество секунд");
                    Console.WriteLine("2 - ввести часы, минуты, секунды через пробел");
                    Console.WriteLine("3 - ввести количество секунд для возврата текущего времени");
                    string? subchoice = Console.ReadLine();

                    if (subchoice == "1")
                    {
                        if (TryReadInt("Введите количество секунд: ", out int seconds))
                        {
                            Time time = new Time(seconds);
                            Console.WriteLine("Текстовая форма: " + time.ToString());

                            Console.WriteLine("\nПроверка для заданных значений:");
                            Time t1 = new Time(10);
                            Console.WriteLine("10 секунд = " + t1);
                            Time t2 = new Time(10000);
                            Console.WriteLine("10000 секунд = " + t2);
                            Time t3 = new Time(100000);
                            Console.WriteLine("100000 секунд = " + t3);

                        }
                    }
                    else if (subchoice == "2")
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

                                    Console.WriteLine("\nПроверка для заданных значений:");

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

                    else if (subchoice == "3")
                    {
                        if (TryReadInt("Введите количество секунд: ", out int seconds3))
                        {
                            Time time = new Time(seconds3);
                            Console.WriteLine($"Какой сейчас час (целое число): {time.GetHours()}");
                            Console.WriteLine($"Сколько минут прошло с начала текущего часа (целое число): {time.GetMinutes()}");
                            Console.WriteLine($"Сколько секунд прошло с начала текущей минуты (целое число): {time.GetSeconds()}");

                            Console.WriteLine("\nПроверка для заданных значений:");

                            Time t1 = new Time(34056);
                            Console.WriteLine("Для времени 34056 секунд часов: " + t1.GetHours());

                            Time t2 = new Time(4532);
                            Console.WriteLine("Для времени 4532 секунд минут: " + t2.GetMinutes());

                            Time t3 = new Time(123);
                            Console.WriteLine("Для времени 123 секунд секунд: " + t3.GetSeconds());
                        }
                    }

                    else
                    {
                        Console.WriteLine("Неверный выбор");
                    }
                    break;

                case "Сотрудники":
                case "EmployeeDepartment":
                case "ed":
                case "3":
                    Department it = new Department("IT");
                    Employee petrov = new Employee("Петров", it);
                    Employee kozlov = new Employee("Козлов", it);
                    Employee sidorov = new Employee("Сидоров", it);
                    it.Manager = kozlov;
                    Console.WriteLine(petrov);
                    Console.WriteLine(kozlov);
                    Console.WriteLine(sidorov);
                    break;


            }


        } while (choice != "0");
    }

    private static void PrintMenu()
    {
        Console.WriteLine("\n--- Меню задач ---");
        Console.WriteLine("1 - Имена/Name/n");
        Console.WriteLine("2 - Время/Time/t");
        Console.WriteLine("3 - Сотрудники/EmployeeDepartment/ed");
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
