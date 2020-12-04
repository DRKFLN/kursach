﻿using System;
using System.Diagnostics;

namespace Курсач1
{
    class Task1
    {
        double percent;//процент
        double debt;//долг
        double payment;//платеж
        double mounth;//счетчик месяца
        int variable;//переменная для определения выбора
        public void Text()
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
                 if (variable == 1)

                {
                    percent = 1;
                    debt = 1000000;
                    payment = 125000;
                    mounth = 0;
                    break;
                }
                else if (variable == 2)
                {
                    Console.Write("\nВведите сумму долга: ");
                    debt = double.Parse(Console.ReadLine());
                    Console.Write("Введите сумму платежа: ");
                    payment = double.Parse(Console.ReadLine());
                    Console.Write("Укажите процент: ");
                    percent = double.Parse(Console.ReadLine());
                    break;
                }
            }

        }
        public void Getresult()
        {
            do
            {
                debt *= (1 + percent / 100);
                if (debt < payment || debt == payment)
                {
                    payment = debt;
                }
                debt -= payment;
                mounth += 1;
                Console.WriteLine("В " + mounth + "-м месяце долг будет равен " + debt + " процент = " + percent);
            }
            while (debt > 0);
            Console.WriteLine("Ответ: При данных условиях Павел Витальевич может взять кредит на " + --mounth + " месяцев");
        }
    }
    class Task2
    {
        double credit; //кредит
        double x1; //первая выплата
        double x2; //вторая выплата
        double percent; //процент с положительным знаком
        double percentWithMinus;//процент с отрицательным знаком
        double d;//дискриминант
        int variable;//переменная выбора(нужна для работы интерфейса)
        public void Text()
        {
            Console.WriteLine("31 декабря 2014 года Антон взял в банке 1 млн. рублей в кредит. Схема");
            Console.WriteLine("выплаты кредита следующая: 31 декабря каждого следующего года банк");
            Console.WriteLine("начисляет проценты на оставшуюся сумму долга (то есть увеличивает долг");
            Console.WriteLine("на определенное колличество процентов), затем Антон переводит ");
            Console.WriteLine("очередной транш. Антон выплатил кредит за два транша, переводя в первый");
            Console.WriteLine("раз 510 тыс. рублей, во второй - 649 тыс. рублей. Под какой процент банк");
            Console.WriteLine("выдал кредит Антону?");
            while (true)
            {
                Console.WriteLine("\nОставить данные исходными или ввести свои?\n1.Оставить исходные данные\n2.Изменить исходные данные");
                variable = Convert.ToInt32(Console.ReadLine());
                if (variable == 1)
                {
                    credit = 1000000;
                    x1 = 510000;
                    x2 = 649000;
                    break;
                }
                else if (variable == 2)
                {
                    Console.WriteLine("Введите общий долг");
                    credit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите х1");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите х2");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
            }
        }
        public void Getresult()
        {
            d = (x1 * x1) + 4 * x2 * credit;
            if (d < 0)
            {
                Console.WriteLine("решений нет");
            }
            else
            {
                percent = (x1 + Math.Sqrt(d)) / (2 * credit);
                percentWithMinus = (x1 - Math.Sqrt(d)) / (2 * credit);
                if (percent > 0)
                {
                    percent = (percent - 1) * 100;
                    Console.WriteLine("Ответ: " + Math.Round(percent));
                }
                else if (percentWithMinus > 0)
                {
                    percentWithMinus = (percentWithMinus - 1) * 100;
                    Console.WriteLine("Ответ: " + Math.Round(percentWithMinus));
                }
            }  
        }
    }
    class Task3
    {
        double p; //percent
        double k; //выплата за месяц
        double n = 9; //mounth
        double B;
        double S; //сумма за 5 месяцев
        int variable;
        public void Text()
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
            while (true)
            {
                Console.WriteLine("\nОставить данные исходными или ввести свои?\n1.Оставить исходные данные\n2.Изменить исходные данные");
                variable = Convert.ToInt32(Console.ReadLine());
                if (variable == 1)
                {
                    p = 3;
                    n = 9;
                    k = 5;
                    B = 57.5;
                    break;
                }
                else if (variable == 2)
                {
                    Console.WriteLine("Введите процент");
                    p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите колличество месяцев");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите месяц с известной выплатой");
                    k = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите выплату на " + n + " месяц");
                    B = Convert.ToDouble(Console.ReadLine());
                    break;
                }
            }
        }
        public void Getresult()
        {
            p = 1 + p / 100;
            S = (B * n) / ((k*p)-(k-1));
            Console.WriteLine("Сумма выплат за 5 месяцев убдет равна: " + Math.Round(S));
            for (int i = Convert.ToInt32(k + 1); i <= n; i++)
            {
                S = S + (n - 1) * (S * p / n) - (n - 2) * S / n;
            }
            Console.WriteLine("Сумма станет равна: " + Math.Round(S));
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
                            t1.Text();
                            t1.Getresult();
                            break;
                        case 2:
                            t2.Text();
                            t2.Getresult();
                            break;
                        case 3:
                            t3.Text();
                            t3.Getresult();
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
