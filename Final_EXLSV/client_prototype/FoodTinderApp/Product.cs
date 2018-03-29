using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FoodTinderApp
{
    class Product
    {
        public string Name { get; set; }
        public int Number { get; set; } 
        public int typeOfProduct { get; set; }
    }
}
