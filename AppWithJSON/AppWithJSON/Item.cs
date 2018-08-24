using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithJSON
{
    [Serializable]
    public class Item : IEquatable<Item>
    {
        private string name;
        private int price;

        public Item(string name = "noname", int price = 0)
        {
            this.name = name;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public bool Equals(Item x)
        {
            if (x == null)
                return false;
            else
                return this.name.Equals(this.name);
        }



     
    }
}
