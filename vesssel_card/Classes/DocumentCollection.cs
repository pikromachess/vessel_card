using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace vesssel_card.Classes
{
    [Serializable]
    [XmlRoot("DocumentCollection")]
    public class DocumentCollection
    {
        private const string _fileName = "DocumentCollection.xml";

        [XmlElement("Document")]
        public List<Document> Documents { get; set; }

        public DocumentCollection()
        {
            Documents = new List<Document>();

        }

        public void DeleteByID(int? id)
        {
            if (id.HasValue)
            {
                Document document = Documents.FirstOrDefault(doc => doc.Id == id.Value);
                Documents.Remove(document);
                Save();
            }
        }

        public void Save()
        {
            var serializer = new XmlSerializer(typeof(DocumentCollection));
            using (var writer = new StreamWriter(_fileName))
            {
                serializer.Serialize(writer, this);
            }
        }

        public void AddUpdate(Document newDocument)
        {
            Document oldDocument = Documents.FirstOrDefault(doc => doc.Id == newDocument.Id);

            if (oldDocument == null)
            {
                newDocument.Id = Documents.Count;
                Documents.Add(newDocument);
            }
            else
            {
                int index = Documents.IndexOf(oldDocument);
                Documents[index] = newDocument;
            }

            Save();
        }
        public static DocumentCollection GetCollection()
        {
            var serializer = new XmlSerializer(typeof(DocumentCollection));

            using (FileStream fs = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                return (DocumentCollection)serializer.Deserialize(fs);
            }
        }
    }
}
