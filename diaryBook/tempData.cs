using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace diaryBook
{
    #region temp data cross forms
    class tempData
    {

        public static string dataPath { get; set; }  // folder
        public static string config { get; set; } = @"D:\noteBook\_data";
        public static void init(string path)
        {
            dataPath = path;
        }
        public static Dictionary<DateTime, string> oldStore = new Dictionary<DateTime, string>();
        public static void add(DateTime t, string s)
        {
            oldStore.Add(t, s);
        }
        public static List<displayItem> store { get; set; } = new List<displayItem>();

        public static void serialize()
        {
            var s = JsonConvert.SerializeObject(tempData.store);

            // create config file
            if (!File.Exists(tempData.config))
            {
                File.Create(tempData.config);
            }

            using (StreamWriter outputFile = new StreamWriter(tempData.config))
            {
                outputFile.WriteLine(s);
            }
        }
    }
    #endregion
}
