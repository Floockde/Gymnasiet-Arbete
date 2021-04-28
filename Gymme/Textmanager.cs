using System.IO;
using System.Xml;

namespace Gymme
{
    class Textmanager
    {
        public Textmanager()
        {
            XmlDocument story = new XmlDocument();
            story.LoadXml("C:\\Users\\Administrator\\OneDrive - Rättviks Kommun\\source\\Gymme\\Gymnasiet-Arbete\\Gymnasiet-Arbete\\Story\\Story.xml");

            XmlNode node = story.GetElementsByTagName("Dialogue");

            string dialogue = node.InnerText;
        }

        private static Textmanager instance = null;
        private static readonly object padlock = new object();

        public static Textmanager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Textmanager();
                    }
                    return instance;
                }
            }
        }
    }
}
