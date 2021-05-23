﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Data.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }


        public int PublisherId { get; set; }
        public List<int> AuthorsId { get; set; }
    }

    public class BookWithAuthorsVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }


        public string PublisherName { get; set; }
        public List<string> AuthorsNames { get; set; }
    }
}
