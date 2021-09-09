using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortySample.Models
{
    public class RickAndMortyResponse<T>
    {
        public Info info { get; set; }
        public IEnumerable<T> results { get; set; }

        public class Info
        {
            public int count { get; set; }
            public int pages { get; set; }
            public string next { get; set; }
            public object prev { get; set; }
        }
    }
}
