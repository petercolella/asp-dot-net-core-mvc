﻿using System;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
    }
}
