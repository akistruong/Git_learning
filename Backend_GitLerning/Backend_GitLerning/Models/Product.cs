﻿namespace Backend_GitLerning.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int ?Slug { get; set; }
    }
}
