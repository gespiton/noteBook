using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diaryBook
{
    public class displayItem
    {
        public string name { get; set; }
        public DateTime time { get; set; }
        public string type { get; set; }
        public string filePath { get; set; }


        //static private List<displayItem> items = null; // current display items

        public displayItem(string name,DateTime time, string type,string path)
        {
            this.name = name;
            this.time = time;
            this.type = type;
            this.filePath = path;
        }

        //public static List<displayItem> getItems(Dictionary<DateTime, string> store)
        //{
        //    if (items != null)
        //    {
        //        return items;
        //    }else
        //    {
        //        items = new List<displayItem>();


        //        foreach (var item in store)
        //        {
        //            items.Add(new displayItem(item.Value, item.Key, "text",item.Value));
        //        }
        //        return items;
        //    }
        //}
    }
}
