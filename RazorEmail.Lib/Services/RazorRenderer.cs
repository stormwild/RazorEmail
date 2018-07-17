using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;

namespace RazorEmail.Lib.Services
{
    public class RazorRenderer : IRazorRenderer
    {
        private IRazorViewEngine _engine;
        private ITempDataProvider _dataProvider;
        private IServiceProvider _serviceProvider;

        public RazorRenderer(
            IRazorViewEngine engine,
            ITempDataProvider dataProvider,
            IServiceProvider serviceProvider)
        {
            _engine = engine;
            _dataProvider = dataProvider;
            _serviceProvider = serviceProvider;
        }

        public Task<string> RenderAsync<TModel>(string view, TModel model)
        {
            
        }
    }
}