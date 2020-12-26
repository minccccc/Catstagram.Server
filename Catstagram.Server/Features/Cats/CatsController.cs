using Catstagram.Server.Features.Cats.Models;
using Catstagram.Server.Infrastructure.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Catstagram.Server.Infrastructure.WebConstants;

namespace Catstagram.Server.Features.Cats
{
    [Authorize]
    public class CatsController : ApiController
    {

        private readonly ICatService catService;

        public CatsController(ICatService catService)
        {
            this.catService = catService;
        }

        [HttpGet]
        public async Task<IEnumerable<CatListingServiceModel>> Mine()
        {
            var userId = this.User.GetId();

            return await this.catService.ByUser(userId);
        }

        [HttpGet]
        public async Task<ActionResult<CatDetailsServiceModel>> Details(int id)
            => await this.catService.Details(id);   //Option 2

        //Option 1
        //if(cat == null)
        //{
        //    return NotFound();
        //}
        //return cat.OrnOtFound();


        [HttpPost]
        public async Task<ActionResult> Create(CreateCatRequestModel model)
        {
            var userId = this.User.GetId();

            var id = await this.catService.Create(
                model.ImageUrl,
                model.Description,
                userId);

            return Created(nameof(this.Create), id);
        }

        [HttpPut]
        public async Task<ActionResult> Update(UpdateCatRequestModel model)
        {
            var userId = this.User.GetId();

            var updated = await this.catService.Update(
                model.Id,
                model.Description,
                userId);

            if (!updated)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete]
        [Route(RouteId)]
        public async Task<ActionResult> Delete(int id)
        {
            var userId = this.User.GetId();
            var deleted = await this.catService.Delete(id, userId);

            if (!deleted)
            {
                return BadRequest();
            }

            return Ok();
        }

    }
}
