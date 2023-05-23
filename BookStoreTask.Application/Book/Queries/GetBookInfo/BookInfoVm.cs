using AutoMapper;
using BookStoreTask.Application.Common.Mappings;
using BookStoreTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Book.Queries.GetBookInfo
{
    public class BookInfoVm : IMapWith<Book>
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
        public string? CreationYear { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Book, BookInfoVm>();
        }
    }
}
