using System;

namespace Lab_work
{
    internal class Program
    {
        static string Repl(string str)
        {
            str = str.Replace("y", "Y");
            str = str.Replace("n", "N");
            return str;
        }
        static bool Year_check(int year)
        {
            bool result;
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                if (year % 4 == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Так как задания почти идентичны, то для удобства они были объеденены в одно.\n");
            Console.WriteLine("Задание 1 / (1,2,3).\nПограмма принимает число(1, 365) и переводит в месяц и день месяца. Обработать возможные ошибки и високосный год.\n");
            Console.Write("Желаете ли вы проверить задание 1 (Yes, No): ");
            string answer = Console.ReadLine();
            answer = Repl(answer);
            bool flag = true;
            int[] days = { 28, 30, 31 };
            while (flag)
            { 
                switch (answer)
                {
                    case "Yes":
                        Console.Write("\nВведите год(н.э.): ");
                        bool check1 = int.TryParse(Console.ReadLine(), out int year);
                        if (!check1 | year <= 0)
                        {
                            Console.Write("\nВы не правильно ввели данные, хотите попробовать ещё раз: ");
                            answer = Console.ReadLine();
                            answer = Repl(answer);
                            continue;
                        }
                        bool leap_year = Year_check(year);
                        Console.Write("Введите номер дня в году (Натуральное число от 1 до 365/366, если високосный год): ");
                        bool check2 = int.TryParse(Console.ReadLine(), out int day);
                        if (!check2 | day <= 0)
                        {
                            Console.Write("\nВы не правильно ввели данные, хотите попробовать ещё раз: ");
                            answer = Console.ReadLine();
                            answer = Repl(answer);
                            continue;
                        }
                        else
                        {
                            if (day > 366 | day < 1)
                            {
                                Console.Write("\nВы не правильно ввели данные, хотите попробовать ещё раз:  ");
                                answer = Console.ReadLine();
                                answer = Repl(answer);
                                continue;
                            }
                            else if (day == 366 & leap_year == false)
                            {
                                Console.Write("\nДанный год не является високосным, данные не корректны, хотите попробовать ещё раз: ");
                                answer = Console.ReadLine();
                                answer = Repl(answer);
                                continue;
                            }
                        }
                        int? result_month = null;
                        int? result_day = null;
                        if (!leap_year)
                        {
                            if (1 <= day & day <= 31)
                            {
                                result_month = 1;
                                result_day = day;
                            }
                            else if (32 <= day & day <= 59)
                            {
                                result_month = 2;
                                result_day = day - days[2];
                            }
                            else if (60 <= day & day <= 90)
                            {
                                result_month = 3;
                                result_day = day - days[0] - days[2];
                            }
                            else if (91 <= day & day <= 120)
                            {
                                result_month = 4;
                                result_day = day - days[0] - days[2] - days[1];
                            }
                            else if (121 <= day & day <= 151)
                            {
                                result_month = 5;
                                result_day = day - days[0] - 2 * days[2] - days[1];
                            }
                            else if (152 <= day & day <= 181)
                            {
                                result_month = 6;
                                result_day = day - days[0] - 2 * days[2] - 2 * days[1];
                            }
                            else if (182 <= day & day <= 212)
                            {
                                result_month = 7;
                                result_day = day - days[0] - 3 * days[2] - 2 * days[1];
                            }
                            else if (213 <= day & day <= 243)
                            {
                                result_month = 8;
                                result_day = day - days[0] - 4 * days[2] - 2 * days[1];
                            }
                            else if (244 <= day & day <= 273)
                            {
                                result_month = 9;
                                result_day = day - days[0] - 4 * days[2] - 3 * days[1];
                            }
                            else if (274 <= day & day <= 304)
                            {
                                result_month = 10;
                                result_day = day - days[0] - 5 * days[2] - 3 * days[1];
                            }
                            else if (305 <= day & day <= 334)
                            {
                                result_month = 11;
                                result_day = day - days[0] - 5 * days[2] - 4 * days[1];
                            }
                            else if (335 <= day & day <= 365)
                            {
                                result_month = 12;
                                result_day = day - days[0] - 6 * days[2] - 4 * days[1];
                            }

                        }
                        else
                        {
                            if (1 <= day & day <= 31)
                            {
                                result_month = 1;
                                result_day = day;
                            }
                            else if (32 <= day & day <= 60)
                            {
                                result_month = 2;
                                result_day = day - days[2];
                            }
                            else if (61 <= day & day <= 91)
                            {
                                result_month = 3;
                                result_day = day - days[0] - days[2] - 1;
                            }
                            else if (92 <= day & day <= 121)
                            {
                                result_month = 4;
                                result_day = day - days[0] - days[2] - days[1] - 1;
                            }
                            else if (122 <= day & day <= 152)
                            {
                                result_month = 5;
                                result_day = day - days[0] - 2 * days[2] - days[1] - 1;
                            }
                            else if (153 <= day & day <= 182)
                            {
                                result_month = 6;
                                result_day = day - days[0] - 2 * days[2] - 2 * days[1] - 1;
                            }
                            else if (183 <= day & day <= 213)
                            {
                                result_month = 7;
                                result_day = day - days[0] - 3 * days[2] - 2 * days[1] - 1;
                            }
                            else if (214 <= day & day <= 244)
                            {
                                result_month = 8;
                                result_day = day - days[0] - 4 * days[2] - 2 * days[1] - 1;
                            }
                            else if (245 <= day & day <= 274)
                            {
                                result_month = 9;
                                result_day = day - days[0] - 4 * days[2] - 3 * days[1] - 1;
                            }
                            else if (275 <= day & day <= 305)
                            {
                                result_month = 10;
                                result_day = day - days[0] - 5 * days[2] - 3 * days[1] - 1;
                            }
                            else if (306 <= day & day <= 335)
                            {
                                result_month = 11;
                                result_day = day - days[0] - 5 * days[2] - 4 * days[1] - 1;
                            }
                            else if (336 <= day & day <= 366)
                            {
                                result_month = 12;
                                result_day = day - days[0] - 6 * days[2] - 4 * days[1] - 1;
                            }
                        }

                        Console.WriteLine($"Year: {year};\nMonth: {(Months)result_month};\nDay: {result_day}.");
                        Console.Write("\nЖелаете ли вы ещё раз проверить задание 1 (Yes, No): ");
                        answer = Console.ReadLine();
                        answer = Repl(answer);
                        break;
                    case "No":
                        flag = false;
                        break;
                    default:
                        Console.Write("Введите Yes/No: ");
                        answer = Console.ReadLine();
                        answer = Repl(answer);
                        break;
                }
            }
        }
    }
}
