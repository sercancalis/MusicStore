using MusicStore.BLL.Abstract;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.BLL.Concrete
{
    public class AlbumService : IAlbumService
    {
        IAlbumDAL _albumDAL;
        public AlbumService(IAlbumDAL albumDAL)
        {
            _albumDAL = albumDAL;
        }
        public void Delete(Album entity)
        {
            _albumDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Album Get(int entityId)
        {
            return _albumDAL.Get(a => a.ID == entityId);
        }

        public ICollection<Album> GetAll()
        {
            return _albumDAL.GetAll();
        }

        public void Insert(Album entity)
        {
            _albumDAL.Add(entity);
        }

        public void Update(Album entity)
        {
            _albumDAL.Update(entity);
        }
    }
}
