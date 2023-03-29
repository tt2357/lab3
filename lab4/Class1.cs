using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab4
{
    [XmlType("parametry")]
    public class Parametry
    {
        private string author;
        private string title;
        private string genre;
        private string iSBN;

        public Parametry()
        {
            author = null;
            title = null;
            genre = null;
            iSBN = null;
        }

        public Parametry(string author, string title, string genre, string iSBN)
        {
            Author = author;
            Title = title;
            Genre = genre;
            ISBN = iSBN;

        }

        public override string ToString()
        {
            return Author + Title + Genre + iSBN;
        }

        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        public string ISBN { get => iSBN; set => iSBN = value; }
    }
}
