using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DAL.Concrete.Mapping
{
    public class OrderDetailMapping: EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapping()
        {
            HasKey(a => new { a.OrderID, a.AlbumID });
            Property(a => a.Price).HasPrecision(5, 2);
        }
    }
}
