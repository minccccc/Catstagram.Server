using Catstagram.Server.Infrastructure.Extensions;
using Microsoft.AspNetCore.Http;

namespace Catstagram.Server.Infrastructure.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor) 
            => this.httpContextAccessor = httpContextAccessor;


        public string GetUserId()
            => this.httpContextAccessor
            .HttpContext
            .User
            ?.Identity
            ?.Name;

        public string GetUserName()
            => this.httpContextAccessor
                .HttpContext
                .User
                .GetId();
    }
}
