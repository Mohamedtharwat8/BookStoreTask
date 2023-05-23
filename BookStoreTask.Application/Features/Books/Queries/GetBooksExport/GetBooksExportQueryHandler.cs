using AutoMapper;
using BookStoreTask.Application.Contracts.Infrastructure;
using BookStoreTask.Application.Contracts.Persistence;
using BookStoreTask.Domain.Entities;
using MediatR; 

namespace BookStoreTask.Application.Features.Books.Queries.GetBooksExport
{

    public class GetBooksExportQueryHandler :
        IRequestHandler<GetBooksExportQuery, BookExportFileVm>
    {
        private readonly IAsyncRepository<BookRent> _bookRepository;
        private readonly IMapper _mapper;
        private readonly ICsvExporter _csvExporter;

        public GetBooksExportQueryHandler(
            IMapper mapper, 
            IAsyncRepository<BookRent> bookRepository,
            ICsvExporter csvExporter)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _csvExporter = csvExporter;
        }

        public async Task<BookExportFileVm> Handle(
            GetBooksExportQuery request, 
            CancellationToken cancellationToken)
        {
            var allBooks = _mapper.Map<List<BookExportDto>>((
                await _bookRepository.ListAllAsync()).OrderBy(x => x.Date));

            var fileData = _csvExporter.ExportBooksToCsv(allBooks);

            var eventExportFileDto = new BookExportFileVm() { 
                ContentType = "text/csv", Data = fileData, 
                BookExportFileName = $"{Guid.NewGuid()}.csv" };

            return eventExportFileDto;
        }
    }
}
