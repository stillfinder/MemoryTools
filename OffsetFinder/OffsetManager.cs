using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memory;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace MemoryTools.OffsetFinder
{
    public class OffsetManager
    {
        /// <summary>
        /// List with offsets
        /// </summary>
        private List<Offset> offsets;

        public OffsetManager()
        {
            offsets = new List<Offset>();
        }

        /// <summary>
        /// Fill Offsets List from XML file
        /// </summary>
        /// <param name="FileName">name of file</param>
        public static OffsetManager GetOffsetsFromXML(string FileName)
        {
            if (File.Exists(FileName))
            {
                try
                {
                    FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    XmlSerializer serializer = new XmlSerializer(typeof(OffsetManager));
                    OffsetManager list = (OffsetManager)serializer.Deserialize(stream);
                    stream.Close();
                    return list;
                }
                catch
                {
                    MessageBox.Show("Xml File have a error.");
                    return null;
                }
            }
            MessageBox.Show("Select a XML Pattern List.");
            return null;
        }

        /// <summary>
        /// Save Offsets to XML file
        /// </summary>
        /// <param name="FileName">name of file</param>
        public void SaveOffsetsToXML(string FileName)
        {
            FileStream stream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer serializer = new XmlSerializer(typeof(OffsetManager));
            //OffsetManager list = (OffsetManager)serializer.Deserialize(stream);
            serializer.Serialize(stream,this);
            stream.Close();

            return;
            using (TextWriter fs = new StreamWriter(FileName))
            {
                XmlSerializer xs = new XmlSerializer(typeof(OffsetManager));
                xs.Serialize(fs, this);
            }
        }

        /// <summary>
        /// Add offset
        /// </summary>
        /// <param name="of">Offset</param>
        public void AddOffset(Offset of)
        {
            if (!offsets.Contains(of))
            {
                offsets.Add(of);
            }
        }

        /// <summary>
        /// Remove offset
        /// </summary>
        /// <param name="of">Offset</param>
        public void RemoveOffset(Offset of)
        {
            if (offsets.Contains(of))
            {
                offsets.Remove(of);                
            }
        }

        /// <summary>
        /// Return List of offsets
        /// </summary>
        /// <returns>List of offsets</returns>
        public List<Offset> Offsets
        {
            get
            {
                return offsets;
            }
        }

        /// <summary>
        /// Search Offset Addresses in Attached process
        /// </summary>
        public void SearchOffsets(MemoryWorker mv)
        {
            foreach (Offset offset in offsets)
            {
                offset.ClearAdreses();
                offset.SearchOffset(mv);
            }
        }

        /// <summary>
        /// Clear Offsets list
        /// </summary>
        public void ClearOffsets()
        {
            offsets.Clear();
        }
    }
}
