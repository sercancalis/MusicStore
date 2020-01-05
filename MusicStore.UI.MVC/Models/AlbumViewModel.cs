﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.UI.MVC.Models
{
    public class AlbumViewModel
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public bool Discounted { get; set; }
    }
}