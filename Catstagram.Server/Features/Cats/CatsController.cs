﻿using Catstagram.Server.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catstagram.Server.Features.Cats
{
    public class CatsController : ApiController
    {

        private readonly ICatService catService;

        public CatsController(ICatService catService)
        {
            this.catService = catService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IEnumerable<CatListingResponseModel>> Mine()
        {
            var userId = this.User.GetId();

            return await this.catService.ByUser(userId);
        }


        [Authorize]
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
    }
}
