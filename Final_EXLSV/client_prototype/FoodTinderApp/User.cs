using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FoodTinderApp
{
    static class User
    {
        public static string IP { get; set; } = "192.168.43.110";
        public static Product finalEat;
        public static List<Product> list_p2 = new List<Product>();
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static bool Gender { get; set; } //0 - female, 1 - male
        public static int Age { get; set; }
        public static int Weight { get; set; }
        public static string dailyActivity { get; set; }
        public static int ChoicedMeal { get; set; } // 0 - завтрак,
                                                    // 1 - обед,
                                                    // 2 - ужин
    }
}
