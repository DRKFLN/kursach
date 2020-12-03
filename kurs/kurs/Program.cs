using System;
using System.Diagnostics;

namespace Курсач1
{
    class Task1
    {
        double procent;
        double dolg;
        double platezh;
        double mounth;
        int variable;
        public void text()
        {
            Console.WriteLine("1 января 2015 года Павел Витальевич взял в банке 1 млн. рублей в кредит.");
            Console.WriteLine("Схема выплаты кредита следующая: 1 числа каждого следующего месяца банк начисляет");
            Console.WriteLine("1% на оставшуюся сумму долга (то есть увеличивает долг на 1%), затем Павел");
            Console.WriteLine("Витальевич переводит в банк платеж. На какое минимальное количество месяцев");
            Console.WriteLine("Павел Витальевич может взять кредит, чтобы ежемесячные выплаты были не");
            Console.WriteLine("более 125 тыс. рублей?");
            while (true)
            {
                Console.WriteLine("\nОставить данные исходными или ввести свои?\n1.Оставить исходные данные\n2.Изменить исходные данные");
                variable = Convert.ToInt32(Console.ReadLine());
<<<<<<< HEAD
                if (variable == 1)
=======
                 if (variable == 1)
>>>>>>> master
                {
                    procent = 1;
                    dolg = 1000000;
                    platezh = 125000;
                    mounth = 0;
                    break;
                }
                else if (variable == 2)
                {
                    Console.Write("\nВведите сумму долга: ");
                    dolg = double.Parse(Console.ReadLine());
                    Console.Write("Введите сумму платежа: ");
                    platezh = double.Parse(Console.ReadLine());
                    Console.Write("Укажите процент: ");
                    procent = double.Parse(Console.ReadLine());
                    break;
                }
            }

        }
        public void getresult()
        {
            do
            {
                dolg *= (1 + procent / 100);
                if (dolg < platezh || dolg == platezh)
                {
                    platezh = dolg;
                }
                dolg -= platezh;
                mounth += 1;
                Console.WriteLine("В " + mounth + "-м месяце долг будет равен " + dolg + " процент = " + procent);
            }
            while (dolg > 0);
            Console.WriteLine("Ответ: При данных условиях Павел Витальевич может взять кредит на " + --mounth + " месяцев");
        }
    }
    class Task2
    {
        //кредит
        double s = 1000000;
<<<<<<< HEAD
        double x1 = 510000;
        double x2 = 649000;
        double p = 0;
        //double b = 1 + b/100;
=======
        double b;
        double x1 = 510000;
        double x2 = 649000;

>>>>>>> master

        public void text()
        {
            Console.WriteLine("31 декабря 2014 года Антон взял в банке 1 млн. рублей в кредит. Схема");
            Console.WriteLine("выплаты кредита следующая: 31 декабря каждого следующего года банк");
            Console.WriteLine("начисляет проценты на оставшуюся сумму долга (то есть увеличивает долг");
            Console.WriteLine("на определенное колличество процентов), затем Антон переводит ");
            Console.WriteLine("очередной транш. Антон выплатил кредит за два транша, переводя в первый");
            Console.WriteLine("раз 510 тыс. рублей, во второй - 649 тыс. рублей. Под какой процент банк");
            Console.WriteLine("выдал кредит Антону?");
            Console.WriteLine("Введите общий долг");
            s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х2");
            x2 = Convert.ToDouble(Console.ReadLine());
        }
        public void getresult()
        {
            double d = (x1 * x1) + 4 * x2 * s;
            if (d < 0)
            {
                Console.WriteLine("решений нет");
            }
            else
            {
                p = (x1 + Math.Sqrt(d)) / (2 * s);
                Console.WriteLine("Ответ: " + (p-1)*100);
                Console.WriteLine("d: " + d);
            }
            
        }
    }
    class Task3
    {
        double r = 3;
        double b = 1.03;
        int n = 9;
        double S;
        public void text()
        {
            Console.WriteLine("15 января планируется взять кредит в банке на 9 месяцев. Условия его возврата таковы:\n");
            Console.WriteLine("- 1-го числа каждого месяца долг возврастает на 3% по сравнению с концом");
            Console.WriteLine("предыдущего месяца;");
            Console.WriteLine("- со 2-го по 14-е число каждого месяца необходимо выплатить часть долга;\n");
            Console.WriteLine("- со 2-го по 14-е число каждого месяца необходимо выплатить часть долга;\n");
            Console.WriteLine("- 15-го числа каждого месяца долг должен быть на одну и ту же величину меньше");
            Console.WriteLine("долга на 15-е число предыдущего месяца.\n");
            Console.WriteLine("Известно, что на пятый месяц кредитования нужно выплатить 57,5 тыс. рублей.");
            Console.WriteLine("какую сумму нужно вернуть банку в течении всего срока кредитования?");
        }
        public void getresult()
        {
             
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task1 t1 = new Task1();
            Task2 t2 = new Task2();
            Task3 t3 = new Task3();
            while (true)
            {
                int cont = 1;
                if (cont == 1)
                {
                    Console.Write("Выберите номер задачи(1-3): ");
                    int variable = Convert.ToInt32(Console.ReadLine());
                    switch (variable)
                    {
                        case 1:
                            t1.text();
                            t1.getresult();
                            break;
                        case 2:
                            t2.text();
                            t2.getresult();
                            break;
                        case 3:
                            t3.text();
                            t3.getresult();
                            break;

                    }
                    Console.WriteLine("Продолжить?\n1.Да 2.Нет");
                    cont = Convert.ToInt32(Console.ReadLine());
                    if (cont == 2)
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Очистить консоль?\n1.Да 2.Нет");
                    cont = Convert.ToInt32(Console.ReadLine());
                    if (cont == 1)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
