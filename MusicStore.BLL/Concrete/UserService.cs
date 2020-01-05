﻿using MusicStore.BLL.Abstract;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.BLL.Concrete
{
  
    public class UserService : IUserService
    {
        IUserDAL _userDAL;
        public UserService(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public void Delete(User entity)
        {
            _userDAL.Remove(entity);            
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public User Get(int entityId)
        {
            return _userDAL.Get(a => a.ID == entityId);
        }

        public ICollection<User> GetAll()
        {
            return _userDAL.GetAll();
        }

        public void Insert(User entity)
        {
            _userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            _userDAL.Update(entity);
        }
    }
}
