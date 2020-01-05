using MusicStore.DAL.Abstract;
using MusicStore.DAL.Concrete.Repositories;
using MusicStore.Model;
using MusicStore.Services.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MusicStore.Services.WebAPI.Controllers
{
    public class AlbumController : ApiController
    {
        IAlbumDAL _albumDAL;
        public AlbumController()
        {
            _albumDAL = new AlbumRepository();
        }

        public IHttpActionResult GetAlbums()
        {
            List<AlbumModel> albums = new List<AlbumModel>();

            foreach (var item in _albumDAL.GetAll(a => a.Discontinued == false))
            {
                albums.Add(new AlbumModel()
                {
                    AlbumID = item.ID,
                    AlbumArtUrl = item.AlbumArtUrl,
                    Price = item.Price,
                    Title = item.Title,
                    Discounted = item.Discounted
                });
            }
            return Json(albums);
        }
        //genreye göre ürün getir
        public IHttpActionResult GetAlbums(int id)
        {
            List<AlbumModel> albums = new List<AlbumModel>();
            foreach (var item in _albumDAL.GetAll(a => a.Discontinued == false && a.GenreID == id))
            {
                albums.Add(new AlbumModel()
                {
                    AlbumID = item.ID,
                    AlbumArtUrl = item.AlbumArtUrl,
                    Price = item.Price,
                    Title = item.Title,
                    Discounted = item.Discounted
                });
            }
            return Json(albums);
        }
        //ekleenen 5 ürünü getir 
        public IHttpActionResult GetLastFiveAlbums()
        {
            List<AlbumModel> albums = new List<AlbumModel>();
            foreach (var item in _albumDAL.GetAll(a => a.Discontinued == false).OrderByDescending(a => a.CreatedDate).Take(5).ToList())
            {
                albums.Add(new AlbumModel()
                {
                    AlbumID = item.ID,
                    AlbumArtUrl = item.AlbumArtUrl,
                    Price = item.Price,
                    Title = item.Title,
                    Discounted = item.Discounted
                });
            }
            return Json(albums);
        }
        //indirimdekileri getir
        public IHttpActionResult GetDiscountAlbums()
        {
            List<AlbumModel> albums = new List<AlbumModel>();
            foreach (var item in _albumDAL.GetAll(a => a.Discontinued == false&& a.Discounted ==true).ToList())
            {
                albums.Add(new AlbumModel()
                {
                    AlbumID = item.ID,
                    AlbumArtUrl = item.AlbumArtUrl,
                    Price = item.Price,
                    Title = item.Title,
                    Discounted = item.Discounted
                });
            }
            return Json(albums);
        }
        //tek ürün getir
        public IHttpActionResult Get(int id)
        {
            Album album = _albumDAL.Get(a => a.ID == id);

            if (album == null)
            {
                return NotFound();
            }

            AlbumModel model = new AlbumModel();
            model.AlbumID = album.ID;
            model.Price = album.Price;
            model.Title = album.Title;
            model.Discounted = album.Discounted;
            return Json(model);
        }


    }
}
