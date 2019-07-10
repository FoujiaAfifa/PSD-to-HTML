using KeyboardConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Assembly of Laptop..............");
            Laptop laptop = new Laptop();
            laptop.Brand = "Dell";
            laptop.Color = "Red";
            laptop.Price = 60000;

            Keyboard a4Techkeyboard = new Keyboard();
            a4Techkeyboard.BrandName = "a4Tech";

            a4Techkeyboard.KeyList = new List<string>() { "A", "B", "2", "4", "K", "7" };

            laptop.Keyboard = a4Techkeyboard;

            Display display = new Display();
            display.Resolution = "4K";
            display.ScreenSize = 18.5;

            laptop.Screen = display;

            Console.WriteLine("Assembled Laptop Information:");
            Console.WriteLine("\t Brand,Color,Price:" + " " + laptop.Brand + " " + laptop.Color + " " + laptop.Price);

            Console.WriteLine("Display:");

            Console.WriteLine("\t Resolution:" + " " + laptop.Screen.Resolution);
            Console.WriteLine("\t Screen Size:" + " " + laptop.Screen.ScreenSize);


            Console.WriteLine("Keyboard Brand:" + " " + laptop.Keyboard.BrandName);

            string comaKeyList = string.Join(",", laptop.Keyboard.KeyList);
            Console.WriteLine("\t Key format:" +  comaKeyList);

           

            Console.ReadLine();
        }
    }
}
