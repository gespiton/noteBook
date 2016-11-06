using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace diaryBook
{
    public partial class startForm: Form
    {
        public string defaultFolder { get; set; }
        public string data { get; set; }


        public startForm()
        {
            InitializeComponent();
            defaultFolder = @"D:\noteBook\";
            data = @"D:\noteBook\_data";
            tempData.init(data);
            loadData();
        }
        private void loadData()
        {
            if (File.Exists(data))
            {
                //var buf = DeSerializeObject< List<Tuple<DateTime,string>> > (data);
                
                // generate store                
                try
                {
                    string s = File.ReadAllText(data);
                    //var a = JsonConvert.DeserializeObject(data);
                    var buf = JsonConvert.DeserializeObject<List<Tuple<DateTime, string>>>(s);
                    tempData.store = buf;

                }catch(Exception ex)
                {
                    tempData.store = new List<Tuple<DateTime, string>>();
                }

                // generate dic
                foreach(var i in tempData.store)
                {
                    
                }


                //if (tempData.myData != null)
                //{
                //    MessageBox.Show(tempData.myData.Count.ToString());
                    
                //    foreach (var item in tempData.store)
                //    {
                //        MessageBox.Show(item.Item1.ToString());
                //    }
                //}


            }
            else
            {
                //MessageBox.Show("didn't find data");
                Directory.CreateDirectory(defaultFolder);
                File.Create(data);
                /// didn't find the stored data 
                tempData.init(data);
                          
            }
        }


        private void siderHeadPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startForm_Load(object sender, EventArgs e)
        {

        }

        private void colse_button(object sender, EventArgs e)
        {
            tempData.add(DateTime.Now, "haha");
            var s = JsonConvert.SerializeObject(tempData.store);
            MessageBox.Show(s);
            using (StreamWriter outputFile = new StreamWriter(data))
            {
                outputFile.WriteLine(s);
            }
            //SerializeObject<List<Tuple<DateTime, string>>>(tempData.store, data);
            this.Close();
        }

        #region move
        public bool move { get; set; } = false;
        public Point mousePos { get; set; }
        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mousePos = new Point(e.X, e.Y);
            Console.WriteLine(mousePos.X+"---"+mousePos.Y);
        }
        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                var p = PointToScreen(e.Location);
                Console.WriteLine(p.X+"  "+p.Y);
                this.Location = new Point(p.X - mousePos.X, p.Y - mousePos.Y);
            }
        }
        #endregion

        #region close
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(80, 255, 50, 0);
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.WhiteSmoke;
        }
        #endregion


        #region buttonHighlighter
        private void newPanel_MouseEnter(object sender, EventArgs e)
        {
            newPanel.BackColor = Color.FromArgb(100, 79, 92, 130);
        }
        private void newPanel_MouseLeave(object sender, EventArgs e)
        {
            newPanel.BackColor = Color.FromArgb(100, 22, 51, 72);
        }

        #endregion

        #region serizer
        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }
        }


        /// <summary>
        /// Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }
                    read.Close();
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }

            return objectOut;
        }
        #endregion

        #region storageClass
        [Serializable]
        public class storeData:List<Tuple< DateTime,string>>
        {
            //private Dictionary<DateTime, string> files = new Dictionary<DateTime, string>();
            public void Add(DateTime t, string s)
            {
                this.Add(new Tuple<DateTime, string>(t, s));
            }
        }
        #endregion

        #region temp data cross forms
        class tempData
        {
            public static storeData myData = new storeData();
            public static string dataPath { get; set; }
            public static void init(string path)
            {
                myData = new storeData();
                dataPath = path;
            }
            public static List<Tuple<DateTime, string>> store = new List<Tuple<DateTime, string>>();
            public static void add (DateTime t,string s)
            {
                store.Add(new Tuple<DateTime, string>(t, s));
            }
            public Dictionary<string, DateTime> buf { get; set; } = new Dictionary<string, DateTime>();
        }
        #endregion
    }
}
