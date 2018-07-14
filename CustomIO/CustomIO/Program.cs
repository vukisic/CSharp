using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIO
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomReader reader1 = new CustomReader("../../../file.bin",BaseIO.ByteOrder.LittleEndian);
            byte[]arr1 =reader1.ReadBytes(4);
            Console.WriteLine("Little Endian:");
            foreach (var item in arr1)
            {
                Console.WriteLine(item.ToString("X"));
            }
            reader1.Close();


            CustomReader reader2 = new CustomReader("../../../file.bin", BaseIO.ByteOrder.BigEndian);
            byte[] arr2 = reader2.ReadBytes(4);
            Console.WriteLine("Big Endian:");
            foreach (var item in arr2)
            {
                Console.WriteLine(item.ToString("X"));
            }
            reader2.Close();

            CustomWriter writer1 = new CustomWriter("../../../le.bin", BaseIO.ByteOrder.LittleEndian);
            byte[] ar = { 0x31, 0x32, 0x33 };
            writer1.WriteBytes(ar);
            writer1.Close();

            CustomWriter writer2 = new CustomWriter("../../../be.bin", BaseIO.ByteOrder.BigEndian);
            writer2.WriteBytes(ar);
            writer2.Close();


        }
    }
}
