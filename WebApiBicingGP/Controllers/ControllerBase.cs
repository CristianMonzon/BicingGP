using BicingGP.DataProvider.Providers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApiBicingGP.Controllers
{

    public abstract class ControllerBase : Controller
    {
        protected IHttpClientFactory _httpClientFactory;
        protected IMediator _mediator;
        protected IProvider _provider;
    }
}
