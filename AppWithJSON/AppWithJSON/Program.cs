using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;

namespace AppWithJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../Data.json";
            string JSONstring = File.ReadAllText(path);
            List<Item> list = JsonConvert.DeserializeObject<List<Item>>(JSONstring);

            if (list == null)
                list = new List<Item>();

            string input="";
            int tmpPrice;
            string tmpName;

            while(input!="4")
            {
                Console.WriteLine("1. Add New Item");
                Console.WriteLine("2. Delete Item");
                Console.WriteLine("3. Show All Items");
                Console.WriteLine("4. Exit");
                Console.WriteLine(">>");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Name:");
                        tmpName = Console.ReadLine();
                        Console.WriteLine("Price:");
                        tmpPrice = Int32.Parse(Console.ReadLine());
                        list.Add(new Item(tmpName, tmpPrice));
                        break;
                    case "2":
                        Console.WriteLine("Name:");
                        tmpName = Console.ReadLine();
                        if(CheckInList(list,tmpName))
                            list.Remove(new Item(tmpName));
                        else
                            Console.WriteLine("Wrong Name!");
                        break;
                    case "3":
                        Console.WriteLine("\nContent:");
                        foreach (var item in list)
                        {
                            Console.WriteLine("Item:  "+item.Name+" | $"+item.Price);
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Incorecct command!");
                        break;
                }

            }

            string data = JsonConvert.SerializeObject(list);
            File.WriteAllText(path, data);
            Console.ReadLine();

        }

        public static bool CheckInList(List<Item> list,string name)
        {
            foreach (var item in list)
            {
                if (item.Name == name)
                    return true;
            }
            return false;
        }
    }
}
