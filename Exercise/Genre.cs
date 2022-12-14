using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Genre
    {
        public Genre()
        {
            Videos = new HashSet<Video>();
        }
        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}
