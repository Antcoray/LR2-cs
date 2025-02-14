using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_C_
{
    internal class Menu
    {
        public static int MenuMethod(string Input, int index)
        {
            string[] menuItems = { "Продолжить", "Закончить" };
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Исходное число: {Input}");
                switch (index)
                {
                    case 0:
                        Console.WriteLine($"первая цифра больше. ({Input[0]} > {Input[2]})");
                        break;
                    case 1:
                        Console.WriteLine($"Последняя цифра больше. ({Input[2]} > {Input[0]})");
                        break;
                    case 2:
                        Console.WriteLine($"Цифры равны. ({Input[0]} = {Input[2]})");
                        break;
                }

                for (int i = 0; i < menuItems.Length; ++i)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {menuItems[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {menuItems[i]}");
                    }
                }

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                {
                    selectedIndex = (selectedIndex == 0) ? menuItems.Length - 1 : selectedIndex - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                {
                    selectedIndex = (selectedIndex == menuItems.Length - 1) ? 0 : selectedIndex + 1;
                }
                else if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    return selectedIndex;
                }
            }
        }
    }
}

