using MusicStore.Core.DAL.EntityFramework;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DAL.Concrete.Repositories
{
    public class UserRepository:EFRepositoryBase<User, MusicStoreDbContext>,IUserDAL
    {

    }
}
