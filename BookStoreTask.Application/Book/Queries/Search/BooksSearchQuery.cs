//using BookStoreTask.Application.Interfaces;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BookStoreTask.Application.Book.Queries.Search
//{
//    public class BooksSearchQuery : IRequest<BooksSearchResponseModel>
//    {
//        private const int BooksPerPage = 10;

//        public string? Title { get; init; }

//        public decimal? MinPrice { get; init; }

//        public decimal? MaxPrice { get; init; }

//        public int? Genre { get; init; }

//        public string? Author { get; init; }

//        public string? SortBy { get; init; }

//        public string? Order { get; init; }

//        public int Page { get; init; } = 1;

//        public class BooksSearchQueryHandler : IRequestHandler<BooksSearchQuery, BooksSearchResponseModel>
//        {
//            private readonly IBookStoreDbContext memoryDatabase;
//            private readonly IBookStoreDbContext bookRepository;

//            public BooksSearchQueryHandler(
//                IBookStoreDbContext memoryDatabase,
//                IBookStoreDbContext bookRepository)
//            {
//                this.memoryDatabase = memoryDatabase;
//                this.bookRepository = bookRepository;
//            }

//            public async Task<BooksSearchResponseModel> Handle(
//                BooksSearchQuery request,
//                CancellationToken cancellationToken)
//            {
//                var specification = this.GetBookSpecification(request);

//                var searchOrder = new BooksSearchSortOrder(
//                    request.SortBy,
//                    request.Order);

//                var totalBooks = await this.bookRepository.Total(
//                    specification,
//                    cancellationToken);

//                var totalPages = (int)Math.Ceiling((double)totalBooks / BooksPerPage);

//                var isDefaultQuery = request is
//                {
//                    Page: 1,
//                    Title: null,
//                    MinPrice: null,
//                    MaxPrice: null,
//                    Genre: null,
//                    Author: null,
//                    SortBy: null,
//                    Order: null
//                };

//                if (isDefaultQuery)
//                {
//                    var cachedBooks = await this.memoryDatabase.Get<List<BookResponseModel>>(BooksListingKey);

//                    if (cachedBooks is not null && cachedBooks.Any())
//                    {
//                        return new BooksSearchResponseModel(cachedBooks, request.Page, totalPages);
//                    }
//                }

//                var skip = (request.Page - 1) * BooksPerPage;

//                var booksListing = await this.bookRepository.GetBooksListing(
//                    specification,
//                    searchOrder,
//                    skip,
//                    take: BooksPerPage,
//                    cancellationToken);

//                if (isDefaultQuery)
//                {
//                    await this.memoryDatabase.AddOrUpdate(BooksListingKey, booksListing);
//                }

//                return new BooksSearchResponseModel(booksListing, request.Page, totalPages);
//            }

//            private Specification<Book> GetBookSpecification(
//                BooksSearchQuery request)
//                => new BookByTitleSpecification(request.Title)
//                    .And(new BookByPriceSpecification(request.MinPrice, request.MaxPrice))
//                    .And(new BookByGenreSpecification(request.Genre))
//                    .And(new BookByAuthorSpecification(request.Author));
//        }
//    }
//}
