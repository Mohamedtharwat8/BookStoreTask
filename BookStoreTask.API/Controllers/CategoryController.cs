using BookStoreTask.Application.Features.Categories.Commands.CreateCateogry;
using BookStoreTask.Application.Features.Categories.Queries.GetCategoriesList;
using BookStoreTask.Application.Features.Categories.Queries.GetCategoriesListWithBooks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize]
        [HttpGet("all", Name = "GetAllCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryListVm>>> GetAllCategories()
        {
            var dtos = await _mediator.Send(new GetCategoriesListQuery());
            return Ok(dtos);
        }

        [Authorize]
        [HttpGet("allwithBook", Name = "GetCategoriesWithBooks")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryBookListVm>>>
            GetCategoriesWithBooks(bool includeHistory)
        {
            GetCategoriesListWithBooksQuery getCategoriesListWithBooksQuery = 
                new GetCategoriesListWithBooksQuery() {
                    IncludeHistory = includeHistory };

            var dtos = await _mediator.Send(getCategoriesListWithBooksQuery);
            return Ok(dtos);
        }

        [HttpPost(Name = "AddCategory")]
        public async Task<ActionResult<CreateCategoryCommandResponse>>
            Create([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }
    }
}
