using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using tnine.Core.Shared.Dto;
using tnine.Application.Shared.ICategoryService.Dto;
using tnine.Application.Shared.ICategoryService;

namespace tnine.Web.Host.Api
{
    [RoutePrefix("api/category")]
    public class CategoryApiController : ApiController
    {
        private ICategoryService _categoryService;

        public CategoryApiController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("")]
        public async Task<HttpResponseMessage> GetAll()
        {
            var categories = await _categoryService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, categories);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<HttpResponseMessage> GetById(long id)
        {
            var input = new EntityDto<long> { Id = id };
            var category = await _categoryService.GetById(input);
            return Request.CreateResponse(HttpStatusCode.OK, category);
        }

        [HttpPost]
        [Route("")]
        public async Task<HttpResponseMessage> CreateOrEdit([FromBody] CreateOrEditCategoryDto input)
        {
            if (input == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid data.");
            }

            try
            {
                await _categoryService.CreateOrEdit(input);
                return Request.CreateResponse(HttpStatusCode.OK, "category created or updated successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, $"An error occurred: {ex.Message}");
            }
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<HttpResponseMessage> Delete(long id)
        {
            var input = new EntityDto<long> { Id = id };
            await _categoryService.Delete(input);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}