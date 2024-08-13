using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Administrator_Wydarzeń.Repository
{
    public class XML
    {
        public static void SaveToXml(string[,] array, string filePath)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; // Wcięcia dla lepszej czytelności
            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartElement("Events");

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    writer.WriteStartElement("Event");

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        writer.WriteStartElement("Info");
                        writer.WriteString(array[i, j]);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }

        public static string[,] LoadFromXml(string filePath)
        {
            XmlDocument reader = new XmlDocument();
            try
            {
                reader.Load(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            XmlNodeList rowNodes = reader.SelectNodes("/Events/Event");
            if (rowNodes.Count == 0)
            {
                return null;
            }
            int rows = rowNodes.Count;
            int columns = rowNodes[0].ChildNodes.Count;
            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                XmlNodeList cellNodes = rowNodes[i].ChildNodes;
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = cellNodes[j].InnerText;
                }
            }

            return array;
        }

        public static void DisplayArray(string[,] array)
        {
            if (array == null) { return; }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
