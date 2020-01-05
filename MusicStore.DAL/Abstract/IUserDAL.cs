using MusicStore.Core.DAL;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DAL.Abstract
{
    public interface IUserDAL : IRepository<User>
    {
    }
}
