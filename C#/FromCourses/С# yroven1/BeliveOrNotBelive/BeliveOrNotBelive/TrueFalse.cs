using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BeliveOrNotBelive
{
    public class Question
    {
        public string Text { get; set; }
        public bool Truth { get; set; }

        public Question ()
        {

        }

        public Question (string text, bool truth)
        {
            Text = text;
            Truth = truth;
                
        }
    }

    class TrueFalse
    {
        List<Question> list = new List<Question>();

        public List<Question> List
        {
            get { return list; }
            set { list = value; }
        }

        public void Save (string filename)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void Load(string filename)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

    }

    
}
