using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortySample.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Air_date { get; set; }
        public string episode { get; set; }
        public List<string> Characters { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }

        public Episode CreateFakeData()
        {
            this.Id = 5214354;
            this.Name = "asa";
            this.episode = "dfdf";
            return this;
        }
    }
}
