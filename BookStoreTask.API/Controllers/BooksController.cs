﻿using BookStoreTask.API.Utility;
using BookStoreTask.Application.Features.Books.Commands.CreateBook;
using BookStoreTask.Application.Features.Books.Commands.DeleteBook;
using BookStoreTask.Application.Features.Books.Commands.UpdateBook;
using BookStoreTask.Application.Features.Books.Queries.GetBookDetail;
using BookStoreTask.Application.Features.Books.Queries.GetBooksExport;
using BookStoreTask.Application.Features.Books.Queries.GetBooksList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
   
    {
        private readonly IMediator _mediator;

    public BooksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(Name = "GetAllBooks")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<List<BookListVm>>> GetAllBooks()
    {
        var dtos = await _mediator.Send(new GetBooksListQuery());
        return Ok(dtos);
    }

    [HttpGet("{id}", Name = "GetBookById")]
    public async Task<ActionResult<BookDetailVm>> GetBookById(Guid id)
    {
        var getBookDetailQuery = new GetBookDetailQuery() { Id = id };
        return Ok(await _mediator.Send(getBookDetailQuery));
    }

    [HttpPost(Name = "AddBook")]
    public async Task<ActionResult<Guid>> Create(
        [FromBody] CreateBookCommand createBookCommand)
    {
        var id = await _mediator.Send(createBookCommand);
        return Ok(id);
    }

    [HttpPut(Name = "UpdateBook")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update(
        [FromBody] UpdateBookCommand updateBookCommand)
    {
        await _mediator.Send(updateBookCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteBook")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleteBookCommand = new DeleteBookCommand() { BookId = id };
        await _mediator.Send(deleteBookCommand);
        return NoContent();
    }

    [HttpGet("export", Name = "ExportBooks")]
    [FileResultContentType("text/csv")]
    public async Task<FileResult> ExportBooks()
    {
        var fileDto = await _mediator.Send(new GetBooksExportQuery());

        return File(fileDto.Data, fileDto.ContentType, 
            fileDto.BookExportFileName);
    }
}
}
