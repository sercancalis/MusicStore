using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DAL.Concrete.Mapping
{
    public class OrderMapping: EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            Property(x => x.ShipAddress).HasMaxLength(350);
        }
    }
}
