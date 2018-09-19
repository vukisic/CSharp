using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTests
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonAPI api = new PersonAPI();
            LogAPI logger = new LogAPI();
            int op = 0;
            string firstName, lastName;
            int id;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Get All Persons");
                Console.WriteLine("4. Print Persons in JSON");
                Console.WriteLine("5. Exit");
                Console.WriteLine(">>");
                op=Int32.Parse(Console.ReadLine());

                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("First Name: ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Id: ");
                        id = Int32.Parse(Console.ReadLine());
                        Person tempPerson = new Person(firstName, lastName, id);
                        api.AddPerson(tempPerson);
                        Console.WriteLine("Successfully Added Person!");
                        logger.Log("Added Person { " + tempPerson + " }");
                        break;

                    case 2:
                        Console.WriteLine("Id: ");
                        id = Int32.Parse(Console.ReadLine());
                        try
                        {
                            api.RemovePerson(id);
                            Console.WriteLine("Successfully Removed Person!");
                            logger.Log("Removed Person Id: " + id);
                        }
                        catch (AccessViolationException ex)
                        {
                            Console.WriteLine(ex.Message);
                            logger.Log("Tried to Remove Person Id: " + id);
                        }
                        break;

                    case 3:
                        List<Person> list = api.PersonsList();
                        Console.WriteLine("Persons: \n");
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        logger.Log("Persons To List");
                        break;

                    case 4:
                        Console.WriteLine("File Name:");
                        string filename = Console.ReadLine();
                        try
                        {
                            api.PrintPersonsInJson("../../../" + filename);
                            Console.WriteLine("File is Saved to Location: ../../../"+filename+" !");
                            logger.Log("Persons Printed in file : ../../../" + filename);
                        }
                        catch (InvalidOperationException ex)
                        {

                            Console.WriteLine(ex.Message);
                            logger.Log("Tried to Print Persons in file : ../../../" + filename);
                        }
                        break;

                    case 5:break;
                    default: Console.WriteLine("Error Command!");break;
                }


            } while (op != 5);
        }
    }
}
