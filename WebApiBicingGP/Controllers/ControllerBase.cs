using BicingGP.Application.Providers;
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

    public abstract class ControllerBaseGeneric<TStation,TStatus>  : Controller
    {
        protected IHttpClientFactory _httpClientFactoryGeneric;
        protected IMediator _mediator;
        protected IProviderGeneric<TStation,TStatus> _providerGeneric;
    }
}
