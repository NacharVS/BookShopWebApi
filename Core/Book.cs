﻿using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string BookName { get; set; }
        public int YearOfCreation { get; set; }
        public string Author { get; set; }
        public string Izdat { get; set; }
    }
}
