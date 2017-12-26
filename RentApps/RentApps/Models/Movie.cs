﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RentApps.Migrations;

namespace RentApps.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte Stock { get; set; }
    }
}