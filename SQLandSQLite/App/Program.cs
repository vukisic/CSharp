using SQL_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static List<DataModel> list = new List<DataModel>();
        static void Main(string[] args)
        {

            SQLite_Test();

        }

        public static void SQL_Test()
        {
            list = SQL_Helper.LoadData();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Code}");
            }

            #region Add Item
            //Console.WriteLine("\nAfter Insert:\n");
            //DataModel randomItem = new DataModel {Code=125,Name="HDD"};

            //SQL_Helper.SaveData(randomItem);

            //list.Clear();
            //list = SQL_Helper.LoadData();

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.Name} {item.Code}");
            //}
            #endregion

            #region Remove Item
            //try
            //{
            //    SQL_Helper.DeleteData("CPU");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //list.Clear();
            //list = SQL_Helper.LoadData();

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.Name} {item.Code}");
            //}
            #endregion

        }

        public static void SQLite_Test()
        {
            //SQLite_Helper.DeleteData("HDD");
            list = SQLite_Helper.LoadData();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Code}");
            }

            #region Insert
            DataModel someItem = new DataModel { Code = 127, Name = "HDD" };

            SQLite_Helper.SaveData(someItem);
            list.Clear();
            list = SQLite_Helper.LoadData();

            Console.WriteLine("\nAfter Insert\n");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Code}");
            }
            #endregion

            #region Remove

            SQLite_Helper.DeleteData("HDD");
            list.Clear();
            list = SQLite_Helper.LoadData();
            Console.WriteLine("\nAfter Remove HDD\n");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Code}");
            }
            #endregion


        }
    }
}
