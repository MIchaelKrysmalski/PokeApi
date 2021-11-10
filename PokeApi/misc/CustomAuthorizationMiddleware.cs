using Microsoft.AspNetCore.Http;
using PokeApi.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.misc
{
    public class CustomAuthorizationMiddleware
    {
        private IRepository repository;
        private RequestDelegate next;

        public CustomAuthorizationMiddleware(RequestDelegate next, IRepository repository)
        {
            this.next = next;
            this.repository = repository;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Path.StartsWithSegments("/Authentication"))
            {
                if (context.Session.GetInt32("userId").HasValue)
                {
                    var userId = context.Session.GetInt32("userId").Value;
                    var user = repository.users.getById(userId);
                    context.Items["user"] = user;
                }
                else
                {
                    context.Response.Redirect("/Authentication/Login");
                }
            }
            await next(context);
        }
    }
}
