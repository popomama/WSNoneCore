﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSNoneCore
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public short Price { get; set; }
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}
