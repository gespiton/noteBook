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
            tempData.init(defaultFolder);
            loadData();                                        // initialize tempData.store
            initializeList();                                  // build objlistview        
            //Thread t = new Thread(new ThreadStart(closeForm));
            //t.Start();
        }

        private void loadData()       
        {
            if (File.Exists(data))
            {
                // generate store                
                try
                {
                    string s = File.ReadAllText(data);
                    //var a = JsonConvert.DeserializeObject(data);
                    
                    var buf = JsonConvert.DeserializeObject<List<displayItem>>(s);
                    if (buf!=null)
                    {
                        tempData.store = buf;
                    }
                    else
                    {
                        tempData.store = new List<displayItem>();
                    }

                }catch(Exception ex)
                {
                    //tempData.store = new List<Tuple<DateTime, string>>();
                    tempData.store = new List<displayItem>();
                }

                //foreach(var i in tempData.store)
                //{
                //    MessageBox.Show(i.Key.ToString());
                //}
                
            }
            else
            {
                //MessageBox.Show("didn't find data");
                Directory.CreateDirectory(defaultFolder);
                File.Create(data);
                tempData.store = new List<displayItem>(); 
                /// didn't find the stored data 
            }
        }

        private void initializeList()
        {
            this.olvColumn1.ImageGetter = delegate (object src)
            {
                displayItem buf = (displayItem)src;
                if (buf.type == "text")
                {
                    return "text";
                }
                else
                {
                    return "drawing";
                }
            };
            this.olvColumn1.GroupKeyGetter = (object src) =>
            {
                displayItem buf = (displayItem)src;
                return buf.time.GetDateTimeFormats('d')[0];
            };

            this.fileList.SetObjects(tempData.store);
        }


        public void updateObjList()
        {
            this.fileList.SetObjects(tempData.store);
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

        #region close button
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(80, 255, 50, 0);
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.WhiteSmoke;
        }
        private void colse_button(object sender, EventArgs e)
        {
            //tempData.add(DateTime.Now, "haha");
            //var s = JsonConvert.SerializeObject(tempData.oldStore);
            //MessageBox.Show(s);
            //using (StreamWriter outputFile = new StreamWriter(data))
            //{
            //    outputFile.WriteLine(s);
            //}
            //SerializeObject<List<Tuple<DateTime, string>>>(tempData.store, data);
            this.Close();
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

        private void drawPanel_MouseEnter(object sender,EventArgs e)
        {
            drawPanel.BackColor= Color.FromArgb(100, 79, 92, 130);
        }
        private void drawPanel_MouseLeave(object sender, EventArgs e)
        {
            drawPanel.BackColor = Color.FromArgb(100, 22, 51, 72);
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

        #region new file
        private void newFile(object o,EventArgs e)
        {
            TextEdi textEdi = new TextEdi();
            textEdi.Owner = this;
            textEdi.Show();
            newPanel.BackColor = Color.FromArgb(100, 22, 51, 72);
        }
        private void newDrawing(object o, EventArgs e)
        {
            DrawForm drawing = new DrawForm();
            drawing.Owner = this;
            drawing.Show();
            drawPanel.BackColor = Color.FromArgb(100, 22, 51, 72);
        }



        #endregion

        private void fileList_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }



        //public Dictionary<Form, bool> formMag { get; set; } = new Dictionary<Form, bool>();
        private void fileList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //var item = fileList.GetItemAt(e.X, e.Y);
            var item = fileList.GetItemAt(e.X, e.Y);
            //MessageBox.Show(fileList.Items.IndexOf(item).ToString());
            int index = fileList.Items.IndexOf(item);
            //string fileName = item.SubItems[0].Text.Substring(item.SubItems[0].Text.LastIndexOf('/') + 1);
            //foreach (var i in item.SubItems)
            //{
            //MessageBox.Show(i.ToString());
            //}
            if (tempData.store[index].type == "text")
            {
                TextEdi textEdi = new TextEdi(tempData.store[index]);
                textEdi.Owner = this;
                //formMag.Add(textEdi, false);
                textEdi.Show();
            }
            else
            {
                DrawForm drawing = new DrawForm(tempData.store[index]);
                drawing.Owner = this;
                drawing.Show();
            }
        }
        public void closeForm(Form f,string buf)
        {
            f.Close();
        }
        

    }

}
