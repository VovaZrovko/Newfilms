using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF
{
    class Film
    {
        public ObjectId id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public List<string> genre { get; set; }
        public int budget { get; set; }
        public int earned { get; set; }
        public List<string> director { get; set; }
        public List<string> country { get; set; }

    }

}
