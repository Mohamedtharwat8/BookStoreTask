 
using CsvHelper; 
using BookStoreTask.Application.Contracts.Infrastructure;
using BookStoreTask.Application.Features.Books.Queries.GetBooksExport;

namespace BookStoreTask.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportBooksToCsv(List<BookExportDto> bookExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new  CsvWriter(streamWriter);
                csvWriter.WriteRecords(bookExportDtos);
            }

            return memoryStream.ToArray();
        }


    }
}