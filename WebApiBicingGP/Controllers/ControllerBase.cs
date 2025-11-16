using BicingGPApplication.Entities;
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

    public abstract class ControllerBaseGeneric<TProviderGeneric, TProvider, TDTO> : Controller 
        where TProviderGeneric : IProviderGeneric<TDTO> 
    {
        protected IHttpClientFactory _httpClientFactoryGeneric;
        protected IMediator _mediator;
        protected TProvider _provider;
        protected IProviderGeneric<TDTO> _providerGeneric;
    }
}
