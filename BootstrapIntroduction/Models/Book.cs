﻿namespace BootstrapIntroduction.Models
{
    //Example 4-1. The Book model p.33
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual Author Author { get; set; }
    }
}