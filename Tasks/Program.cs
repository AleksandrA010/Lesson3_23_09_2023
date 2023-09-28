using System;

namespace Tasks
{
    enum Days_Week
    {
        Понедельник = 1,
        Вторник = 2,
        Среда = 3,
        Четверг = 4,
        Пятница = 5,
        Суббота = 6,
        Воскресенье = 7,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доступные для проверки задания (1,2,3,4,5), для проверки введите его номер.\n");
            Console.WriteLine("Для выхода из программы введите break.\n");
            Console.WriteLine("Задание 1.\n");
            bool flag = true;
            while (flag)
            {
                Console.Write("\nВведите номер задания для проверки: ");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        Console.Write("\nВведите последовательность из 10 чисел (Последовательность должна быть целой, не отрицательной): ");
                        bool check = int.TryParse(Console.ReadLine(), out int sequence);
                        if (!check | (sequence >= 10000000000) | (sequence < 1000000000))
                        {
                            Console.WriteLine("Вы не верно ввели данные.");
                            continue;
                        }
                        int number1, number2;
                        int? last_el = null;
                        int? last_el_index = null;
                        bool flag_sequence = true;
                        for (int i = 1; i < 10; i++)
                        {
                            sequence /= 10;
                            number1 = sequence % 10;
                            number2 = sequence % 100 / 10;
                            if (number1 < number2)
                            {
                                last_el_index = 10 - i;
                                last_el = number1;
                                flag_sequence = false;
                            }

                        }
                        if (flag_sequence)
                        {
                            Console.WriteLine("Последовательность — возрастающая.");
                        }
                        else
                        {
                            Console.WriteLine($"Последовательность — не возрастающая, счёт остановился на {last_el} — это {last_el_index} элемент в последовательности.");
                        }
                            break;
                    case "2":
                        Console.Write("\nВведите порядковый номер карты (число от 6 до 14): ");
                        int number_card;
                        try
                        {
                            number_card = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Вы не верно ввели данные.");
                            continue;
                        }
                        switch (number_card)
                        {
                            case 6:
                                Console.WriteLine("Это шестёрка.");
                                break;
                            case 7:
                                Console.WriteLine("Это семёрка.");
                                break;
                            case 8:
                                Console.WriteLine("Это восьмёрка.");
                                break;
                            case 9:
                                Console.WriteLine("Это девятка.");
                                break;
                            case 10:
                                Console.WriteLine("Это десятка.");
                                break;
                            case 11:
                                Console.WriteLine("Это валет.");
                                break;
                            case 12:
                                Console.WriteLine("Это дама.");
                                break;
                            case 13:
                                Console.WriteLine("Это король.");
                                break;
                            case 14:
                                Console.WriteLine("Это туз.");
                                break;
                            default:
                                Console.WriteLine("Вы не верно ввели данные.");
                                break;
                        }
                        break;
                    case "3":
                        Console.Write("Введите что-либо из предложенного — Jabroni, School Counselor, Programmer,\nBike Gang Member, Politician, Rapper: ");
                        string str = Console.ReadLine();
                        str = str.ToLower();
                        switch (str)
                        {
                            case "jabroni":
                                Console.WriteLine("Patron Tequilla");
                                break;
                            case "school counselor":
                                Console.WriteLine("Anything with Alcohol");
                                break;
                            case "programmer":
                                Console.WriteLine("Hipster Craft Beer");
                                break;
                            case "bike gang member":
                                Console.WriteLine("Moonshine");
                                break;
                            case "politician":
                                Console.WriteLine("Your tax dollars");
                                break;
                            case "rapper":
                                Console.WriteLine("Cristal");
                                break;
                            default:
                                Console.WriteLine("Beer");
                                break;
                        }
                        break;
                    case "4":
                        Console.Write("\nВведите порядковый номер дня недели (от 1 до 7): ");
                        bool check3 = int.TryParse(Console.ReadLine(), out int day_w);
                        if (!check3 | day_w > 7 | day_w < 1)
                        {
                            Console.WriteLine("Вы не верно ввели данные.");
                            continue;
                        }
                        Console.WriteLine($"Это {(Days_Week)day_w}.");
                        break;
                    case "5":
                        break;
                    case "break":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nВы не верно ввели номер задания.\nДля проверки доступны(1,2,3,4,5); Для выхода из программы введите break.");
                        break;
                }
            }
        }
    }
}
