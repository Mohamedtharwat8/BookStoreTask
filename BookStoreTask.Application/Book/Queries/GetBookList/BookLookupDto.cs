using AutoMapper;
using BookStoreTask.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq; 

namespace BookStoreTask.Application.Book.Queries.GetBookList
{
    public class BookLookupDto : IMapWith<BookStoreTask.Domain.Entities.Book>
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
        public string? CreationYear { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BookStoreTask.Domain.Entities.Book, BookLookupDto>();
        }


    }
}
