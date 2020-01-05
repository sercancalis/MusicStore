using MusicStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Model
{
    public class Artist:BaseEntity
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
        }
        public string FullName { get; set; }
        public byte Rating { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}
