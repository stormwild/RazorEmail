using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace RazorEmail.Lib.Services
{
    public class RazorRenderer : IRazorRenderer
    {
        private IRazorViewEngine _viewEngine;
        private ITempDataProvider _dataProvider;
        private IServiceProvider _serviceProvider;

        public RazorRenderer(
            IRazorViewEngine viewEngine,
            ITempDataProvider dataProvider,
            IServiceProvider serviceProvider)
        {
            _viewEngine = viewEngine;
            _dataProvider = dataProvider;
            _serviceProvider = serviceProvider;
        }

        public Task<string> RenderAsync<TModel>(string view, TModel model)
        {
            var actionContext = GetActionContext();
            return null;
        }

        private ActionContext GetActionContext() {
            var ctx = new DefaultHttpContext();
            ctx.RequestServices = _serviceProvider;
            return new ActionContext(ctx, new RouteData(), new ActionDescriptor());
        }
    }
}