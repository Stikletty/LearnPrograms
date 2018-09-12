using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LearnPrograms
{
    class XMLHandler
    {
        public List<string> getXMLElement(string xmlFile, string attributeName)
        {
            List<string> resultElements = new List<string>();

            try { 
                XmlTextReader xmlReader = new XmlTextReader(xmlFile);
                
                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == attributeName))
                    {
                            resultElements.Add(xmlReader.ReadElementContentAsString());
                    }
                }

                return resultElements;
            }
            catch (Exception ex)
            {
                throw ex;                
            }
        }
    }
}
