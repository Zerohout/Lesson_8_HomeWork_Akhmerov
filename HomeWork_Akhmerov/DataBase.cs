using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomeWork_Akhmerov
{
    class DataBase
    {
        private string fileName;
        private List<Questions> list;

        public string FileName
        {
            set => fileName = value;
        }

        public DataBase(string fileName)
        {
            this.fileName = fileName;
            list = new List<Questions>();
        }

        public List<Questions> List => list;
       

        public void Add(string text,bool isTrue)
        {
            list.Add(new Questions(text,isTrue));
        }

        public void Remove(int index)
        {
            if (list != null && list.Count > 0 && index <= list.Count)
            {
                list.RemoveAt(index-1);
                
            }
            else
            {
                MessageBox.Show("Произошла ошибка. Видимо элемент отсутствует.","Sepo");
            }
        }

        public Questions this[int index] {
            
            get =>list[index];
    }

        public List<Questions> GetList
        {
            get => list;
            set => list = value;
        }
        
        public void Save()
        {
            var serializer = new XmlSerializer(typeof(List<Questions>));
            Stream stream = new FileStream(fileName,FileMode.Create,FileAccess.Write);
            serializer.Serialize(stream,list);
            stream.Close();
        }

        public List<Questions> Load()
        {
            var serializer = new XmlSerializer(typeof(List<Questions>));
            Stream stream = new FileStream(fileName,FileMode.Open,FileAccess.Read);
            list = (List<Questions>) serializer.Deserialize(stream);
            stream.Close();
            return list;
        }

        public int Count => list.Count;
    }
}
