﻿using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DAL.Concrete.Mapping
{
    public class GenreMapping: EntityTypeConfiguration<Genre>
    {
        public GenreMapping()
        {
            Property(x => x.Name).HasMaxLength(75).IsRequired();
            Property(x => x.Description).HasMaxLength(300);
        }
    }
}
