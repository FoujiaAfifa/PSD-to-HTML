using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardConsoleApp.Models
{
    public class Laptop
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public Keyboard Keyboard  { get; set; }
        public Display Screen { get; set; }
 

    }

    public class Keyboard
    {
        public List<string> KeyList { get; set; }
        public string BrandName { get; internal set; }
    }

    public class Display
    {
        public string Resolution { get; set; }
        public double ScreenSize { get; set; }
    }
}
