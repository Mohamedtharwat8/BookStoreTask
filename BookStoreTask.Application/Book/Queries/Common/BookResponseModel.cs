using AutoMapper;
using BookStoreTask.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Book.Queries.Common
{

    public class BookResponseModel : IMapFrom<BookStoreTask.Domain.Entities.Book>
    {
        public int Id { get; init; }

        public string Title { get; init; } = default!;

        public decimal Price { get; init; }

        public string ImageUrl { get; init; } = default!;

        public string Genre { get; init; } = default!;

        public string AuthorName { get; init; } = default!;

        public bool IsAvailable { get; init; }

        public virtual void Mapping(Profile mapper)
            => mapper
                .CreateMap< BookStoreTask.Domain.Entities.Book, BookResponseModel>()
                .ForMember(m => m.IsAvailable, cfg => cfg
                    .MapFrom(m => m.Quantity != 0));
    }
}
