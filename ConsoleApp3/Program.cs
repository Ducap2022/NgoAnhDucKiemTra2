using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Final
{
    internal class Program
    {
        private static int x = 0;
        private static int y = 0;
        private static ArrayList m1 = new ArrayList();

        static void Main(string[] args)
        {
            Reprint();

            MenuOrginal();

            var readKeys = new Task(ReadKeys);
            readKeys.Start();

            var tasks = new[] { readKeys };

            Task.WaitAll(tasks);

            Console.CancelKeyPress += (sender, e) =>
            {
                Environment.Exit(0);
            };

        }
        private static int Y = 3;
        private static void MenuOrginal()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("+---------+---------+");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("1.Nhap lai day so");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("2.Sap xep tang dan");
            Console.WriteLine("3.Sap xep giam dan");
            Console.WriteLine("4.In ket qua");
            Console.WriteLine("5.Demo sx tang dan");
            Console.WriteLine("6.Thoat");
            Console.WriteLine("+---------+---------+");
        }
        private static void Menu()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Menu:");
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("1.Nhap lai day so");
            Console.WriteLine("2.Sap xep tang dan");
            Console.WriteLine("3.Sap xep giam dan");
            Console.WriteLine("4.In ket qua");
            Console.WriteLine("5.Demo sx tang dan");
            Console.WriteLine("6.Thoat");
            Console.WriteLine("+---------+---------+");
        }

        private static void ReadKeys()
        {
            int Order;
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (!Console.KeyAvailable && key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Y != 2)
                        {
                            switch (Y)
                            {
                                case 3:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("1.Nhap lai day so");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 4:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("2.Sap xep tang dan");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 5:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("3.Sap xep giam dan");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 6:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("5.In ket qua");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 7:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("4.Demo sx tang dan");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 8:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("6.thoat");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                            }
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (Y != 7)
                        {
                            switch (Y)
                            {
                                case 2:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("1.Nhap lai day so");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 3:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("2.Sap xep tang dan");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 4:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("3.Sap xep giam dan");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 5:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("5.In ket qua");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 6:
                                    Menu();
                                    Y++;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("4.Demo sx tang dan");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 7:
                                    Menu();
                                    Y--;
                                    Console.SetCursorPosition(x, Y);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("6.Thoat");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                            }
                        }
                        break;

                    case ConsoleKey.Enter:
                        switch (Y)
                        {
                            case 2:
                                Reprint();
                                break;
                            case 3:
                                Order = 0;
                                Sort(Order);
                                tempClear();
                                break;
                            case 4:
                                Order = 1;
                                Sort(Order);
                                tempClear();
                                break;
                            case 5:
                                Print();
                                Console.ReadLine();
                                Cleanup();
                                Console.SetCursorPosition(x, Y);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("> 4.In ket qua");
                                Console.BackgroundColor = ConsoleColor.White;

                                break;
                            case 6:
                                Demo();
                                Console.ReadLine();
                                Console.Clear();
                                MenuOrginal();
                                Y = 3;
                                break;
                            case 7:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                }
            }
        }
        private static void Cleanup()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int plus = 0;

            for (int i = 0; i < m1.Count; i++)
            {
                Console.SetCursorPosition(x + 20 + plus, Y - 3);
                Console.WriteLine("+----+");
                Console.SetCursorPosition(x + 20 + plus, Y - 2);
                Console.WriteLine("| " + m1[i] + "  |");
                Console.SetCursorPosition(x + 20 + plus, Y - 1);
                Console.WriteLine("+----+");
                plus += 6;
            }
            plus = 0;

            for (int i = 0; i < m1.Count; i++)
            {
                Console.SetCursorPosition(x + 20 + plus, Y);
                Console.WriteLine("+----+");
                Console.SetCursorPosition(x + 20 + plus, Y + 1);
                Console.WriteLine("| " + sorted[i] + "  |");
                Console.SetCursorPosition(x + 20 + plus, Y + 2);
                Console.WriteLine("+----+");
                plus += 6;
            }
        }
        private static void tempClear()
        {
            Console.SetCursorPosition(x + 25, Y);
            Console.Write("SORT COMPLETED! hit enter to delete");
            Console.ReadLine();
            Console.SetCursorPosition(x + 25, Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("SORT COMPLETED! hit enter to delete");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        private static void Reprint()
        {
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int n = 7;
            m1.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao so {0} cua day so cua ban: ", i);
                int t = int.Parse(Console.ReadLine());
                m1.Add(t);
            }

            for (int i = 3; i >= 0; i--)
            {
                Console.SetCursorPosition(x, y + (n));
                Console.WriteLine("Screen will clear in {0}", i);
                Thread.Sleep(1000);
            }
            Console.CursorVisible = false;

            MenuOrginal();
        }

        private static int[] sorted = new int[12];
        private static void Sort(int Order)
        {
            Array.Clear(sorted, 0, sorted.Length);

            for (int i = 0; i < m1.Count; i++)
            {
                sorted[i] = Convert.ToInt32(m1[i]);
            }
            if (Order == 0)
            {
                for (int i = 0; i < m1.Count; i++)
                {
                    for (int j = i; j < m1.Count; j++)
                    {
                        if (sorted[i] > sorted[j])
                        {
                            int tmp = sorted[i];

                            sorted[i] = sorted[j];

                            sorted[j] = tmp;
                        }
                    }
                }
            }
            else if (Order == 1)
            {
                for (int i = 0; i < m1.Count; i++)
                {
                    for (int j = i; j < m1.Count; j++)
                    {
                        if (sorted[i] < sorted[j])
                        {
                            int tmp = sorted[i];

                            sorted[i] = sorted[j];

                            sorted[j] = tmp;
                        }
                    }
                }
            }
        }

        private static void Demo()
        {
            for (int i = 0; i < m1.Count; i++)
            {
                sorted[i] = Convert.ToInt32(m1[i]);
            }
            int plus = 0;
            for (int i = 0; i < m1.Count; i++)
            {
                Console.SetCursorPosition(x + 20 + plus, Y - 3);
                Console.WriteLine("+----+");
                Console.SetCursorPosition(x + 20 + plus, Y - 2);
                Console.WriteLine("| " + m1[i] + "  |");
                Console.SetCursorPosition(x + 20 + plus, Y - 1);
                Console.WriteLine("+----+");
                plus += 6;
            }
            plus = 0;

            for (int i = 0; i < m1.Count; i++)
            {
                Console.SetCursorPosition(x + 20 + plus, Y);
                Console.WriteLine("+----+");
                Console.SetCursorPosition(x + 20 + plus, Y + 1);
                Console.WriteLine("| " + sorted[i] + "  |");
                Console.SetCursorPosition(x + 20 + plus, Y + 2);
                Console.WriteLine("+----+");
                plus += 6;
            }
            Console.SetCursorPosition(x + 35, y + 3);
            Console.Write("Sorting");
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(x + 42 + i, y + 3);
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.SetCursorPosition(x + 35, y + 3);
            Console.Write("Sorting Done!");

            for (int i = 0; i < m1.Count; i++)
            {
                for (int j = i; j < m1.Count; j++)
                {
                    if (sorted[i] > sorted[j])
                    {
                        int tmp = sorted[i];

                        sorted[i] = sorted[j];

                        sorted[j] = tmp;
                    }
                    plus = 0;
                    for (int k = 0; k < m1.Count; k++)
                    {
                        Console.SetCursorPosition(x + 20 + plus, Y);
                        Console.WriteLine("+----+");
                        Console.SetCursorPosition(x + 20 + plus, Y + 1);
                        Console.WriteLine("| " + sorted[k] + "  |");
                        Console.SetCursorPosition(x + 20 + plus, Y + 2);
                        Console.WriteLine("+----+");
                        plus += 6;
                    }
                }
                Thread.Sleep(1700);
            }

        }
        private static void Print()
        {
            int plus = 0;

            for (int i = 0; i < m1.Count; i++)
            {
                Console.SetCursorPosition(x + 20 + plus, Y - 3);
                Console.WriteLine("+----+");
                Console.SetCursorPosition(x + 20 + plus, Y - 2);
                Console.WriteLine("| " + m1[i] + "  |");
                Console.SetCursorPosition(x + 20 + plus, Y - 1);
                Console.WriteLine("+----+");
                plus += 6;
            }
            plus = 0;

            for (int i = 0; i < m1.Count; i++)
            {
                Console.SetCursorPosition(x + 20 + plus, Y);
                Console.WriteLine("+----+");
                Console.SetCursorPosition(x + 20 + plus, Y + 1);
                Console.WriteLine("| " + sorted[i] + "  |");
                Console.SetCursorPosition(x + 20 + plus, Y + 2);
                Console.WriteLine("+----+");
                plus += 6;
            }
        }
    }
}