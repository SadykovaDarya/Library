using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class Reader
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abonement { get; set; }

        public List<Book> Books { get; set; }
    }
}
