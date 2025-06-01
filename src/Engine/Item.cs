using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public System.Drawing.Image Picture { get; set; }
        public int Price { get; set; }

        public Item RewardItem { get; set; }

        public Item(int id,string name,string namePlural,int price, System.Drawing.Image picture =null)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Price = price;
            Picture = picture;
        }
    }
}
